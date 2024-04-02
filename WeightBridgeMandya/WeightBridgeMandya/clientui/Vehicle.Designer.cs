
namespace WeightBridgeMandya.clientui
{
    partial class Vehicle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vehicle));
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.btnCapture = new MetroFramework.Controls.MetroButton();
            this.txtRemarks = new MetroFramework.Controls.MetroTextBox();
            this.pnlButton = new System.Windows.Forms.Panel();
            this.btnClear = new MetroFramework.Controls.MetroButton();
            this.btnSave = new MetroFramework.Controls.MetroButton();
            this.pnlDropdown = new System.Windows.Forms.Panel();
            this.lblVehicleId = new System.Windows.Forms.Label();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.cmbSearchTanker = new MetroFramework.Controls.MetroComboBox();
            this.groupBox4 = new System.Windows.Forms.Panel();
            this.lblDelete = new MetroFramework.Controls.MetroLabel();
            this.lblEdit = new MetroFramework.Controls.MetroLabel();
            this.lblAdd = new MetroFramework.Controls.MetroLabel();
            this.btnEdit = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.btnAddnew = new MetroFramework.Controls.MetroButton();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.cmbRouteName = new MetroFramework.Controls.MetroComboBox();
            this.txtDriverName = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtTareWeight = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtCapacity = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtVehicleNumber = new MetroFramework.Controls.MetroTextBox();
            this.cmbVehicleType = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.cmbCompartments = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.spWeighBridge = new System.IO.Ports.SerialPort(this.components);
            this.pnlButton.SuspendLayout();
            this.pnlDropdown.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(41, 114);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(90, 19);
            this.metroLabel12.TabIndex = 14;
            this.metroLabel12.Text = "Route Name :";
            // 
            // btnCapture
            // 
            this.btnCapture.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCapture.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnCapture.Location = new System.Drawing.Point(692, 106);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(75, 30);
            this.btnCapture.TabIndex = 10;
            this.btnCapture.Text = "Capture";
            this.btnCapture.UseSelectable = true;
            this.btnCapture.Click += new System.EventHandler(this.btnCapture_Click);
            // 
            // txtRemarks
            // 
            // 
            // 
            // 
            this.txtRemarks.CustomButton.Image = null;
            this.txtRemarks.CustomButton.Location = new System.Drawing.Point(166, 1);
            this.txtRemarks.CustomButton.Name = "";
            this.txtRemarks.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtRemarks.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtRemarks.CustomButton.TabIndex = 1;
            this.txtRemarks.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtRemarks.CustomButton.UseSelectable = true;
            this.txtRemarks.CustomButton.Visible = false;
            this.txtRemarks.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtRemarks.Lines = new string[0];
            this.txtRemarks.Location = new System.Drawing.Point(492, 150);
            this.txtRemarks.MaxLength = 200;
            this.txtRemarks.Name = "txtRemarks";
            this.txtRemarks.PasswordChar = '\0';
            this.txtRemarks.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtRemarks.SelectedText = "";
            this.txtRemarks.SelectionLength = 0;
            this.txtRemarks.SelectionStart = 0;
            this.txtRemarks.ShortcutsEnabled = true;
            this.txtRemarks.Size = new System.Drawing.Size(194, 29);
            this.txtRemarks.TabIndex = 7;
            this.txtRemarks.UseSelectable = true;
            this.txtRemarks.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtRemarks.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pnlButton
            // 
            this.pnlButton.Controls.Add(this.btnClear);
            this.pnlButton.Controls.Add(this.btnSave);
            this.pnlButton.Location = new System.Drawing.Point(142, 357);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(640, 62);
            this.pnlButton.TabIndex = 25;
            // 
            // btnClear
            // 
            this.btnClear.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnClear.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnClear.Location = new System.Drawing.Point(338, 14);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear ";
            this.btnClear.UseSelectable = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSave.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSave.Location = new System.Drawing.Point(235, 14);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 30);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseSelectable = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlDropdown
            // 
            this.pnlDropdown.Controls.Add(this.lblVehicleId);
            this.pnlDropdown.Controls.Add(this.btnClose);
            this.pnlDropdown.Controls.Add(this.metroLabel11);
            this.pnlDropdown.Controls.Add(this.cmbSearchTanker);
            this.pnlDropdown.Location = new System.Drawing.Point(42, 76);
            this.pnlDropdown.Name = "pnlDropdown";
            this.pnlDropdown.Size = new System.Drawing.Size(797, 75);
            this.pnlDropdown.TabIndex = 26;
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
            this.btnClose.Location = new System.Drawing.Point(396, 21);
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
            this.metroLabel11.Location = new System.Drawing.Point(30, 28);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(106, 19);
            this.metroLabel11.TabIndex = 4;
            this.metroLabel11.Text = "Tanker Number :";
            // 
            // cmbSearchTanker
            // 
            this.cmbSearchTanker.DropDownHeight = 250;
            this.cmbSearchTanker.FormattingEnabled = true;
            this.cmbSearchTanker.IntegralHeight = false;
            this.cmbSearchTanker.ItemHeight = 23;
            this.cmbSearchTanker.Location = new System.Drawing.Point(161, 21);
            this.cmbSearchTanker.Name = "cmbSearchTanker";
            this.cmbSearchTanker.Size = new System.Drawing.Size(194, 29);
            this.cmbSearchTanker.TabIndex = 0;
            this.cmbSearchTanker.UseSelectable = true;
            this.cmbSearchTanker.SelectionChangeCommitted += new System.EventHandler(this.cmbSearchTanker_SelectionChangeCommitted);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblDelete);
            this.groupBox4.Controls.Add(this.lblEdit);
            this.groupBox4.Controls.Add(this.lblAdd);
            this.groupBox4.Controls.Add(this.btnEdit);
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Controls.Add(this.btnAddnew);
            this.groupBox4.Location = new System.Drawing.Point(845, 76);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(75, 301);
            this.groupBox4.TabIndex = 27;
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblDelete.Location = new System.Drawing.Point(12, 261);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(48, 19);
            this.lblDelete.TabIndex = 33;
            this.lblDelete.Text = "Delete";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblEdit.Location = new System.Drawing.Point(20, 163);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(32, 19);
            this.lblEdit.TabIndex = 32;
            this.lblEdit.Text = "Edit";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblAdd.Location = new System.Drawing.Point(19, 77);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(34, 19);
            this.lblAdd.TabIndex = 15;
            this.lblAdd.Text = "Add";
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::WeightBridgeMandya.Properties.Resources.Edit1;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.Location = new System.Drawing.Point(16, 118);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(40, 43);
            this.btnEdit.Style = MetroFramework.MetroColorStyle.White;
            this.btnEdit.TabIndex = 31;
            this.btnEdit.UseSelectable = true;
            this.btnEdit.UseStyleColors = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::WeightBridgeMandya.Properties.Resources.Delete1;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(15, 216);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(40, 43);
            this.btnDelete.TabIndex = 30;
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
            this.btnAddnew.TabIndex = 29;
            this.btnAddnew.UseSelectable = true;
            this.btnAddnew.UseStyleColors = true;
            this.btnAddnew.Click += new System.EventHandler(this.btnAddnew_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.cmbRouteName);
            this.pnlForm.Controls.Add(this.metroLabel12);
            this.pnlForm.Controls.Add(this.btnCapture);
            this.pnlForm.Controls.Add(this.txtRemarks);
            this.pnlForm.Controls.Add(this.txtDriverName);
            this.pnlForm.Controls.Add(this.metroLabel2);
            this.pnlForm.Controls.Add(this.txtTareWeight);
            this.pnlForm.Controls.Add(this.metroLabel3);
            this.pnlForm.Controls.Add(this.metroLabel4);
            this.pnlForm.Controls.Add(this.txtCapacity);
            this.pnlForm.Controls.Add(this.metroLabel6);
            this.pnlForm.Controls.Add(this.txtVehicleNumber);
            this.pnlForm.Controls.Add(this.cmbVehicleType);
            this.pnlForm.Controls.Add(this.metroLabel8);
            this.pnlForm.Controls.Add(this.cmbCompartments);
            this.pnlForm.Controls.Add(this.metroLabel9);
            this.pnlForm.Controls.Add(this.metroLabel10);
            this.pnlForm.Location = new System.Drawing.Point(42, 154);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(797, 197);
            this.pnlForm.TabIndex = 24;
            // 
            // cmbRouteName
            // 
            this.cmbRouteName.DropDownHeight = 250;
            this.cmbRouteName.FormattingEnabled = true;
            this.cmbRouteName.IntegralHeight = false;
            this.cmbRouteName.ItemHeight = 23;
            this.cmbRouteName.Location = new System.Drawing.Point(134, 108);
            this.cmbRouteName.Name = "cmbRouteName";
            this.cmbRouteName.Size = new System.Drawing.Size(241, 29);
            this.cmbRouteName.TabIndex = 2;
            this.cmbRouteName.UseSelectable = true;
            // 
            // txtDriverName
            // 
            // 
            // 
            // 
            this.txtDriverName.CustomButton.Image = null;
            this.txtDriverName.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.txtDriverName.CustomButton.Name = "";
            this.txtDriverName.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtDriverName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDriverName.CustomButton.TabIndex = 1;
            this.txtDriverName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDriverName.CustomButton.UseSelectable = true;
            this.txtDriverName.CustomButton.Visible = false;
            this.txtDriverName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtDriverName.Lines = new string[0];
            this.txtDriverName.Location = new System.Drawing.Point(134, 152);
            this.txtDriverName.MaxLength = 100;
            this.txtDriverName.Name = "txtDriverName";
            this.txtDriverName.PasswordChar = '\0';
            this.txtDriverName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDriverName.SelectedText = "";
            this.txtDriverName.SelectionLength = 0;
            this.txtDriverName.SelectionStart = 0;
            this.txtDriverName.ShortcutsEnabled = true;
            this.txtDriverName.Size = new System.Drawing.Size(241, 29);
            this.txtDriverName.TabIndex = 3;
            this.txtDriverName.UseSelectable = true;
            this.txtDriverName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDriverName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtDriverName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDriverName_KeyPress);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(29, 66);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(105, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Compartments :";
            // 
            // txtTareWeight
            // 
            // 
            // 
            // 
            this.txtTareWeight.CustomButton.Image = null;
            this.txtTareWeight.CustomButton.Location = new System.Drawing.Point(165, 1);
            this.txtTareWeight.CustomButton.Name = "";
            this.txtTareWeight.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtTareWeight.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTareWeight.CustomButton.TabIndex = 1;
            this.txtTareWeight.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTareWeight.CustomButton.UseSelectable = true;
            this.txtTareWeight.CustomButton.Visible = false;
            this.txtTareWeight.Enabled = false;
            this.txtTareWeight.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTareWeight.Lines = new string[0];
            this.txtTareWeight.Location = new System.Drawing.Point(493, 106);
            this.txtTareWeight.MaxLength = 7;
            this.txtTareWeight.Name = "txtTareWeight";
            this.txtTareWeight.PasswordChar = '\0';
            this.txtTareWeight.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTareWeight.SelectedText = "";
            this.txtTareWeight.SelectionLength = 0;
            this.txtTareWeight.SelectionStart = 0;
            this.txtTareWeight.ShortcutsEnabled = true;
            this.txtTareWeight.Size = new System.Drawing.Size(193, 29);
            this.txtTareWeight.TabIndex = 6;
            this.txtTareWeight.UseSelectable = true;
            this.txtTareWeight.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTareWeight.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTareWeight.Leave += new System.EventHandler(this.txtTareWeight_Leave);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(25, 23);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(106, 19);
            this.metroLabel3.TabIndex = 3;
            this.metroLabel3.Text = "Tanker Number :";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(407, 64);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(66, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "Capacity :";
            // 
            // txtCapacity
            // 
            // 
            // 
            // 
            this.txtCapacity.CustomButton.Image = null;
            this.txtCapacity.CustomButton.Location = new System.Drawing.Point(163, 1);
            this.txtCapacity.CustomButton.Name = "";
            this.txtCapacity.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtCapacity.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtCapacity.CustomButton.TabIndex = 1;
            this.txtCapacity.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtCapacity.CustomButton.UseSelectable = true;
            this.txtCapacity.CustomButton.Visible = false;
            this.txtCapacity.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtCapacity.Lines = new string[0];
            this.txtCapacity.Location = new System.Drawing.Point(495, 61);
            this.txtCapacity.MaxLength = 5;
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.PasswordChar = '\0';
            this.txtCapacity.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtCapacity.SelectedText = "";
            this.txtCapacity.SelectionLength = 0;
            this.txtCapacity.SelectionStart = 0;
            this.txtCapacity.ShortcutsEnabled = true;
            this.txtCapacity.Size = new System.Drawing.Size(191, 29);
            this.txtCapacity.TabIndex = 5;
            this.txtCapacity.UseSelectable = true;
            this.txtCapacity.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtCapacity.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtCapacity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCapacity_KeyPress);
            this.txtCapacity.Leave += new System.EventHandler(this.txtCapacity_Leave);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(426, 22);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(43, 19);
            this.metroLabel6.TabIndex = 6;
            this.metroLabel6.Text = "Type :";
            // 
            // txtVehicleNumber
            // 
            // 
            // 
            // 
            this.txtVehicleNumber.CustomButton.Image = null;
            this.txtVehicleNumber.CustomButton.Location = new System.Drawing.Point(213, 1);
            this.txtVehicleNumber.CustomButton.Name = "";
            this.txtVehicleNumber.CustomButton.Size = new System.Drawing.Size(27, 27);
            this.txtVehicleNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtVehicleNumber.CustomButton.TabIndex = 1;
            this.txtVehicleNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtVehicleNumber.CustomButton.UseSelectable = true;
            this.txtVehicleNumber.CustomButton.Visible = false;
            this.txtVehicleNumber.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtVehicleNumber.Lines = new string[0];
            this.txtVehicleNumber.Location = new System.Drawing.Point(134, 18);
            this.txtVehicleNumber.MaxLength = 10;
            this.txtVehicleNumber.Name = "txtVehicleNumber";
            this.txtVehicleNumber.PasswordChar = '\0';
            this.txtVehicleNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtVehicleNumber.SelectedText = "";
            this.txtVehicleNumber.SelectionLength = 0;
            this.txtVehicleNumber.SelectionStart = 0;
            this.txtVehicleNumber.ShortcutsEnabled = true;
            this.txtVehicleNumber.Size = new System.Drawing.Size(241, 29);
            this.txtVehicleNumber.TabIndex = 0;
            this.txtVehicleNumber.UseSelectable = true;
            this.txtVehicleNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtVehicleNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtVehicleNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVehicleNumber_KeyPress);
            // 
            // cmbVehicleType
            // 
            this.cmbVehicleType.DropDownHeight = 250;
            this.cmbVehicleType.FormattingEnabled = true;
            this.cmbVehicleType.IntegralHeight = false;
            this.cmbVehicleType.ItemHeight = 23;
            this.cmbVehicleType.Location = new System.Drawing.Point(493, 16);
            this.cmbVehicleType.Name = "cmbVehicleType";
            this.cmbVehicleType.Size = new System.Drawing.Size(193, 29);
            this.cmbVehicleType.TabIndex = 4;
            this.cmbVehicleType.UseSelectable = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(390, 106);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(85, 19);
            this.metroLabel8.TabIndex = 8;
            this.metroLabel8.Text = "Tare Weight :";
            // 
            // cmbCompartments
            // 
            this.cmbCompartments.DropDownHeight = 250;
            this.cmbCompartments.FormattingEnabled = true;
            this.cmbCompartments.IntegralHeight = false;
            this.cmbCompartments.ItemHeight = 23;
            this.cmbCompartments.Location = new System.Drawing.Point(134, 63);
            this.cmbCompartments.Name = "cmbCompartments";
            this.cmbCompartments.Size = new System.Drawing.Size(241, 29);
            this.cmbCompartments.TabIndex = 1;
            this.cmbCompartments.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(40, 152);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(91, 19);
            this.metroLabel9.TabIndex = 9;
            this.metroLabel9.Text = "Driver Name :";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(406, 150);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(66, 19);
            this.metroLabel10.TabIndex = 10;
            this.metroLabel10.Text = "Remarks :";
            // 
            // spWeighBridge
            // 
            this.spWeighBridge.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.spWeighBridge_DataReceived);
            // 
            // Vehicle
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(968, 518);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.pnlDropdown);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.pnlForm);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Vehicle";
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = " ";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Vehicle_FormClosed);
            this.Load += new System.EventHandler(this.Vehicle_Load);
            this.pnlButton.ResumeLayout(false);
            this.pnlDropdown.ResumeLayout(false);
            this.pnlDropdown.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.pnlForm.ResumeLayout(false);
            this.pnlForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroButton btnCapture;
        private MetroFramework.Controls.MetroTextBox txtRemarks;
        private System.Windows.Forms.Panel pnlButton;
        private MetroFramework.Controls.MetroButton btnClear;
        private MetroFramework.Controls.MetroButton btnSave;
        private System.Windows.Forms.Panel pnlDropdown;
        private System.Windows.Forms.Label lblVehicleId;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroComboBox cmbSearchTanker;
        private System.Windows.Forms.Panel groupBox4;
        private MetroFramework.Controls.MetroButton btnEdit;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroButton btnAddnew;
        private System.Windows.Forms.Panel pnlForm;
        private MetroFramework.Controls.MetroComboBox cmbRouteName;
        private MetroFramework.Controls.MetroTextBox txtDriverName;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtTareWeight;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtCapacity;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtVehicleNumber;
        private MetroFramework.Controls.MetroComboBox cmbVehicleType;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroComboBox cmbCompartments;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private System.IO.Ports.SerialPort spWeighBridge;
        private MetroFramework.Controls.MetroLabel lblDelete;
        private MetroFramework.Controls.MetroLabel lblEdit;
        private MetroFramework.Controls.MetroLabel lblAdd;
    }
}