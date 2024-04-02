
namespace WeightBridgeMandya.clientui
{
    partial class Source
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Source));
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.groupBox4 = new System.Windows.Forms.Panel();
            this.lblDelete = new MetroFramework.Controls.MetroLabel();
            this.lblEdit = new MetroFramework.Controls.MetroLabel();
            this.lblAdd = new MetroFramework.Controls.MetroLabel();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnAddnew = new MetroFramework.Controls.MetroButton();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.txtSourceCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TxtSourceName = new MetroFramework.Controls.MetroTextBox();
            this.pnlDropdown = new System.Windows.Forms.Panel();
            this.lblSourceId = new System.Windows.Forms.Label();
            this.lblVehicleId = new System.Windows.Forms.Label();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cmbSearchSource = new MetroFramework.Controls.MetroComboBox();
            this.pnlButton.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.pnlDropdown.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnClear);
            this.pnlButton.Controls.Add(this.btnSave);
            this.pnlButton.Location = new System.Drawing.Point(73, 307);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(545, 64);
            this.pnlButton.TabIndex = 30;
            // 
            // btnClear
            // 
            this.btnClear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnClear.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnClear.Location = new System.Drawing.Point(283, 16);
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
            this.btnSave.Location = new System.Drawing.Point(180, 16);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDelete);
            this.groupBox4.Controls.Add(this.lblEdit);
            this.groupBox4.Controls.Add(this.lblAdd);
            this.groupBox4.Controls.Add(this.btnEdit);
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.btnAddnew);
            this.groupBox4.Location = new System.Drawing.Point(634, 78);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(67, 275);
            this.groupBox4.TabIndex = 29;
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDelete.Location = new System.Drawing.Point(12, 244);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(48, 19);
            this.lblDelete.TabIndex = 25;
            this.lblDelete.Text = "Delete";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblEdit.Location = new System.Drawing.Point(19, 156);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(32, 19);
            this.lblEdit.TabIndex = 24;
            this.lblEdit.Text = "Edit";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAdd.Location = new System.Drawing.Point(20, 76);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(34, 19);
            this.lblAdd.TabIndex = 23;
            this.lblAdd.Text = "Add";
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::WeightBridgeMandya.Properties.Resources.Edit1;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Location = new System.Drawing.Point(15, 112);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(41, 43);
            this.btnEdit.Style = MetroFramework.MetroColorStyle.White;
            this.btnEdit.TabIndex = 4;
            this.btnEdit.UseSelectable = true;
            this.btnEdit.UseStyleColors = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::WeightBridgeMandya.Properties.Resources.Delete1;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(15, 200);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(41, 43);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddnew
            // 
            this.btnAddnew.BackgroundImage = global::WeightBridgeMandya.Properties.Resources.Add;
            this.btnAddnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddnew.Location = new System.Drawing.Point(15, 32);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(41, 43);
            this.btnAddnew.Style = MetroFramework.MetroColorStyle.White;
            this.btnAddnew.TabIndex = 3;
            this.btnAddnew.UseSelectable = true;
            this.btnAddnew.UseStyleColors = true;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.txtSourceCode);
            this.pnlForm.Controls.Add(this.metroLabel2);
            this.pnlForm.Controls.Add(this.metroLabel1);
            this.pnlForm.Controls.Add(this.TxtSourceName);
            this.pnlForm.Location = new System.Drawing.Point(73, 159);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(545, 142);
            this.pnlForm.TabIndex = 28;
            // 
            // txtSourceCode
            // 
            // 
            // 
            // 
            this.txtSourceCode.CustomButton.Image = null;
            this.txtSourceCode.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.txtSourceCode.CustomButton.Name = "";
            this.txtSourceCode.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtSourceCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSourceCode.CustomButton.TabIndex = 1;
            this.txtSourceCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSourceCode.CustomButton.UseSelectable = true;
            this.txtSourceCode.CustomButton.Visible = false;
            this.txtSourceCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSourceCode.Lines = new string[0];
            this.txtSourceCode.Location = new System.Drawing.Point(146, 75);
            this.txtSourceCode.MaxLength = 5;
            this.txtSourceCode.Name = "txtSourceCode";
            this.txtSourceCode.PasswordChar = '\0';
            this.txtSourceCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSourceCode.SelectedText = "";
            this.txtSourceCode.SelectionLength = 0;
            this.txtSourceCode.SelectionStart = 0;
            this.txtSourceCode.ShortcutsEnabled = true;
            this.txtSourceCode.Size = new System.Drawing.Size(256, 29);
            this.txtSourceCode.TabIndex = 1;
            this.txtSourceCode.UseSelectable = true;
            this.txtSourceCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSourceCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtSourceCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSourceCode_KeyPress);
            this.txtSourceCode.Leave += new System.EventHandler(this.txtSourceCode_Leave);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(39, 75);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(92, 19);
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "Source Code :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(39, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(89, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Source Name";
            // 
            // TxtSourceName
            // 
            // 
            // 
            // 
            this.TxtSourceName.CustomButton.Image = null;
            this.TxtSourceName.CustomButton.Location = new System.Drawing.Point(228, 1);
            this.TxtSourceName.CustomButton.Name = "";
            this.TxtSourceName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.TxtSourceName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtSourceName.CustomButton.TabIndex = 1;
            this.TxtSourceName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtSourceName.CustomButton.UseSelectable = true;
            this.TxtSourceName.CustomButton.Visible = false;
            this.TxtSourceName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtSourceName.Lines = new string[0];
            this.TxtSourceName.Location = new System.Drawing.Point(146, 31);
            this.TxtSourceName.MaxLength = 50;
            this.TxtSourceName.Name = "TxtSourceName";
            this.TxtSourceName.PasswordChar = '\0';
            this.TxtSourceName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtSourceName.SelectedText = "";
            this.TxtSourceName.SelectionLength = 0;
            this.TxtSourceName.SelectionStart = 0;
            this.TxtSourceName.ShortcutsEnabled = true;
            this.TxtSourceName.Size = new System.Drawing.Size(256, 29);
            this.TxtSourceName.TabIndex = 0;
            this.TxtSourceName.UseSelectable = true;
            this.TxtSourceName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtSourceName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtSourceName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSourceName_KeyPress);
            // 
            // pnlDropdown
            // 
            this.pnlDropdown.Controls.Add(this.lblSourceId);
            this.pnlDropdown.Controls.Add(this.lblVehicleId);
            this.pnlDropdown.Controls.Add(this.btnClose);
            this.pnlDropdown.Controls.Add(this.metroLabel11);
            this.pnlDropdown.Controls.Add(this.cmbSearchSource);
            this.pnlDropdown.Location = new System.Drawing.Point(73, 78);
            this.pnlDropdown.Name = "pnlDropdown";
            this.pnlDropdown.Size = new System.Drawing.Size(545, 75);
            this.pnlDropdown.TabIndex = 27;
            // 
            // lblSourceId
            // 
            this.lblSourceId.AutoSize = true;
            this.lblSourceId.BackColor = System.Drawing.Color.Transparent;
            this.lblSourceId.ForeColor = System.Drawing.Color.Black;
            this.lblSourceId.Location = new System.Drawing.Point(122, 35);
            this.lblSourceId.Name = "lblSourceId";
            this.lblSourceId.Size = new System.Drawing.Size(0, 13);
            this.lblSourceId.TabIndex = 27;
            this.lblSourceId.Visible = false;
            // 
            // lblVehicleId
            // 
            this.lblVehicleId.AutoSize = true;
            this.lblVehicleId.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleId.ForeColor = System.Drawing.Color.Black;
            this.lblVehicleId.Location = new System.Drawing.Point(79, 35);
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
            this.btnClose.Location = new System.Drawing.Point(442, 27);
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
            this.metroLabel11.Location = new System.Drawing.Point(74, 29);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(56, 19);
            this.metroLabel11.TabIndex = 4;
            this.metroLabel11.Text = "Source :";
            // 
            // cmbSearchSource
            // 
            this.cmbSearchSource.DropDownHeight = 250;
            this.cmbSearchSource.FormattingEnabled = true;
            this.cmbSearchSource.IntegralHeight = false;
            this.cmbSearchSource.ItemHeight = 23;
            this.cmbSearchSource.Location = new System.Drawing.Point(136, 26);
            this.cmbSearchSource.Name = "cmbSearchSource";
            this.cmbSearchSource.Size = new System.Drawing.Size(266, 29);
            this.cmbSearchSource.TabIndex = 0;
            this.cmbSearchSource.UseSelectable = true;
            this.cmbSearchSource.SelectionChangeCommitted += new System.EventHandler(this.cmbSearchSource_SelectionChangeCommitted);
            // 
            // Source
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 434);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlDropdown);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Source";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Source";
            this.Load += new System.EventHandler(this.Source_Load);
            this.pnlButton.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.pnlDropdown.ResumeLayout(false);
            this.pnlDropdown.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButton;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.Panel groupBox4;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnAddnew;
        private System.Windows.Forms.Panel pnlForm;
        private MetroFramework.Controls.MetroTextBox txtSourceCode;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TxtSourceName;
        private System.Windows.Forms.Panel pnlDropdown;
        private System.Windows.Forms.Label lblSourceId;
        private System.Windows.Forms.Label lblVehicleId;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroComboBox cmbSearchSource;
        private MetroFramework.Controls.MetroLabel lblDelete;
        private MetroFramework.Controls.MetroLabel lblEdit;
        private MetroFramework.Controls.MetroLabel lblAdd;
    }
}