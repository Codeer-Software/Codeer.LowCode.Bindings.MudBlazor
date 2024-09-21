using OpenQA.Selenium;
using Selenium.StandardControls;
using Selenium.StandardControls.PageObjectUtility;
using Selenium.StandardControls.TestAssistant.GeneratorToolKit;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.IO;
using System.Linq;

namespace SeleniumTest
{
  public static class CaptureAttachTreeMenuAction
  {
    [MenuAction]
    public static void Url(PageBase pageObject, string accessPath)
    {
      var web = pageObject.Driver;
      CaptureAdaptor.AddCode(accessPath + ".Url = " + ToLiteral(web.Url) + ";");
    }

    [MenuAction(DisplayName = "Alert - Accept")]
    public static void AlertAccept(PageBase pageObject, string accessPath)
    {
      CaptureAdaptor.AddCode(accessPath + ".WaitForAlert().Accept();");
      CaptureAdaptor.AddUsing("Selenium.StandardControls");
    }

    [MenuAction(DisplayName = "Alert - Dismiss")]
    public static void AlertDismiss(PageBase pageObject, string accessPath)
    {
      CaptureAdaptor.AddCode(accessPath + ".WaitForAlert().Dismiss();");
      CaptureAdaptor.AddUsing("Selenium.StandardControls");
    }

    [MenuAction]
    public static void AssertAll(PageBase pageObject, string accessPath)
    {
      if (!typeof(MappingBase).IsAssignableFrom(pageObject.GetType())) return;

      foreach (var e in pageObject.GetType().GetProperties().Where(e => e.DeclaringType == pageObject.GetType()))
      {
        var childAccessPath = accessPath + "." + e.Name;
        var objTmp = e.GetValue(pageObject);
        if (objTmp == null) continue;

        if (objTmp is AnchorDriver anchor) Assert(anchor, childAccessPath);
        else if (objTmp is DateDriver date) Assert(date, childAccessPath);
        else if (objTmp is DropDownListDriver dropDown) Assert(dropDown, childAccessPath);
        else if (objTmp is LabelDriver label) Assert(label, childAccessPath);
        else if (objTmp is RadioButtonDriver radioButton) Assert(radioButton, childAccessPath);
        else if (objTmp is CheckBoxDriver checkBox) Assert(checkBox, childAccessPath);
        else if (objTmp is TextBoxDriver textBox) Assert(textBox, childAccessPath);
        else if (objTmp is IWebElement webElement) Assert(webElement, childAccessPath);
      }
    }

    [MenuAction]
    public static void Assert(AnchorDriver anchor, string accessPath)
        => CaptureAdaptor.AddCode(accessPath + ".Text.Is(" + ToLiteral(anchor.Text) + ");");

    [MenuAction]
    public static void Assert(DateDriver date, string accessPath)
        => CaptureAdaptor.AddCode(accessPath + ".Text.Is(" + ToLiteral(date.Text) + ");");

    [MenuAction]
    public static void Assert(DropDownListDriver dropdown, string accessPath)
        => CaptureAdaptor.AddCode(accessPath + ".Text.Is(" + ToLiteral(dropdown.Text) + ");");

    [MenuAction]
    public static void Assert(LabelDriver label, string accessPath)
        => CaptureAdaptor.AddCode(accessPath + ".Text.Is(" + ToLiteral(label.Text) + ");");

    [MenuAction]
    public static void Assert(RadioButtonDriver radio, string accessPath)
        => CaptureAdaptor.AddCode(accessPath + ".Checked.Is(" + radio.Checked.ToString().ToLower() + ");");

    [MenuAction]
    public static void Assert(CheckBoxDriver check, string accessPath)
        => CaptureAdaptor.AddCode(accessPath + ".Checked.Is(" + check.Checked.ToString().ToLower() + ");");

    [MenuAction]
    public static void Assert(TextBoxDriver textBox, string accessPath)
        => CaptureAdaptor.AddCode(accessPath + ".Text.Is(" + ToLiteral(textBox.Text) + ");");

    [MenuAction]
    public static void Assert(IWebElement element, string accessPath)
        => CaptureAdaptor.AddCode(accessPath + ".Text.Is(" + ToLiteral(element.Text) + ");");

    static string ToLiteral(string text)
    {
      using (var writer = new StringWriter())
      using (var provider = CodeDomProvider.CreateProvider("CSharp"))
      {
        var expression = new CodePrimitiveExpression(text);
        provider.GenerateCodeFromExpression(expression, writer, options: null);
        return writer.ToString();
      }
    }
  }
}
