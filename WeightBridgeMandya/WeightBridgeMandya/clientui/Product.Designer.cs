
namespace WeightBridgeMandya.clientui
{
    partial class Product
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.groupBox4 = new System.Windows.Forms.Panel();
            this.lblDelete = new MetroFramework.Controls.MetroLabel();
            this.lblEdit = new MetroFramework.Controls.MetroLabel();
            this.lblAdd = new MetroFramework.Controls.MetroLabel();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnAddnew = new MetroFramework.Controls.MetroButton();
            this.pnlDropdown = new System.Windows.Forms.Panel();
            this.lblProductName = new MetroFramework.Controls.MetroLabel();
            this.lblVehicleId = new System.Windows.Forms.Label();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cmbProductName = new MetroFramework.Controls.MetroComboBox();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.txtProductCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.txtProductName = new MetroFramework.Controls.MetroTextBox();
            this.groupBox4.SuspendLayout();
            this.pnlDropdown.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDelete);
            this.groupBox4.Controls.Add(this.lblEdit);
            this.groupBox4.Controls.Add(this.lblAdd);
            this.groupBox4.Controls.Add(this.btnEdit);
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.btnAddnew);
            this.groupBox4.Location = new System.Drawing.Point(692, 89);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(68, 279);
            this.groupBox4.TabIndex = 31;
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDelete.Location = new System.Drawing.Point(11, 241);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(48, 19);
            this.lblDelete.TabIndex = 15;
            this.lblDelete.Text = "Delete";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblEdit.Location = new System.Drawing.Point(20, 156);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(32, 19);
            this.lblEdit.TabIndex = 14;
            this.lblEdit.Text = "Edit";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAdd.Location = new System.Drawing.Point(18, 76);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(34, 19);
            this.lblAdd.TabIndex = 6;
            this.lblAdd.Text = "Add";
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::WeightBridgeMandya.Properties.Resources.Edit1;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Location = new System.Drawing.Point(16, 112);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 43);
            this.btnEdit.Style = MetroFramework.MetroColorStyle.White;
            this.btnEdit.TabIndex = 12;
            this.btnEdit.UseSelectable = true;
            this.btnEdit.UseStyleColors = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::WeightBridgeMandya.Properties.Resources.Delete1;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(15, 197);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 43);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddnew
            // 
            this.btnAddnew.BackgroundImage = global::WeightBridgeMandya.Properties.Resources.Add;
            this.btnAddnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddnew.Location = new System.Drawing.Point(15, 32);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(40, 43);
            this.btnAddnew.Style = MetroFramework.MetroColorStyle.White;
            this.btnAddnew.TabIndex = 11;
            this.btnAddnew.UseSelectable = true;
            this.btnAddnew.UseStyleColors = true;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // pnlDropdown
            // 
            this.pnlDropdown.Controls.Add(this.lblProductName);
            this.pnlDropdown.Controls.Add(this.lblVehicleId);
            this.pnlDropdown.Controls.Add(this.btnClose);
            this.pnlDropdown.Controls.Add(this.metroLabel11);
            this.pnlDropdown.Controls.Add(this.cmbProductName);
            this.pnlDropdown.Location = new System.Drawing.Point(67, 89);
            this.pnlDropdown.Name = "pnlDropdown";
            this.pnlDropdown.Size = new System.Drawing.Size(619, 75);
            this.pnlDropdown.TabIndex = 30;
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(505, 32);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(103, 19);
            this.lblProductName.TabIndex = 22;
            this.lblProductName.Text = "ProductNameID";
            this.lblProductName.Visible = false;
            // 
            // lblVehicleId
            // 
            this.lblVehicleId.AutoSize = true;
            this.lblVehicleId.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleId.ForeColor = System.Drawing.Color.Black;
            this.lblVehicleId.Location = new System.Drawing.Point(169, 36);
            this.lblVehicleId.Name = "lblVehicleId";
            this.lblVehicleId.Size = new System.Drawing.Size(0, 13);
            this.lblVehicleId.TabIndex = 26;
            this.lblVehicleId.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnClose.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnClose.Location = new System.Drawing.Point(418, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 30);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(41, 32);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(102, 19);
            this.metroLabel11.TabIndex = 4;
            this.metroLabel11.Text = "Product Name :";
            // 
            // cmbProductName
            // 
            this.cmbProductName.DropDownHeight = 250;
            this.cmbProductName.FormattingEnabled = true;
            this.cmbProductName.IntegralHeight = false;
            this.cmbProductName.ItemHeight = 23;
            this.cmbProductName.Location = new System.Drawing.Point(148, 27);
            this.cmbProductName.Name = "cmbProductName";
            this.cmbProductName.Size = new System.Drawing.Size(238, 29);
            this.cmbProductName.TabIndex = 0;
            this.cmbProductName.UseSelectable = true;
            this.cmbProductName.SelectionChangeCommitted += new System.EventHandler(this.cmbProductName_SelectionChangeCommitted);
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnClear);
            this.pnlButton.Controls.Add(this.btnSave);
            this.pnlButton.Location = new System.Drawing.Point(67, 308);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(619, 82);
            this.pnlButton.TabIndex = 29;
            // 
            // btnClear
            // 
            this.btnClear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnClear.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnClear.Location = new System.Drawing.Point(338, 30);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSave.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSave.Location = new System.Drawing.Point(235, 30);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.txtProductCode);
            this.pnlForm.Controls.Add(this.metroLabel1);
            this.pnlForm.Controls.Add(this.metroLabel5);
            this.pnlForm.Controls.Add(this.txtProductName);
            this.pnlForm.Location = new System.Drawing.Point(67, 167);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(619, 135);
            this.pnlForm.TabIndex = 28;
            // 
            // txtProductCode
            // 
            // 
            // 
            // 
            this.txtProductCode.CustomButton.Image = null;
            this.txtProductCode.CustomButton.Location = new System.Drawing.Point(197, 1);
            this.txtProductCode.CustomButton.Name = "";
            this.txtProductCode.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtProductCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductCode.CustomButton.TabIndex = 1;
            this.txtProductCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductCode.CustomButton.UseSelectable = true;
            this.txtProductCode.CustomButton.Visible = false;
            this.txtProductCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtProductCode.Lines = new string[0];
            this.txtProductCode.Location = new System.Drawing.Point(242, 76);
            this.txtProductCode.MaxLength = 5;
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.PasswordChar = '\0';
            this.txtProductCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductCode.SelectedText = "";
            this.txtProductCode.SelectionLength = 0;
            this.txtProductCode.SelectionStart = 0;
            this.txtProductCode.ShortcutsEnabled = true;
            this.txtProductCode.Size = new System.Drawing.Size(225, 29);
            this.txtProductCode.TabIndex = 1;
            this.txtProductCode.UseSelectable = true;
            this.txtProductCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductCode_KeyPress);
            this.txtProductCode.Leave += new System.EventHandler(this.txtProductCode_Leave);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(132, 80);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(98, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Product Code :";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(128, 38);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(102, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "Product Name :";
            // 
            // txtProductName
            // 
            // 
            // 
            // 
            this.txtProductName.CustomButton.Image = null;
            this.txtProductName.CustomButton.Location = new System.Drawing.Point(196, 1);
            this.txtProductName.CustomButton.Name = "";
            this.txtProductName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtProductName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtProductName.CustomButton.TabIndex = 1;
            this.txtProductName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtProductName.CustomButton.UseSelectable = true;
            this.txtProductName.CustomButton.Visible = false;
            this.txtProductName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtProductName.Lines = new string[0];
            this.txtProductName.Location = new System.Drawing.Point(243, 33);
            this.txtProductName.MaxLength = 50;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtProductName.SelectedText = "";
            this.txtProductName.SelectionLength = 0;
            this.txtProductName.SelectionStart = 0;
            this.txtProductName.ShortcutsEnabled = true;
            this.txtProductName.Size = new System.Drawing.Size(224, 29);
            this.txtProductName.TabIndex = 0;
            this.txtProductName.UseSelectable = true;
            this.txtProductName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtProductName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductName_KeyPress);
            // 
            // Product
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(846, 467);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pnlDropdown);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.pnlForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Product";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.pnlDropdown.ResumeLayout(false);
            this.pnlDropdown.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel groupBox4;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnAddnew;
        private System.Windows.Forms.Panel pnlDropdown;
        private System.Windows.Forms.Label lblVehicleId;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroComboBox cmbProductName;
        private System.Windows.Forms.Panel pnlButton;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.Panel pnlForm;
        private MetroFramework.Controls.MetroTextBox txtProductCode;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtProductName;
        private MetroFramework.Controls.MetroLabel lblDelete;
        private MetroFramework.Controls.MetroLabel lblEdit;
        private MetroFramework.Controls.MetroLabel lblAdd;
        private MetroFramework.Controls.MetroLabel lblProductName;
    }
}