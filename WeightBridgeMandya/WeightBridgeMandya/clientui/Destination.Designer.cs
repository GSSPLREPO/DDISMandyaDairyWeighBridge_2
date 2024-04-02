
namespace WeightBridgeMandya.clientui
{
    partial class Destination
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Destination));
            this.pnlDropdown = new System.Windows.Forms.Panel();
            this.lblDestinationId = new System.Windows.Forms.Label();
            this.lblVehicleId = new System.Windows.Forms.Label();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cmbSearchDestination = new MetroFramework.Controls.MetroComboBox();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnAddnew = new MetroFramework.Controls.MetroButton();
            this.groupBox4 = new System.Windows.Forms.Panel();
            this.lblDelete = new MetroFramework.Controls.MetroLabel();
            this.lblEdit = new MetroFramework.Controls.MetroLabel();
            this.lblAdd = new MetroFramework.Controls.MetroLabel();
            this.txtDestinationCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.TxtDestinationName = new MetroFramework.Controls.MetroTextBox();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.pnlDropdown.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDropdown
            // 
            this.pnlDropdown.Controls.Add(this.lblDestinationId);
            this.pnlDropdown.Controls.Add(this.lblVehicleId);
            this.pnlDropdown.Controls.Add(this.btnClose);
            this.pnlDropdown.Controls.Add(this.metroLabel11);
            this.pnlDropdown.Controls.Add(this.cmbSearchDestination);
            this.pnlDropdown.Location = new System.Drawing.Point(73, 75);
            this.pnlDropdown.Name = "pnlDropdown";
            this.pnlDropdown.Size = new System.Drawing.Size(545, 75);
            this.pnlDropdown.TabIndex = 27;
            // 
            // lblDestinationId
            // 
            this.lblDestinationId.AutoSize = true;
            this.lblDestinationId.BackColor = System.Drawing.Color.Transparent;
            this.lblDestinationId.ForeColor = System.Drawing.Color.Black;
            this.lblDestinationId.Location = new System.Drawing.Point(178, 37);
            this.lblDestinationId.Name = "lblDestinationId";
            this.lblDestinationId.Size = new System.Drawing.Size(0, 13);
            this.lblDestinationId.TabIndex = 27;
            this.lblDestinationId.Visible = false;
            // 
            // lblVehicleId
            // 
            this.lblVehicleId.AutoSize = true;
            this.lblVehicleId.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleId.ForeColor = System.Drawing.Color.Black;
            this.lblVehicleId.Location = new System.Drawing.Point(135, 37);
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
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(66, 33);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(76, 19);
            this.metroLabel11.TabIndex = 4;
            this.metroLabel11.Text = "Destination:";
            // 
            // cmbSearchDestination
            // 
            this.cmbSearchDestination.DropDownHeight = 250;
            this.cmbSearchDestination.FormattingEnabled = true;
            this.cmbSearchDestination.IntegralHeight = false;
            this.cmbSearchDestination.ItemHeight = 23;
            this.cmbSearchDestination.Location = new System.Drawing.Point(149, 28);
            this.cmbSearchDestination.Name = "cmbSearchDestination";
            this.cmbSearchDestination.Size = new System.Drawing.Size(245, 29);
            this.cmbSearchDestination.TabIndex = 0;
            this.cmbSearchDestination.UseSelectable = true;
            this.cmbSearchDestination.SelectionChangeCommitted += new System.EventHandler(this.cmbSearchDestination_SelectionChangeCommitted);
            // 
            // btnClear
            // 
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnClear.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnClear.Location = new System.Drawing.Point(292, 12);
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
            this.btnSave.Location = new System.Drawing.Point(189, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnClear);
            this.pnlButton.Controls.Add(this.btnSave);
            this.pnlButton.Location = new System.Drawing.Point(73, 308);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(545, 61);
            this.pnlButton.TabIndex = 30;
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::WeightBridgeMandya.Properties.Resources.Edit1;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Location = new System.Drawing.Point(15, 98);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(39, 43);
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
            this.btnDelete.Location = new System.Drawing.Point(15, 192);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(39, 43);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddnew
            // 
            this.btnAddnew.BackgroundImage = global::WeightBridgeMandya.Properties.Resources.Add;
            this.btnAddnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddnew.Location = new System.Drawing.Point(15, 14);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(39, 43);
            this.btnAddnew.Style = MetroFramework.MetroColorStyle.White;
            this.btnAddnew.TabIndex = 3;
            this.btnAddnew.UseSelectable = true;
            this.btnAddnew.UseStyleColors = true;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDelete);
            this.groupBox4.Controls.Add(this.lblEdit);
            this.groupBox4.Controls.Add(this.lblAdd);
            this.groupBox4.Controls.Add(this.btnEdit);
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.btnAddnew);
            this.groupBox4.Location = new System.Drawing.Point(634, 75);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(71, 281);
            this.groupBox4.TabIndex = 29;
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDelete.Location = new System.Drawing.Point(12, 237);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(48, 19);
            this.lblDelete.TabIndex = 25;
            this.lblDelete.Text = "Delete";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblEdit.Location = new System.Drawing.Point(18, 143);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(32, 19);
            this.lblEdit.TabIndex = 24;
            this.lblEdit.Text = "Edit";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAdd.Location = new System.Drawing.Point(18, 58);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(34, 19);
            this.lblAdd.TabIndex = 23;
            this.lblAdd.Text = "Add";
            // 
            // txtDestinationCode
            // 
            // 
            // 
            // 
            this.txtDestinationCode.CustomButton.Image = null;
            this.txtDestinationCode.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.txtDestinationCode.CustomButton.Name = "";
            this.txtDestinationCode.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtDestinationCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDestinationCode.CustomButton.TabIndex = 1;
            this.txtDestinationCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDestinationCode.CustomButton.UseSelectable = true;
            this.txtDestinationCode.CustomButton.Visible = false;
            this.txtDestinationCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDestinationCode.Lines = new string[0];
            this.txtDestinationCode.Location = new System.Drawing.Point(181, 75);
            this.txtDestinationCode.MaxLength = 5;
            this.txtDestinationCode.Name = "txtDestinationCode";
            this.txtDestinationCode.PasswordChar = '\0';
            this.txtDestinationCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDestinationCode.SelectedText = "";
            this.txtDestinationCode.SelectionLength = 0;
            this.txtDestinationCode.SelectionStart = 0;
            this.txtDestinationCode.ShortcutsEnabled = true;
            this.txtDestinationCode.Size = new System.Drawing.Size(213, 29);
            this.txtDestinationCode.TabIndex = 1;
            this.txtDestinationCode.UseSelectable = true;
            this.txtDestinationCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDestinationCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDestinationCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDestinationCode_KeyPress);
            this.txtDestinationCode.Leave += new System.EventHandler(this.txtDestinationCode_Leave);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(39, 80);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(116, 19);
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "Destination Code :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(39, 37);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(113, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Destination Name";
            // 
            // TxtDestinationName
            // 
            // 
            // 
            // 
            this.TxtDestinationName.CustomButton.Image = null;
            this.TxtDestinationName.CustomButton.Location = new System.Drawing.Point(185, 1);
            this.TxtDestinationName.CustomButton.Name = "";
            this.TxtDestinationName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.TxtDestinationName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.TxtDestinationName.CustomButton.TabIndex = 1;
            this.TxtDestinationName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.TxtDestinationName.CustomButton.UseSelectable = true;
            this.TxtDestinationName.CustomButton.Visible = false;
            this.TxtDestinationName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.TxtDestinationName.Lines = new string[0];
            this.TxtDestinationName.Location = new System.Drawing.Point(181, 31);
            this.TxtDestinationName.MaxLength = 50;
            this.TxtDestinationName.Name = "TxtDestinationName";
            this.TxtDestinationName.PasswordChar = '\0';
            this.TxtDestinationName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TxtDestinationName.SelectedText = "";
            this.TxtDestinationName.SelectionLength = 0;
            this.TxtDestinationName.SelectionStart = 0;
            this.TxtDestinationName.ShortcutsEnabled = true;
            this.TxtDestinationName.Size = new System.Drawing.Size(213, 29);
            this.TxtDestinationName.TabIndex = 0;
            this.TxtDestinationName.UseSelectable = true;
            this.TxtDestinationName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.TxtDestinationName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.TxtDestinationName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtDestinationName_KeyPress);
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.txtDestinationCode);
            this.pnlForm.Controls.Add(this.metroLabel2);
            this.pnlForm.Controls.Add(this.metroLabel1);
            this.pnlForm.Controls.Add(this.TxtDestinationName);
            this.pnlForm.Location = new System.Drawing.Point(73, 156);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(545, 142);
            this.pnlForm.TabIndex = 28;
            // 
            // Destination
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlDropdown);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pnlForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Destination";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Destination";
            this.Load += new System.EventHandler(this.Destination_Load);
            this.pnlDropdown.ResumeLayout(false);
            this.pnlDropdown.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDropdown;
        private System.Windows.Forms.Label lblDestinationId;
        private System.Windows.Forms.Label lblVehicleId;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroComboBox cmbSearchDestination;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.Panel pnlButton;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnAddnew;
        private System.Windows.Forms.Panel groupBox4;
        private MetroFramework.Controls.MetroTextBox txtDestinationCode;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox TxtDestinationName;
        private System.Windows.Forms.Panel pnlForm;
        private MetroFramework.Controls.MetroLabel lblDelete;
        private MetroFramework.Controls.MetroLabel lblEdit;
        private MetroFramework.Controls.MetroLabel lblAdd;
    }
}