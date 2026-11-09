using System.Globalization;

namespace Lagunday_Week05_Work04;

public partial class ProductForm : Form
{

    private readonly List<Product> _products = new();

    public ProductForm()
    {
        InitializeComponent();
    }

    private void ProductForm_Load(object? sender, EventArgs e)
    {
        cboCategory.Items.AddRange(new object[] { "Beverages", "Snacks", "Dairy", "Household", "Personal Care" });
        ResetForm();
    }

    private void txtBarcode_TextChanged(object? sender, EventArgs e)
    {
        string code = txtBarcode.Text.Trim();
        if (code.Length == 0)
        {
            lblBarcodeStatus.Text = "";
            return;
        }

        bool taken = _products.Any(p => p.Barcode.Equals(code, StringComparison.OrdinalIgnoreCase));
        lblBarcodeStatus.Text = taken ? "Barcode is already in use." : "Barcode is available.";
        lblBarcodeStatus.ForeColor = taken ? Color.Firebrick : Color.SeaGreen;
    }

    private void PriceInputs_Changed(object? sender, EventArgs e)
    {
        if (TryGetDecimal(txtCost.Text, out decimal cost) &&
            TryGetDecimal(txtPrice.Text, out decimal price) && cost > 0)
        {
            txtMarkup.Text = ((price - cost) / cost * 100m).ToString("N2");
        }
        else
        {
            txtMarkup.Text = "";
        }
    }

    private void DecimalOnly_KeyPress(object? sender, KeyPressEventArgs e)
    {
        var tb = (TextBox)sender!;
        string dot = CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator;
        if (char.IsControl(e.KeyChar)) return;
        if (char.IsDigit(e.KeyChar)) return;
        if (e.KeyChar.ToString() == dot && !tb.Text.Contains(dot)) return;
        e.Handled = true;
    }

    private void btnSave_Click(object? sender, EventArgs e)
    {
        if (!ValidateInput(out decimal cost, out decimal price)) return;

        var product = new Product(
            Barcode: txtBarcode.Text.Trim(),
            Name: txtName.Text.Trim(),
            Description: txtDescription.Text.Trim(),
            Category: cboCategory.SelectedItem!.ToString()!,
            Origin: rdoLocal.Checked ? "Local" : "Abroad",
            IsActive: chkActive.Checked,
            Cost: cost,
            Price: price,
            Markup: (price - cost) / cost * 100m);

        _products.Add(product);
        MessageBox.Show($"Product \"{product.Name}\" saved.\nTotal products: {_products.Count}",
            "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
        ResetForm();
    }

    private void btnClear_Click(object? sender, EventArgs e) => ResetForm();

    private void btnCancel_Click(object? sender, EventArgs e) => Close();

    private bool ValidateInput(out decimal cost, out decimal price)
    {
        cost = price = 0;

        if (string.IsNullOrWhiteSpace(txtBarcode.Text)) return Fail("Barcode is required.", txtBarcode);
        if (_products.Any(p => p.Barcode.Equals(txtBarcode.Text.Trim(), StringComparison.OrdinalIgnoreCase)))
            return Fail("That barcode is already in use.", txtBarcode);
        if (string.IsNullOrWhiteSpace(txtName.Text)) return Fail("Name is required.", txtName);
        if (cboCategory.SelectedIndex < 0) return Fail("Please choose a category.", cboCategory);
        if (!TryGetDecimal(txtCost.Text, out cost) || cost <= 0) return Fail("Enter a valid cost greater than 0.", txtCost);
        if (!TryGetDecimal(txtPrice.Text, out price) || price <= 0) return Fail("Enter a valid price greater than 0.", txtPrice);
        return true;
    }

    private static bool Fail(string message, Control focus)
    {
        MessageBox.Show(message, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        focus.Focus();
        return false;
    }

    private static bool TryGetDecimal(string text, out decimal value) =>
        decimal.TryParse(text, NumberStyles.Number, CultureInfo.CurrentCulture, out value);

    private void ResetForm()
    {
        txtBarcode.Clear();
        txtName.Clear();
        txtDescription.Clear();
        cboCategory.SelectedIndex = -1;
        rdoLocal.Checked = true;
        chkActive.Checked = false;
        txtCost.Clear();
        txtPrice.Clear();
        txtMarkup.Clear();
        lblBarcodeStatus.Text = "";
        txtBarcode.Focus();
    }
}
