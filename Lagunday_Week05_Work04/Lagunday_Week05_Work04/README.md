# Product Form (WinForms, .NET 8)

Demonstrates the common controls from the "C# Common Controls" slides:
Form, Label, TextBox, TextBox (Multiline), ComboBox, GroupBox, RadioButton, CheckBox, Button.

## Run
Requires Windows + the .NET 8 SDK.

    dotnet run

Or open `Lagunday_Week05_Work04.csproj` in Visual Studio 2022 and press F5.

## Behavior
- Barcode label shows "available" / "already in use" as you type.
- Markup (%) is calculated automatically from Cost and Price.
- ENTER = Save (AcceptButton), ESC = Cancel (CancelButton).
- Save validates, stores the product in memory, and resets the form.
