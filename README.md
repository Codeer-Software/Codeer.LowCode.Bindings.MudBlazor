# Bindings.MudBlazor

Codeer.LowCode.BlazorにMudBlazor UIコンポーネントを追加するためのライブラリです。

## インストール

### パッケージのインストール

LowCodeApp.Client.Shared プロジェクトにNuGetから次のパッケージをインストールしてください。

- Codeer.LowCode.Bindings.MudBlazor

### コードの修正

ライブラリの使用に必要なコードを以下のプロジェクトにそれぞれ追加する必要があります。

- LowCodeApp.Client
- LowCodeApp.Shared
- LowCodeApp.Designer

#### LowCodeApp.Client

`Program.cs` に以下のコードを追加してください。

```csharp
MudBlazorLoader.LoadAssemblies();
builder.Services.AddMudServices();
```

`MainLayout.razor` に以下のコードを追加してください。

```html
@using Codeer.LowCode.Bindings.MudBlazor.Installer

<MudBlazorInstaller />
```

#### LowCodeApp.Server

`Program.cs` に以下のコードを追加してください。

```csharp
MudBlazorLoader.LoadAssemblies();
```

#### LowCodeApp.Designer

`App.xaml.cs` に以下のコードを追加してください。

```csharp
MudBlazorLoader.LoadAssemblies();
Services.AddMudServices();
BlazorRuntime.InstallAssemblyInitializer(typeof(MudBlazorInstaller).Assembly);
BlazorRuntime.InstallRenderProvider(typeof(MudBlazorInstaller));
```

## 使用方法

DesignerからMudBlazor UIを使用したコンポーネントが配置できるようになっています。
通常のButtonやBooleanの代わりにMudButtonやMudBooleanを使用してください。

// 画像

## サポートしているタイプ

Codeer.LowCode.Blazorの標準コントロールに対応するMudBlazorコントロールは以下の通りです。

| Codeer.LowCode.Blazor | MudBlazor |
| --- | --- |
| Boolean | MudBoolean |
| Button | MudButton |
| Date | MudDate |
| DateTime | MudDateTime |
| Id | MudId |
| Link | MudLink |
| Number | MudNumber |
| Password | MudPassword |
| RadioButton | MudRadioButton |
| RadioGroup | MudRadioGroup |
| Select | MudSelect |
| Text | MudText |
| Time | MudTime |

## カスタムコントロール

このライブラリでは次の2個のカスタムコントロールが提供されています。

- MudCalendar
- MudChart

### MudCalendar

`Heron.MudCalendar` を使用してカレンダーを表示することができます。

![image](https://github.com/user-attachments/assets/789c8147-831b-447a-96cf-48a52f8281fc)

## MudChart

データをグラフで表示するためのコントロールです。

![image](https://github.com/user-attachments/assets/7ca8fab0-7a6e-441c-bec5-6469ebce1ca4)

