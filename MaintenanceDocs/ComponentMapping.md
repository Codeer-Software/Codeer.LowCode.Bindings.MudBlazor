# Component Mapping - MudBlazor vs Standard

## Field Components

| Standard Component | MudBlazor Component | Design Class | Search Component |
|---|---|---|---|
| TextFieldComponent | MudTextFieldComponent | MudTextFieldDesign | MudTextComponent |
| NumberFieldComponent | MudNumberFieldComponent | MudNumberFieldDesign | MudNumberComponent |
| BooleanFieldComponent | MudBooleanFieldComponent | MudBooleanFieldDesign | MudBooleanComponent |
| DateFieldComponent | MudDateFieldComponent | MudDateFieldDesign | MudDateComponent |
| DateTimeFieldComponent | MudDateTimeFieldComponent | MudDateTimeFieldDesign | MudDateTimeComponent |
| TimeFieldComponent | MudTimeFieldComponent | MudTimeFieldDesign | MudTimeComponent |
| ButtonFieldComponent | MudButtonFieldComponent | MudButtonFieldDesign | - |
| SubmitButtonFieldComponent | MudSubmitButtonFieldComponent | MudSubmitButtonFieldDesign | - |
| LinkFieldComponent | MudLinkFieldComponent | MudLinkFieldDesign | MudLinkComponent |
| SelectFieldComponent | MudSelectFieldComponent | MudSelectFieldDesign | MudSelectComponent |
| IdFieldComponent | MudIdFieldComponent | MudIdFieldDesign | - |
| RadioGroupFieldComponent | MudRadioGroupFieldComponent | MudRadioGroupFieldDesign | MudRadioGroupComponent |
| RadioButtonFieldComponent | MudRadioButtonFieldComponent | MudRadioButtonFieldDesign | - |
| PasswordFieldComponent | MudPasswordFieldComponent | MudPasswordFieldDesign | - |
| FileFieldComponent | MudFileFieldComponent | MudFileFieldDesign | MudFileComponent |
| LabelFieldComponent | *未実装* | - | - |
| AnchorTagFieldComponent | *未実装* | - | - |

## MudBlazor 独自コンポーネント

| MudBlazor Component | Design Class | Description |
|---|---|---|
| MudCalendarFieldComponent | MudCalendarFieldDesign | カレンダー表示 (Heron.MudCalendar) |
| MudChartFieldComponent | MudChartFieldDesign | グラフ表示 (MudChart) |

## MudBlazor UI コンポーネントの対応

| 標準 (Bootstrap) | MudBlazor |
|---|---|
| `<input type="text">` | `<MudTextField>` |
| `<textarea>` | `<MudTextField Lines="N">` |
| `<input type="number">` | `<MudNumericField>` |
| `<input type="range">` | `<MudSlider>` |
| `<input type="checkbox">` | `<MudCheckBox>` |
| Switch | `<MudSwitch>` |
| Toggle button | `<InternalMudToggleButton>` |
| `<input type="radio">` | `<MudRadioGroup>` + `<MudRadio>` |
| `<select>` | `<MudSelect>` + `<MudSelectItem>` |
| `<input type="date">` | `<InternalMudDatePicker>` |
| `<input type="datetime-local">` | `<InternalMudDatePicker>` (DateTimeHelper) |
| `<input type="time">` | `<InternalMudTimePicker>` |
| `<input type="password">` | `<MudTextField InputType="InputType.Password">` |
| `<button>` | `<MudButton>` |
| Stack layout | `<MudStack>` |
| Icon button | `<MudIconButton>` |

## 内部ヘルパーコンポーネント

| Component | Location | Description |
|---|---|---|
| InternalMudDatePicker | Internal/Components/ | MudBlazor DatePicker ラッパー |
| InternalMudTimePicker | Internal/Components/ | MudBlazor TimePicker ラッパー |
| InternalMudToggleButton | Internal/Components/ | MudBlazor ToggleButton ラッパー |
| DateTimeHelper | Internal/ | DateTime 変換ユーティリティ |
