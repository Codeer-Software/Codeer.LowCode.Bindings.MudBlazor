# Codeer.LowCode.Bindings.MudBlazor - Claude Code Guide

## Overview

Codeer.LowCode.Blazor の拡張 Field ライブラリ。標準の Bootstrap ベースコンポーネントを
MudBlazor コンポーネントに置き換える。Calendar/Chart フィールドなど独自コンポーネントも含む。

- **Version**: 0.4.0
- **Target**: .NET 8.0
- **Base Library**: Codeer.LowCode.Blazor (現在 v1.2.49)
- **UI Library**: MudBlazor (現在 v7.8.0)
- **Standard Library Source** (参照用): `C:\tfs\codeer\Codeer.LowCode.Blazor`

## Architecture

### 3ファイル構成パターン (各フィールド型)

```
Designs/MudXxxFieldDesign.cs     → 標準の XxxFieldDesign を継承
Components/MudXxxFieldComponent.razor → MudFieldComponentBase<TField, TDesign> を継承
Search/MudXxxComponent.razor     → 検索用コンポーネント (該当する型のみ)
```

### Design クラスの実装パターン

```csharp
[IgnoreBaseProperties(nameof(Variant), nameof(ImageResourceSet), nameof(ShowTextInToolTip))]
public class MudXxxFieldDesign : XxxFieldDesign
{
    public MudXxxFieldDesign() => TypeFullName = typeof(MudXxxFieldDesign).FullName!;
    public override string GetWebComponentTypeFullName() => typeof(MudXxxFieldComponent).FullName!;
    public override string GetSearchWebComponentTypeFullName() => typeof(MudXxxComponent).FullName!;

    [Designer(DisplayName = "Variant")]
    public Variant MudVariant { get; set; }  // MudBlazor.Variant
    [Designer]
    public Color Color { get; set; }  // MudBlazor.Color
}
```

### Component の実装パターン

```razor
@inherits MudFieldComponentBase<XxxField, MudXxxFieldDesign>

@if (IsViewMode) {
  <span class="d-block py-2">@ViewOnlyValue</span>
} else {
  <MudTextField @bind-Value:get="@Value" @bind-Value:set="@OnValueChanged"
                Variant="MudDesign.Variant" Error="!Field.IsValid" ErrorText="@(Field.ErrorText)" />
}

@code {
  private bool IsDisabled => Field.IsEnabled == false;
  private bool IsViewMode => Field.IsViewOnly;
  // Field.Services.AppInfoService.Localize() でローカライズ
  // Field.Services.AppInfoService.IsDesignMode でデザインモード判定
  // MudDesign プロパティで MudBlazor 固有のデザイン設定にアクセス
}
```

## Key Rules

### Localize は public API を使う
```csharp
// NG: Field.Localize() は internal - 外部アセンブリからアクセス不可
// OK:
Field.Services.AppInfoService.Localize(text)
```

### internal メソッドへのアクセス不可
以下は Codeer.LowCode.Blazor の internal メソッドなので直接呼べない:
- `Field.Localize()` → `Field.Services.AppInfoService.Localize()` を使う
- `Field.GetRowCount()` → 自前で計算 (AutoFitRows対応含む)
- `LabelField.IsRequired()` → 関連フィールドを自前で確認するロジックを実装

### MudSlider の制約
`MudSlider<T>` は nullable 型を受け付けない。
`decimal?` → `decimal` に変換してバインドする必要がある。

### ボタンのテキスト
- `ButtonField`: `Field.Text` を使う (スクリプトによる実行時上書きをサポート)
- `SubmitButtonField`: `Field.Design.Text` を使う

### MudBlazor バージョン
現在 v7.8.0。

## Build

```bash
# ソリューション全体ビルド
dotnet build Codeer.LowCode.Bindings.MudBlazor.sln

# メインライブラリのみ
dotnet build Codeer.LowCode.Bindings.MudBlazor/Codeer.LowCode.Bindings.MudBlazor.csproj
```

NuGet パッケージはビルド時に自動生成 (`GeneratePackageOnBuild: True`)。

## Maintenance Workflow

### 標準ライブラリ更新時の作業手順

1. **NuGet 更新**: `Codeer.LowCode.Blazor` のバージョンを上げる
2. **標準コンポーネントとの差分確認**: 各フィールドの標準実装を読み、変更点を特定
   - 標準コンポーネント: `C:\tfs\codeer\Codeer.LowCode.Blazor\Source\Codeer.LowCode.Blazor\Components\Fields\`
   - 標準検索コンポーネント: `C:\tfs\codeer\Codeer.LowCode.Blazor\Source\Codeer.LowCode.Blazor\Components\Search\`
3. **Design クラスの確認**: 新しいプロパティが追加された場合、`[IgnoreBaseProperties]` の更新要否を確認
4. **ビルド検証**: 全プロジェクトでビルドエラーがないことを確認
5. **Example プロジェクト**: 標準の Example (`C:\tfs\codeer\...\Source\App\`) と差分確認

### 詳細ドキュメント

`MaintenanceDocs/` フォルダに詳細情報あり:
- `ComponentMapping.md` - 全コンポーネントの対応表と実装状況
- `StandardDifferences.md` - 標準との既知の差異・制約事項
- `ProjectStructure.md` - ファイル構成の詳細

## File Layout

```
Codeer.LowCode.Bindings.MudBlazor/
├── _Imports.razor              # グローバル using
├── Components/                 # 18 フィールドコンポーネント (Calendar/Chart含む)
├── Designs/                    # 17 デザインクラス
├── Search/                     # 10 検索コンポーネント
├── Infrastructure/             # MudFieldComponentBase.cs (基底クラス)
├── Internal/                   # DateTimeHelper.cs, InternalMudDatePicker等
├── Fields/                     # MudCalendarField.cs, MudChartField.cs (独自フィールド)
├── Models/                     # ModuleCalendarItem.cs
├── Installer/                  # MudBlazorInstaller.razor, MudBlazorLoader.cs
└── Properties/                 # Resource.resx, Resource.ja-JP.resx (ローカライズ)
```

## Unique Components (標準にないもの)

- **MudCalendarField** - カレンダー表示 (Heron.MudCalendar 使用)
  - Design: `MudCalendarFieldDesign.cs`
  - Component: `MudCalendarFieldComponent.razor`
  - Field: `MudCalendarField.cs`
  - Model: `ModuleCalendarItem.cs`

- **MudChartField** - グラフ表示 (MudChart 使用)
  - Design: `MudChartFieldDesign.cs`
  - Component: `MudChartFieldComponent.razor`
  - Field: `MudChartField.cs`

## Code Style

- C# インデント: 4スペース
- Razor/JSON: 2スペース
- 改行: CRLF
- Nullable: enable
- ImplicitUsings: enable
- コンポーネント内のコードは `@code {}` に記述 (コードビハインド不使用)
