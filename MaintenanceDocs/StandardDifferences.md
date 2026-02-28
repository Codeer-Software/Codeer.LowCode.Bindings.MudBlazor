# Standard Differences - MudBlazor Library

## 未実装のコンポーネント

### LabelFieldComponent
標準にはあるが MudBlazor では未実装。必要に応じて追加が必要。
- ヘッディングスタイル (H1-H6)
- RelativeField のテキスト自動表示
- IsRequired マーク (*)
- クリックハンドラ + cursor:pointer

### AnchorTagFieldComponent
標準にはあるが MudBlazor では未実装。必要に応じて追加が必要。
- URL/HistoryBack/HistoryForward リンク
- 新しいタブで開く
- アイコン表示
- 画像リソースパス

## internal API の代替実装

### Field.Localize()
```csharp
// internal なので使えない → public API で代替
Field.Services.AppInfoService.Localize(text)
```

### Field.GetRowCount()
```csharp
// internal なので使えない → 自前実装
private int GetRowCount() {
    if (!Field.Design.IsAutoFitRows) return Field.Design.Rows ?? 3;
    var rows = Field.Design.Rows ?? 1;
    var lineCount = Field.Value?.Split(new[] { "\r\n", "\n" }, StringSplitOptions.None).Length ?? 1;
    return Math.Max(rows, lineCount);
}
```

### LabelField.IsRequired()
internal メソッド。関連フィールドの Design.IsRequired を直接チェックする必要がある。
(MudBlazor では LabelField 自体が未実装のため現時点では不要)

## MudBlazor 固有のデザインプロパティ

### MudBlazor.Variant
MudBlazor コンポーネントの見た目バリアント (Text, Filled, Outlined)。
各 Design クラスで `MudVariant` または `Variant` として定義。

### MudBlazor.Color
ボタン等の色設定 (Default, Primary, Secondary, etc.)。
各 Design クラスで `Color` として定義。

## IgnoreBaseProperties 設定

| Design Class | 非表示にしたプロパティ |
|---|---|
| MudButtonFieldDesign | Variant, ImageResourceSet, ShowTextInToolTip |
| MudSubmitButtonFieldDesign | ImageResourceSet |

MudBlazor UI では Bootstrap の Variant や画像リソースセットが使えないため非表示。

## MudSlider の制約

`MudSlider<T>` は nullable 型を直接受け付けない。
`decimal SliderValue => Field.Value ?? 0` のように非 nullable に変換する。

## FileField API

v1.2.49 で `SetFile` → `SetFileAsync` に変更。`UploadFile` は internal。
```csharp
await Field.SetFileAsync(e.File.Name, new StreamContent(file.OpenReadStream(maxAllowedSize)));
```

## DateTime の SaveAsUtc 対応

DateTimeFieldComponent の ViewOnly モードで、`SaveAsUtc` が有効な場合は
`ToLocalTime()` で表示用にローカル時間に変換する。

## BooleanField の UIType

MudBlazor では3つのUIタイプを使い分け:
- `BooleanUIType.CheckBox` → `<MudCheckBox>`
- `BooleanUIType.Switch` → `<MudSwitch>`
- `BooleanUIType.ToggleButton` → `<InternalMudToggleButton>`

List レイアウト時に ToggleButton 以外は Label を空文字にする。

## RadioGroupField の PopulateRadioButtons

List レイアウトで `PopulateRadioButtons` が true の場合、
読み取り専用テキストではなくインタラクティブな `<MudRadioGroup>` を表示する。

## TextField の _tempValue パターン

テキストフィールドの値バインディングで非同期 `SetValueAsync` 呼び出し中に
値が消えるバグを防ぐため、`_tempValue` パターンを使用:
```csharp
private string? _tempValue;
private string? Value {
    get {
        if (_tempValue != null) { var ret = _tempValue; _tempValue = null; return ret; }
        return Field.Value;
    }
}
private async Task RaiseOnValueChanged(string? value) {
    _tempValue = value;
    await Field.SetValueAsync(value);
}
```

## LinkField の ModalBase Title

現在 "検索" がハードコードされている。ローカライズが必要な場合は Resource ファイルに移動すべき。

## SelectField の OnFocus ハンドラ

`OnAfterRenderAsync` で毎回 `OnFocusAsync()` を呼ぶ実装。
初回レンダリング時に選択肢が更新された場合のバグ回避。
