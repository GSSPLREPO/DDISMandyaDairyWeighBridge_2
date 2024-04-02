
namespace WeightBridgeMandya.clientui
{
    partial class EditDeleteWeightBridge
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
        [System.Obsolete]
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditDeleteWeightBridge));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gvWeightBridge = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnGo = new MetroFramework.Controls.MetroButton();
            this.dtToDate = new MetroFramework.Controls.MetroDateTime();
            this.txtTankerNo = new MetroFramework.Controls.MetroTextBox();
            this.lblTankerNo = new MetroFramework.Controls.MetroLabel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.dtFromDate = new MetroFramework.Controls.MetroDateTime();
            this.Print = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.WeightBridgeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TankerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TankerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purpose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChallanNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrossWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TareWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvWeightBridge)).BeginInit();
            this.SuspendLayout();
            // 
            // gvWeightBridge
            // 
            this.gvWeightBridge.AllowUserToAddRows = false;
            this.gvWeightBridge.AllowUserToDeleteRows = false;
            this.gvWeightBridge.AllowUserToResizeRows = false;
            this.gvWeightBridge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.gvWeightBridge.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvWeightBridge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvWeightBridge.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvWeightBridge.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvWeightBridge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Print,
            this.Edit,
            this.Delete,
            this.WeightBridgeID,
            this.DateTime,
            this.TankerId,
            this.TankerNo,
            this.Purpose,
            this.ChallanNo,
            this.DirverName,
            this.GrossWeight,
            this.TareWeight,
            this.NetWeight});
            this.gvWeightBridge.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gvWeightBridge.EnableHeadersVisualStyles = false;
            this.gvWeightBridge.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.gvWeightBridge.Location = new System.Drawing.Point(20, 60);
            this.gvWeightBridge.Name = "gvWeightBridge";
            this.gvWeightBridge.ReadOnly = true;
            this.gvWeightBridge.RowHeadersVisible = false;
            this.gvWeightBridge.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gvWeightBridge.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(194)))), ((int)(((byte)(225)))));
            this.gvWeightBridge.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.gvWeightBridge.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gvWeightBridge.ShowCellErrors = false;
            this.gvWeightBridge.Size = new System.Drawing.Size(1346, 705);
            this.gvWeightBridge.TabIndex = 155;
            this.gvWeightBridge.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvWeightBridge_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.DataPropertyName = "Edit";
            this.dataGridViewImageColumn1.FillWeight = 40F;
            this.dataGridViewImageColumn1.HeaderText = "Edit";
            this.dataGridViewImageColumn1.Image = global::WeightBridgeMandya.Properties.Resources.Edit;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.FillWeight = 40F;
            this.dataGridViewImageColumn2.HeaderText = "Delete";
            this.dataGridViewImageColumn2.Image = global::WeightBridgeMandya.Properties.Resources.Delete;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Width = 63;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(795, 24);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(60, 19);
            this.metroLabel3.TabIndex = 161;
            this.metroLabel3.Text = "To Date :";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(568, 24);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(79, 19);
            this.metroLabel2.TabIndex = 160;
            this.metroLabel2.Text = "From Date :";
            // 
            // btnGo
            // 
            this.btnGo.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnGo.Location = new System.Drawing.Point(1003, 18);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(56, 29);
            this.btnGo.TabIndex = 2;
            this.btnGo.Text = "Go";
            this.btnGo.UseSelectable = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // dtToDate
            // 
            this.dtToDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtToDate.Location = new System.Drawing.Point(861, 18);
            this.dtToDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtToDate.Name = "dtToDate";
            this.dtToDate.Size = new System.Drawing.Size(130, 29);
            this.dtToDate.TabIndex = 1;
            // 
            // txtTankerNo
            // 
            // 
            // 
            // 
            this.txtTankerNo.CustomButton.Image = null;
            this.txtTankerNo.CustomButton.Location = new System.Drawing.Point(130, 1);
            this.txtTankerNo.CustomButton.Name = "";
            this.txtTankerNo.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.txtTankerNo.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTankerNo.CustomButton.TabIndex = 1;
            this.txtTankerNo.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTankerNo.CustomButton.UseSelectable = true;
            this.txtTankerNo.CustomButton.Visible = false;
            this.txtTankerNo.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTankerNo.Lines = new string[0];
            this.txtTankerNo.Location = new System.Drawing.Point(346, 21);
            this.txtTankerNo.MaxLength = 10;
            this.txtTankerNo.Name = "txtTankerNo";
            this.txtTankerNo.PasswordChar = '\0';
            this.txtTankerNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTankerNo.SelectedText = "";
            this.txtTankerNo.SelectionLength = 0;
            this.txtTankerNo.SelectionStart = 0;
            this.txtTankerNo.ShortcutsEnabled = true;
            this.txtTankerNo.Size = new System.Drawing.Size(156, 27);
            this.txtTankerNo.TabIndex = 3;
            this.txtTankerNo.UseSelectable = true;
            this.txtTankerNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTankerNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTankerNo.TextChanged += new System.EventHandler(this.txtTankerNo_TextChanged);
            this.txtTankerNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTankerNo_KeyPress);
            // 
            // lblTankerNo
            // 
            this.lblTankerNo.AutoSize = true;
            this.lblTankerNo.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lblTankerNo.Location = new System.Drawing.Point(263, 25);
            this.lblTankerNo.Name = "lblTankerNo";
            this.lblTankerNo.Size = new System.Drawing.Size(77, 19);
            this.lblTankerNo.TabIndex = 162;
            this.lblTankerNo.Text = "Tanker No :";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnClose.Location = new System.Drawing.Point(1153, 17);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 29);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // dtFromDate
            // 
            this.dtFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFromDate.Location = new System.Drawing.Point(653, 18);
            this.dtFromDate.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtFromDate.Name = "dtFromDate";
            this.dtFromDate.Size = new System.Drawing.Size(130, 29);
            this.dtFromDate.TabIndex = 0;
            // 
            // Print
            // 
            this.Print.DataPropertyName = "Print";
            this.Print.FillWeight = 40F;
            this.Print.Frozen = true;
            this.Print.HeaderText = "Print";
            this.Print.Image = global::WeightBridgeMandya.Properties.Resources.printer;
            this.Print.Name = "Print";
            this.Print.ReadOnly = true;
            this.Print.Width = 43;
            // 
            // Edit
            // 
            this.Edit.DataPropertyName = "Edit";
            this.Edit.FillWeight = 50F;
            this.Edit.Frozen = true;
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = global::WeightBridgeMandya.Properties.Resources.Edit;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 38;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Delete.DataPropertyName = "Delete";
            this.Delete.FillWeight = 40F;
            this.Delete.Frozen = true;
            this.Delete.HeaderText = "Delete";
            this.Delete.Image = global::WeightBridgeMandya.Properties.Resources.Delete;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 50;
            // 
            // WeightBridgeID
            // 
            this.WeightBridgeID.DataPropertyName = "Id";
            this.WeightBridgeID.HeaderText = "WeightBridgeID";
            this.WeightBridgeID.Name = "WeightBridgeID";
            this.WeightBridgeID.ReadOnly = true;
            this.WeightBridgeID.Visible = false;
            this.WeightBridgeID.Width = 134;
            // 
            // DateTime
            // 
            this.DateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DateTime.DataPropertyName = "DateTime";
            this.DateTime.FillWeight = 80F;
            this.DateTime.HeaderText = "Date Time";
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            // 
            // TankerId
            // 
            this.TankerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TankerId.DataPropertyName = "TankerID";
            this.TankerId.HeaderText = "Tanker ID ";
            this.TankerId.Name = "TankerId";
            this.TankerId.ReadOnly = true;
            // 
            // TankerNo
            // 
            this.TankerNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TankerNo.DataPropertyName = "TankerNo";
            this.TankerNo.HeaderText = "Tanker No";
            this.TankerNo.Name = "TankerNo";
            this.TankerNo.ReadOnly = true;
            // 
            // Purpose
            // 
            this.Purpose.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Purpose.DataPropertyName = "Purpose";
            this.Purpose.FillWeight = 70F;
            this.Purpose.HeaderText = "Purpose";
            this.Purpose.Name = "Purpose";
            this.Purpose.ReadOnly = true;
            // 
            // ChallanNo
            // 
            this.ChallanNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ChallanNo.DataPropertyName = "ChallanNo";
            this.ChallanNo.FillWeight = 80F;
            this.ChallanNo.HeaderText = "Challan No";
            this.ChallanNo.Name = "ChallanNo";
            this.ChallanNo.ReadOnly = true;
            // 
            // DirverName
            // 
            this.DirverName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DirverName.DataPropertyName = "DriverName";
            this.DirverName.FillWeight = 120F;
            this.DirverName.HeaderText = "Driver Name";
            this.DirverName.Name = "DirverName";
            this.DirverName.ReadOnly = true;
            // 
            // GrossWeight
            // 
            this.GrossWeight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.GrossWeight.DataPropertyName = "GrossWeight";
            this.GrossWeight.FillWeight = 80F;
            this.GrossWeight.HeaderText = "Gross Weight";
            this.GrossWeight.Name = "GrossWeight";
            this.GrossWeight.ReadOnly = true;
            // 
            // TareWeight
            // 
            this.TareWeight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TareWeight.DataPropertyName = "TareWeight";
            this.TareWeight.FillWeight = 80F;
            this.TareWeight.HeaderText = "Tare Weight";
            this.TareWeight.Name = "TareWeight";
            this.TareWeight.ReadOnly = true;
            // 
            // NetWeight
            // 
            this.NetWeight.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NetWeight.DataPropertyName = "NetWeight";
            this.NetWeight.FillWeight = 80F;
            this.NetWeight.HeaderText = "Net Weight";
            this.NetWeight.Name = "NetWeight";
            this.NetWeight.ReadOnly = true;
            // 
            // EditDeleteWeightBridge
            // 
            this.AcceptButton = this.btnGo;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1386, 785);
            this.Controls.Add(this.dtFromDate);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtTankerNo);
            this.Controls.Add(this.lblTankerNo);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.dtToDate);
            this.Controls.Add(this.gvWeightBridge);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EditDeleteWeightBridge";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Tanker Record";
            this.Load += new System.EventHandler(this.EditDeleteWeightBridge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvWeightBridge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView gvWeightBridge;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton btnGo;
        private MetroFramework.Controls.MetroDateTime dtToDate;
        private MetroFramework.Controls.MetroTextBox txtTankerNo;
        private MetroFramework.Controls.MetroLabel lblTankerNo;
        private MetroFramework.Controls.MetroButton btnClose;
        private MetroFramework.Controls.MetroDateTime dtFromDate;
        private System.Windows.Forms.DataGridViewImageColumn Print;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewImageColumn Delete;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightBridgeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TankerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TankerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purpose;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChallanNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrossWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn TareWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetWeight;
    }
}