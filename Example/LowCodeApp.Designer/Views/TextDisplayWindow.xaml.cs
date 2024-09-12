using MahApps.Metro.Controls;

namespace LowCodeApp.Designer.Views
{
    public partial class TextDisplayWindow : MetroWindow
    {
        public string DisplayText
        {
            get => _text.Text;
            set => _text.Text = value;
        }

        public TextDisplayWindow()
            => InitializeComponent();
    }
}
