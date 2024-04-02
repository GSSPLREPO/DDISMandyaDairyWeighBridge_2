
namespace WeightBridgeMandya.clientui
{
    partial class ListWeighBridge
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListWeighBridge));
            this.btnAdd = new MetroFramework.Controls.MetroButton();
            this.txtTankerNo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.gvWeightBridge = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnEditDelete = new MetroFramework.Controls.MetroButton();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            this.RePrint = new System.Windows.Forms.DataGridViewImageColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.WeightBridgeID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TankerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TankerNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChallanNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DirverName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RouteName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GrossWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TareWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvWeightBridge)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(756, 16);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(107, 30);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseSelectable = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.txtTankerNo.Location = new System.Drawing.Point(344, 19);
            this.txtTankerNo.MaxLength = 10;
            this.txtTankerNo.Name = "txtTankerNo";
            this.txtTankerNo.PasswordChar = '\0';
            this.txtTankerNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTankerNo.SelectedText = "";
            this.txtTankerNo.SelectionLength = 0;
            this.txtTankerNo.SelectionStart = 0;
            this.txtTankerNo.ShortcutsEnabled = true;
            this.txtTankerNo.Size = new System.Drawing.Size(156, 27);
            this.txtTankerNo.TabIndex = 0;
            this.txtTankerNo.UseSelectable = true;
            this.txtTankerNo.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTankerNo.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtTankerNo.TextChanged += new System.EventHandler(this.txtTankerNo_TextChanged);
            this.txtTankerNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTankerNo_KeyPress);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(261, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(77, 19);
            this.metroLabel1.TabIndex = 147;
            this.metroLabel1.Text = "Tanker No :";
            // 
            // gvWeightBridge
            // 
            this.gvWeightBridge.AllowUserToAddRows = false;
            this.gvWeightBridge.AllowUserToDeleteRows = false;
            this.gvWeightBridge.AllowUserToResizeRows = false;
            this.gvWeightBridge.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.gvWeightBridge.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvWeightBridge.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(145)))), ((int)(((byte)(200)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvWeightBridge.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gvWeightBridge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvWeightBridge.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RePrint,
            this.Edit,
            this.WeightBridgeID,
            this.DateTime,
            this.TankerId,
            this.TankerNo,
            this.ChallanNo,
            this.DirverName,
            this.RouteName,
            this.GrossWeight,
            this.TareWeight});
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
            this.gvWeightBridge.Size = new System.Drawing.Size(1229, 488);
            this.gvWeightBridge.TabIndex = 150;
            this.gvWeightBridge.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvWeightBridge_CellContentClick);
            // 
            // btnEditDelete
            // 
            this.btnEditDelete.Location = new System.Drawing.Point(869, 16);
            this.btnEditDelete.Name = "btnEditDelete";
            this.btnEditDelete.Size = new System.Drawing.Size(107, 30);
            this.btnEditDelete.TabIndex = 2;
            this.btnEditDelete.Text = "Edit / Delete";
            this.btnEditDelete.UseSelectable = true;
            this.btnEditDelete.Click += new System.EventHandler(this.btnEditDelete_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewImageColumn1.DataPropertyName = "Edit";
            this.dataGridViewImageColumn1.HeaderText = "Edit";
            this.dataGridViewImageColumn1.Image = global::WeightBridgeMandya.Properties.Resources.Edit;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(1024, 16);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // RePrint
            // 
            this.RePrint.FillWeight = 50F;
            this.RePrint.HeaderText = "RePrint";
            this.RePrint.Image = global::WeightBridgeMandya.Properties.Resources.printer;
            this.RePrint.Name = "RePrint";
            this.RePrint.ReadOnly = true;
            this.RePrint.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.RePrint.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.RePrint.Width = 50;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Edit.DataPropertyName = "Edit";
            this.Edit.FillWeight = 60F;
            this.Edit.HeaderText = "Edit";
            this.Edit.Image = global::WeightBridgeMandya.Properties.Resources.Edit;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // WeightBridgeID
            // 
            this.WeightBridgeID.DataPropertyName = "Id";
            this.WeightBridgeID.HeaderText = "WeightBridgeID";
            this.WeightBridgeID.Name = "WeightBridgeID";
            this.WeightBridgeID.ReadOnly = true;
            this.WeightBridgeID.Visible = false;
            // 
            // DateTime
            // 
            this.DateTime.DataPropertyName = "DateTime";
            this.DateTime.HeaderText = "Date Time";
            this.DateTime.Name = "DateTime";
            this.DateTime.ReadOnly = true;
            this.DateTime.Width = 150;
            // 
            // TankerId
            // 
            this.TankerId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TankerId.DataPropertyName = "TankerId";
            this.TankerId.HeaderText = "Tanker ID ";
            this.TankerId.Name = "TankerId";
            this.TankerId.ReadOnly = true;
            this.TankerId.Width = 120;
            // 
            // TankerNo
            // 
            this.TankerNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TankerNo.DataPropertyName = "TankerNo";
            this.TankerNo.HeaderText = "Tanker No";
            this.TankerNo.Name = "TankerNo";
            this.TankerNo.ReadOnly = true;
            // 
            // ChallanNo
            // 
            this.ChallanNo.DataPropertyName = "ChallanNo";
            this.ChallanNo.HeaderText = "Challan No";
            this.ChallanNo.Name = "ChallanNo";
            this.ChallanNo.ReadOnly = true;
            this.ChallanNo.Width = 120;
            // 
            // DirverName
            // 
            this.DirverName.DataPropertyName = "DriverName";
            this.DirverName.HeaderText = "Driver Name";
            this.DirverName.Name = "DirverName";
            this.DirverName.ReadOnly = true;
            this.DirverName.Width = 150;
            // 
            // RouteName
            // 
            this.RouteName.DataPropertyName = "RouteName";
            this.RouteName.HeaderText = "Route";
            this.RouteName.Name = "RouteName";
            this.RouteName.ReadOnly = true;
            this.RouteName.Width = 200;
            // 
            // GrossWeight
            // 
            this.GrossWeight.DataPropertyName = "GrossWeight";
            this.GrossWeight.HeaderText = "Gross Weight";
            this.GrossWeight.Name = "GrossWeight";
            this.GrossWeight.ReadOnly = true;
            // 
            // TareWeight
            // 
            this.TareWeight.DataPropertyName = "TareWeight";
            this.TareWeight.HeaderText = "Tare Weight";
            this.TareWeight.Name = "TareWeight";
            this.TareWeight.ReadOnly = true;
            // 
            // ListWeighBridge
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(1269, 568);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnEditDelete);
            this.Controls.Add(this.gvWeightBridge);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtTankerNo);
            this.Controls.Add(this.metroLabel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ListWeighBridge";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Active Tanker";
            this.Load += new System.EventHandler(this.ListWeighBridge_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvWeightBridge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton btnAdd;
        private MetroFramework.Controls.MetroTextBox txtTankerNo;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridView gvWeightBridge;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private MetroFramework.Controls.MetroButton btnEditDelete;
        private MetroFramework.Controls.MetroButton btnClose;
        private System.Windows.Forms.DataGridViewImageColumn RePrint;
        private System.Windows.Forms.DataGridViewImageColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn WeightBridgeID;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn TankerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn TankerNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChallanNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DirverName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RouteName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GrossWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn TareWeight;
    }
}