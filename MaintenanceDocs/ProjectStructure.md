# Project Structure - MudBlazor Bindings

## Solution Structure

```
Codeer.LowCode.Bindings.MudBlazor.sln
├── Codeer.LowCode.Bindings.MudBlazor/                    # メインライブラリ
├── Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers/    # Selenium テストドライバ
├── Example/
│   ├── LowCodeApp.Client/           # Blazor WebAssembly クライアント
│   ├── LowCodeApp.Client.Shared/    # クライアント共有ライブラリ
│   ├── LowCodeApp.Server/           # ASP.NET Core サーバー
│   ├── LowCodeApp.Server.Shared/    # サーバー共有ライブラリ
│   └── LowCodeApp.Designer/         # WPF デザイナー
└── Test/
    ├── SeleniumTest/                 # Selenium テスト
    ├── SeleniumTestData/             # テストデータ
    └── UnitTest/                     # ユニットテスト
```

## NuGet パッケージバージョン (2026-02-28 更新)

### メインライブラリ
| Package | Version |
|---|---|
| Codeer.LowCode.Blazor | 1.2.49 |
| MudBlazor | 7.8.0 |
| Heron.MudCalendar | 2.0.3 |
| Microsoft.AspNetCore.WebUtilities | 8.0.24 |
| Microsoft.AspNetCore.Components.WebAssembly | 8.0.24 |
| Microsoft.Extensions.Http | 8.0.1 |

### Example/LowCodeApp.Client
| Package | Version |
|---|---|
| Microsoft.AspNetCore.Components.WebAssembly | 8.0.24 |
| Microsoft.AspNetCore.Components.WebAssembly.DevServer | 8.0.24 |

### Example/LowCodeApp.Client.Shared
| Package | Version |
|---|---|
| Codeer.LowCode.Blazor | 1.2.49 |
| Excel.Report.PDF | 0.32.0 |
| Microsoft.AspNetCore.WebUtilities | 8.0.24 |
| Microsoft.AspNetCore.Components.WebAssembly | 8.0.24 |
| Microsoft.AspNetCore.SignalR.Client | 8.0.24 |
| Microsoft.Extensions.Http | 8.0.1 |
| Sotsera.Blazor.Toaster | 3.0.0 |

### Example/LowCodeApp.Server.Shared
| Package | Version |
|---|---|
| Codeer.LowCode.Blazor | 1.2.49 |
| Microsoft.Data.SqlClient | 5.2.2 |
| Npgsql | 8.0.5 |
| Oracle.ManagedDataAccess.Core | 23.6.0 |
| System.Data.SQLite | 1.0.119 |
| Microsoft.EntityFrameworkCore | 8.0.24 |
| Microsoft.EntityFrameworkCore.Relational | 8.0.24 |
| Dapper | 2.1.66 |

### Example/LowCodeApp.Server
| Package | Version |
|---|---|
| Azure.Storage.Blobs | 12.22.1 |
| Microsoft.AspNetCore.Components.WebAssembly.Server | 8.0.24 |

### Example/LowCodeApp.Designer
| Package | Version |
|---|---|
| Codeer.LowCode.Blazor.Designer | 1.2.49 |

### SeleniumDrivers
| Package | Version |
|---|---|
| Codeer.LowCode.Blazor.Designer | 1.2.49 |
| Codeer.LowCode.Blazor.SeleniumDrivers | 0.24.0 |

## メインライブラリ ファイル構成

```
Codeer.LowCode.Bindings.MudBlazor/
├── Codeer.LowCode.Bindings.MudBlazor.csproj
├── _Imports.razor
│
├── Components/                      # 18 フィールドコンポーネント
│   ├── MudTextFieldComponent.razor
│   ├── MudNumberFieldComponent.razor
│   ├── MudBooleanFieldComponent.razor
│   ├── MudDateFieldComponent.razor
│   ├── MudDateTimeFieldComponent.razor
│   ├── MudTimeFieldComponent.razor
│   ├── MudButtonFieldComponent.razor
│   ├── MudSubmitButtonFieldComponent.razor
│   ├── MudLinkFieldComponent.razor
│   ├── MudSelectFieldComponent.razor
│   ├── MudIdFieldComponent.razor
│   ├── MudRadioGroupFieldComponent.razor
│   ├── MudRadioButtonFieldComponent.razor
│   ├── MudPasswordFieldComponent.razor
│   ├── MudFileFieldComponent.razor
│   ├── MudCalendarFieldComponent.razor     # 独自
│   ├── MudChartFieldComponent.razor        # 独自
│   └── (各 .razor.css ファイル)
│
├── Designs/                         # 17 デザインクラス
│   ├── MudTextFieldDesign.cs
│   ├── MudNumberFieldDesign.cs
│   ├── MudBooleanFieldDesign.cs
│   ├── MudDateFieldDesign.cs
│   ├── MudDateTimeFieldDesign.cs
│   ├── MudTimeFieldDesign.cs
│   ├── MudButtonFieldDesign.cs
│   ├── MudSubmitButtonFieldDesign.cs
│   ├── MudLinkFieldDesign.cs
│   ├── MudSelectFieldDesign.cs
│   ├── MudIdFieldDesign.cs
│   ├── MudRadioGroupFieldDesign.cs
│   ├── MudRadioButtonFieldDesign.cs
│   ├── MudPasswordFieldDesign.cs
│   ├── MudFileFieldDesign.cs
│   ├── MudCalendarFieldDesign.cs           # 独自
│   └── MudChartFieldDesign.cs              # 独自
│
├── Search/                          # 10 検索コンポーネント
│   ├── MudTextComponent.razor
│   ├── MudNumberComponent.razor
│   ├── MudBooleanComponent.razor
│   ├── MudDateComponent.razor
│   ├── MudDateTimeComponent.razor
│   ├── MudTimeComponent.razor
│   ├── MudLinkComponent.razor
│   ├── MudSelectComponent.razor
│   ├── MudRadioGroupComponent.razor
│   └── MudFileComponent.razor
│
├── Infrastructure/
│   └── MudFieldComponentBase.cs    # 基底クラス (MudDesign プロパティ提供)
│
├── Internal/
│   ├── DateTimeHelper.cs
│   └── Components/
│       ├── InternalMudDatePicker.razor
│       ├── InternalMudTimePicker.razor
│       ├── InternalMudToggleButton.razor
│       └── InternalMudToggleButton.razor.css
│
├── Fields/
│   ├── MudCalendarField.cs         # 独自フィールド
│   └── MudChartField.cs            # 独自フィールド
│
├── Models/
│   └── ModuleCalendarItem.cs
│
├── Installer/
│   ├── MudBlazorInstaller.razor
│   └── MudBlazorLoader.cs
│
└── Properties/
    ├── Resource.resx
    ├── Resource.ja-JP.resx
    └── Resource.Designer.cs
```

## SeleniumDrivers 構成

```
Codeer.LowCode.Bindings.MudBlazor.SeleniumDrivers/
├── Components/          # 16 フィールドドライバ
│   ├── MudBooleanFieldToggleDriver.cs
│   ├── MudButtonFieldDriver.cs
│   ├── MudDateFieldDriver.cs
│   ├── MudDateTimeFieldDriver.cs
│   ├── MudFileFieldDriver.cs
│   ├── MudIdFieldDriver.cs
│   ├── MudLinkFieldDriver.cs
│   ├── MudNumberFieldDriver.cs
│   ├── MudPasswordFieldDriver.cs
│   ├── MudRadioButtonFieldDriver.cs
│   ├── MudRadioGroupFieldDriver.cs
│   ├── MudSelectFieldDriver.cs
│   ├── MudSubmitButtonFieldDriver.cs
│   ├── MudTextFieldDriver.cs
│   ├── MudTimeFieldDriver.cs
│   └── MudToggleButtonDriver.cs
├── Native/              # MudBlazor ネイティブコンポーネント用ドライバ
│   ├── MudRadioButtonDriver.cs
│   ├── MudSelectDriver.cs
│   ├── MudTimePickerDriver.cs
│   └── MudToggleButtonDriver.cs
└── Search/              # 12 検索フィールドドライバ
    ├── MudBooleanFieldSearchDriver.cs
    ├── MudDateFieldSearchDriver.cs
    ├── MudDateTimeFieldSearchDriver.cs
    ├── MudFileFieldSearchDriver.cs
    ├── MudLinkFieldSearchDriver.cs
    ├── MudNumberFieldSearchDriver.cs
    ├── MudRadioGroupFieldSearchDriver.cs
    ├── MudSelectFieldSearchDriver.cs
    ├── MudSelectListItemDriver.cs
    ├── MudTextFieldSearchDriver.cs
    └── MudTimeFieldSearchDriver.cs
```
