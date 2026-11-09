namespace Lagunday_Week05_Work04;

partial class ProductForm
{
    private System.ComponentModel.IContainer? components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && components != null) components.Dispose();
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        lblBarcode = new Label();
        txtBarcode = new TextBox();
        lblBarcodeStatus = new Label();
        lblName = new Label();
        txtName = new TextBox();
        lblDescription = new Label();
        txtDescription = new TextBox();
        lblCategory = new Label();
        cboCategory = new ComboBox();
        lblOrigin = new Label();
        grpManufactured = new GroupBox();
        rdoLocal = new RadioButton();
        rdoAbroad = new RadioButton();
        lblStatus = new Label();
        chkActive = new CheckBox();
        lblCost = new Label();
        txtCost = new TextBox();
        lblPrice = new Label();
        txtPrice = new TextBox();
        lblMarkup = new Label();
        txtMarkup = new TextBox();
        btnCancel = new Button();
        btnClear = new Button();
        btnSave = new Button();
        grpManufactured.SuspendLayout();
        SuspendLayout();

        lblBarcode.AutoSize = true; lblBarcode.Location = new Point(15, 22); lblBarcode.Text = "Barcode";
        txtBarcode.Location = new Point(100, 18); txtBarcode.Size = new Size(240, 23); txtBarcode.MaxLength = 20;
        txtBarcode.TextChanged += txtBarcode_TextChanged;
        lblBarcodeStatus.AutoSize = true; lblBarcodeStatus.Location = new Point(100, 44);
        lblBarcodeStatus.Font = new Font("Segoe UI", 8F, FontStyle.Italic);
        lblBarcodeStatus.ForeColor = SystemColors.GrayText; lblBarcodeStatus.Text = "";

        lblName.AutoSize = true; lblName.Location = new Point(15, 66); lblName.Text = "Name";
        txtName.Location = new Point(100, 62); txtName.Size = new Size(240, 23); txtName.MaxLength = 100;

        lblDescription.AutoSize = true; lblDescription.Location = new Point(15, 93); lblDescription.Text = "Description";
        txtDescription.Location = new Point(100, 90); txtDescription.Multiline = true;
        txtDescription.ScrollBars = ScrollBars.Vertical; txtDescription.Size = new Size(240, 62);

        lblCategory.AutoSize = true; lblCategory.Location = new Point(15, 166); lblCategory.Text = "Category";
        cboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        cboCategory.Location = new Point(100, 162); cboCategory.Size = new Size(240, 23);

        lblOrigin.AutoSize = true; lblOrigin.Location = new Point(15, 204); lblOrigin.Text = "Origin";
        grpManufactured.Controls.Add(rdoLocal);
        grpManufactured.Controls.Add(rdoAbroad);
        grpManufactured.Location = new Point(100, 192); grpManufactured.Size = new Size(240, 50);
        grpManufactured.TabStop = false; grpManufactured.Text = "Manufactured";
        rdoLocal.AutoSize = true; rdoLocal.Checked = true; rdoLocal.Location = new Point(20, 20); rdoLocal.Text = "Local";
        rdoAbroad.AutoSize = true; rdoAbroad.Location = new Point(120, 20); rdoAbroad.Text = "Abroad";

        lblStatus.AutoSize = true; lblStatus.Location = new Point(15, 256); lblStatus.Text = "Status";
        chkActive.AutoSize = true; chkActive.Location = new Point(105, 255); chkActive.Text = "Active";

        lblCost.AutoSize = true; lblCost.Location = new Point(15, 292); lblCost.Text = "Cost";
        txtCost.Location = new Point(15, 310); txtCost.Size = new Size(92, 23); txtCost.TextAlign = HorizontalAlignment.Right;
        txtCost.TextChanged += PriceInputs_Changed;
        txtCost.KeyPress += DecimalOnly_KeyPress;

        lblPrice.AutoSize = true; lblPrice.Location = new Point(113, 292); lblPrice.Text = "Price";
        txtPrice.Location = new Point(113, 310); txtPrice.Size = new Size(92, 23); txtPrice.TextAlign = HorizontalAlignment.Right;
        txtPrice.TextChanged += PriceInputs_Changed;
        txtPrice.KeyPress += DecimalOnly_KeyPress;

        lblMarkup.AutoSize = true; lblMarkup.Location = new Point(245, 292); lblMarkup.Text = "Markup (%)";
        txtMarkup.Location = new Point(245, 310); txtMarkup.Size = new Size(95, 23); txtMarkup.ReadOnly = true;
        txtMarkup.TabStop = false; txtMarkup.TextAlign = HorizontalAlignment.Right;

        btnCancel.Location = new Point(15, 352); btnCancel.Size = new Size(92, 32); btnCancel.Text = "Cancel";
        btnCancel.DialogResult = DialogResult.Cancel; btnCancel.Click += btnCancel_Click;
        btnClear.Location = new Point(113, 352); btnClear.Size = new Size(92, 32); btnClear.Text = "Clear";
        btnClear.Click += btnClear_Click;
        btnSave.Location = new Point(245, 352); btnSave.Size = new Size(95, 32); btnSave.Text = "Save";
        btnSave.Font = new Font("Segoe UI", 9F, FontStyle.Bold); btnSave.Click += btnSave_Click;

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        AcceptButton = btnSave;
        CancelButton = btnCancel;
        ClientSize = new Size(360, 404);
        FormBorderStyle = FormBorderStyle.FixedDialog;
        MaximizeBox = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Product Form";
        Controls.AddRange(new Control[] {
            lblBarcode, txtBarcode, lblBarcodeStatus, lblName, txtName, lblDescription, txtDescription,
            lblCategory, cboCategory, lblOrigin, grpManufactured, lblStatus, chkActive,
            lblCost, txtCost, lblPrice, txtPrice, lblMarkup, txtMarkup,
            btnCancel, btnClear, btnSave });
        Load += ProductForm_Load;
        grpManufactured.ResumeLayout(false);
        grpManufactured.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    private Label lblBarcode, lblBarcodeStatus, lblName, lblDescription, lblCategory, lblOrigin, lblStatus, lblCost, lblPrice, lblMarkup;
    private TextBox txtBarcode, txtName, txtDescription, txtCost, txtPrice, txtMarkup;
    private ComboBox cboCategory;
    private GroupBox grpManufactured;
    private RadioButton rdoLocal, rdoAbroad;
    private CheckBox chkActive;
    private Button btnCancel, btnClear, btnSave;
}
