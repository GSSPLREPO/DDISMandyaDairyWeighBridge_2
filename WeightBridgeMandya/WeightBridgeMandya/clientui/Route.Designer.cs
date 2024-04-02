
namespace WeightBridgeMandya.clientui
{
    partial class Route
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Route));
            this.pnlDropdown = new System.Windows.Forms.Panel();
            this.lblDestinationId = new System.Windows.Forms.Label();
            this.lblVehicleId = new System.Windows.Forms.Label();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cmbSearchRoute = new MetroFramework.Controls.MetroComboBox();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnAddnew = new MetroFramework.Controls.MetroButton();
            this.groupBox4 = new System.Windows.Forms.Panel();
            this.lblDelete = new MetroFramework.Controls.MetroLabel();
            this.lblEdit = new MetroFramework.Controls.MetroLabel();
            this.lblAdd = new MetroFramework.Controls.MetroLabel();
            this.txtRouteCode = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txtRouteName = new MetroFramework.Controls.MetroTextBox();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.lblRouteID = new MetroFramework.Controls.MetroLabel();
            this.pnlDropdown.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pnlButton.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDropdown
            // 
            this.pnlDropdown.Controls.Add(this.lblDestinationId);
            this.pnlDropdown.Controls.Add(this.lblVehicleId);
            this.pnlDropdown.Controls.Add(this.btnClose);
            this.pnlDropdown.Controls.Add(this.metroLabel11);
            this.pnlDropdown.Controls.Add(this.cmbSearchRoute);
            this.pnlDropdown.Location = new System.Drawing.Point(56, 72);
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
            this.btnClose.Location = new System.Drawing.Point(396, 24);
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
            this.metroLabel11.Location = new System.Drawing.Point(29, 30);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(90, 19);
            this.metroLabel11.TabIndex = 4;
            this.metroLabel11.Text = "Route Name :";
            // 
            // cmbSearchRoute
            // 
            this.cmbSearchRoute.DropDownHeight = 250;
            this.cmbSearchRoute.FormattingEnabled = true;
            this.cmbSearchRoute.IntegralHeight = false;
            this.cmbSearchRoute.ItemHeight = 23;
            this.cmbSearchRoute.Location = new System.Drawing.Point(138, 25);
            this.cmbSearchRoute.Name = "cmbSearchRoute";
            this.cmbSearchRoute.Size = new System.Drawing.Size(241, 29);
            this.cmbSearchRoute.TabIndex = 0;
            this.cmbSearchRoute.UseSelectable = true;
            this.cmbSearchRoute.SelectionChangeCommitted += new System.EventHandler(this.cmbSearchRoute_SelectionChangeCommitted);
            // 
            // btnSave
            // 
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSave.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSave.Location = new System.Drawing.Point(183, 27);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::WeightBridgeMandya.Properties.Resources.Edit1;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Location = new System.Drawing.Point(18, 110);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(34, 43);
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
            this.btnDelete.Location = new System.Drawing.Point(15, 201);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(37, 43);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnClear.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnClear.Location = new System.Drawing.Point(286, 27);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnAddnew
            // 
            this.btnAddnew.BackgroundImage = global::WeightBridgeMandya.Properties.Resources.Add;
            this.btnAddnew.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddnew.Location = new System.Drawing.Point(15, 23);
            this.btnAddnew.Name = "btnAddnew";
            this.btnAddnew.Size = new System.Drawing.Size(37, 43);
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
            this.groupBox4.Location = new System.Drawing.Point(617, 72);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(68, 273);
            this.groupBox4.TabIndex = 29;
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDelete.Location = new System.Drawing.Point(11, 244);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(48, 19);
            this.lblDelete.TabIndex = 25;
            this.lblDelete.Text = "Delete";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblEdit.Location = new System.Drawing.Point(19, 155);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(32, 19);
            this.lblEdit.TabIndex = 24;
            this.lblEdit.Text = "Edit";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAdd.Location = new System.Drawing.Point(18, 67);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(34, 19);
            this.lblAdd.TabIndex = 23;
            this.lblAdd.Text = "Add";
            // 
            // txtRouteCode
            // 
            // 
            // 
            // 
            this.txtRouteCode.CustomButton.Image = null;
            this.txtRouteCode.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.txtRouteCode.CustomButton.Name = "";
            this.txtRouteCode.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtRouteCode.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRouteCode.CustomButton.TabIndex = 1;
            this.txtRouteCode.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRouteCode.CustomButton.UseSelectable = true;
            this.txtRouteCode.CustomButton.Visible = false;
            this.txtRouteCode.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRouteCode.Lines = new string[0];
            this.txtRouteCode.Location = new System.Drawing.Point(138, 56);
            this.txtRouteCode.MaxLength = 5;
            this.txtRouteCode.Name = "txtRouteCode";
            this.txtRouteCode.PasswordChar = '\0';
            this.txtRouteCode.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRouteCode.SelectedText = "";
            this.txtRouteCode.SelectionLength = 0;
            this.txtRouteCode.SelectionStart = 0;
            this.txtRouteCode.ShortcutsEnabled = true;
            this.txtRouteCode.Size = new System.Drawing.Size(241, 29);
            this.txtRouteCode.TabIndex = 1;
            this.txtRouteCode.UseSelectable = true;
            this.txtRouteCode.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRouteCode.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRouteCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRouteCode_KeyPress);
            this.txtRouteCode.Leave += new System.EventHandler(this.txtRouteCode_Leave);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(33, 61);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(86, 19);
            this.metroLabel2.TabIndex = 22;
            this.metroLabel2.Text = "Route Code :";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(29, 17);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Route Name :";
            // 
            // txtRouteName
            // 
            // 
            // 
            // 
            this.txtRouteName.CustomButton.Image = null;
            this.txtRouteName.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.txtRouteName.CustomButton.Name = "";
            this.txtRouteName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtRouteName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRouteName.CustomButton.TabIndex = 1;
            this.txtRouteName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRouteName.CustomButton.UseSelectable = true;
            this.txtRouteName.CustomButton.Visible = false;
            this.txtRouteName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRouteName.Lines = new string[0];
            this.txtRouteName.Location = new System.Drawing.Point(138, 12);
            this.txtRouteName.MaxLength = 50;
            this.txtRouteName.Name = "txtRouteName";
            this.txtRouteName.PasswordChar = '\0';
            this.txtRouteName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRouteName.SelectedText = "";
            this.txtRouteName.SelectionLength = 0;
            this.txtRouteName.SelectionStart = 0;
            this.txtRouteName.ShortcutsEnabled = true;
            this.txtRouteName.Size = new System.Drawing.Size(241, 29);
            this.txtRouteName.TabIndex = 0;
            this.txtRouteName.UseSelectable = true;
            this.txtRouteName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRouteName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtRouteName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRouteName_KeyPress);
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnClear);
            this.pnlButton.Controls.Add(this.btnSave);
            this.pnlButton.Location = new System.Drawing.Point(56, 277);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(545, 82);
            this.pnlButton.TabIndex = 30;
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.txtRouteCode);
            this.pnlForm.Controls.Add(this.metroLabel2);
            this.pnlForm.Controls.Add(this.metroLabel1);
            this.pnlForm.Controls.Add(this.txtRouteName);
            this.pnlForm.Location = new System.Drawing.Point(56, 153);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(436, 105);
            this.pnlForm.TabIndex = 28;
            // 
            // lblRouteID
            // 
            this.lblRouteID.AutoSize = true;
            this.lblRouteID.Location = new System.Drawing.Point(585, 379);
            this.lblRouteID.Name = "lblRouteID";
            this.lblRouteID.Size = new System.Drawing.Size(83, 19);
            this.lblRouteID.TabIndex = 31;
            this.lblRouteID.Text = "metroLabel3";
            this.lblRouteID.Visible = false;
            // 
            // Route
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(746, 421);
            this.Controls.Add(this.lblRouteID);
            this.Controls.Add(this.pnlDropdown);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.pnlForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Route";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Route";
            this.Load += new System.EventHandler(this.Route_Load);
            this.pnlDropdown.ResumeLayout(false);
            this.pnlDropdown.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.pnlButton.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDropdown;
        private System.Windows.Forms.Label lblDestinationId;
        private System.Windows.Forms.Label lblVehicleId;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroComboBox cmbSearchRoute;
        private MetroFramework.Controls.MetroButton btnSave;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnAddnew;
        private System.Windows.Forms.Panel groupBox4;
        private MetroFramework.Controls.MetroTextBox txtRouteCode;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txtRouteName;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Panel pnlForm;
        private MetroFramework.Controls.MetroLabel lblRouteID;
        private MetroFramework.Controls.MetroLabel lblDelete;
        private MetroFramework.Controls.MetroLabel lblEdit;
        private MetroFramework.Controls.MetroLabel lblAdd;
    }
}