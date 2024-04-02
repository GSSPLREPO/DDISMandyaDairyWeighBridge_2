
namespace WeightBridgeMandya.clientui
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.mtlSource = new MetroFramework.Controls.MetroTile();
            this.mtlDestination = new MetroFramework.Controls.MetroTile();
            this.mtlPortConfig = new MetroFramework.Controls.MetroTile();
            this.mtTileWeighBridge = new MetroFramework.Controls.MetroTile();
            this.mtpWeighBridge = new MetroFramework.Controls.MetroTabPage();
            this.mtlTileProduct = new MetroFramework.Controls.MetroTile();
            this.mtrTileVehicle = new MetroFramework.Controls.MetroTile();
            this.mtpMasters = new MetroFramework.Controls.MetroTabPage();
            this.mtlCustomer = new MetroFramework.Controls.MetroTile();
            this.mtlSupplier = new MetroFramework.Controls.MetroTile();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroTile3 = new MetroFramework.Controls.MetroTile();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.mtpWeighBridge.SuspendLayout();
            this.mtpMasters.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mtlSource
            // 
            this.mtlSource.ActiveControl = null;
            this.mtlSource.Location = new System.Drawing.Point(413, 251);
            this.mtlSource.Name = "mtlSource";
            this.mtlSource.Size = new System.Drawing.Size(176, 95);
            this.mtlSource.Style = MetroFramework.MetroColorStyle.Orange;
            this.mtlSource.TabIndex = 18;
            this.mtlSource.Text = "Source";
            this.mtlSource.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtlSource.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtlSource.UseSelectable = true;
            this.mtlSource.Visible = false;
            this.mtlSource.Click += new System.EventHandler(this.mtlSource_Click);
            // 
            // mtlDestination
            // 
            this.mtlDestination.ActiveControl = null;
            this.mtlDestination.Location = new System.Drawing.Point(218, 251);
            this.mtlDestination.Name = "mtlDestination";
            this.mtlDestination.Size = new System.Drawing.Size(176, 95);
            this.mtlDestination.Style = MetroFramework.MetroColorStyle.Green;
            this.mtlDestination.TabIndex = 17;
            this.mtlDestination.Text = "Destination";
            this.mtlDestination.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtlDestination.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtlDestination.UseSelectable = true;
            this.mtlDestination.Visible = false;
            this.mtlDestination.Click += new System.EventHandler(this.mtlDestination_Click);
            // 
            // mtlPortConfig
            // 
            this.mtlPortConfig.ActiveControl = null;
            this.mtlPortConfig.Location = new System.Drawing.Point(413, 135);
            this.mtlPortConfig.Name = "mtlPortConfig";
            this.mtlPortConfig.Size = new System.Drawing.Size(176, 95);
            this.mtlPortConfig.Style = MetroFramework.MetroColorStyle.Brown;
            this.mtlPortConfig.TabIndex = 16;
            this.mtlPortConfig.Text = "Port Configuration";
            this.mtlPortConfig.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtlPortConfig.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtlPortConfig.UseSelectable = true;
            this.mtlPortConfig.Click += new System.EventHandler(this.mtlPortConfig_Click);
            // 
            // mtTileWeighBridge
            // 
            this.mtTileWeighBridge.ActiveControl = null;
            this.mtTileWeighBridge.Location = new System.Drawing.Point(14, 12);
            this.mtTileWeighBridge.Name = "mtTileWeighBridge";
            this.mtTileWeighBridge.Size = new System.Drawing.Size(184, 99);
            this.mtTileWeighBridge.TabIndex = 2;
            this.mtTileWeighBridge.Text = "Weight Bridge";
            this.mtTileWeighBridge.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtTileWeighBridge.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtTileWeighBridge.UseSelectable = true;
            this.mtTileWeighBridge.Click += new System.EventHandler(this.mtTileWeighBridge_Click);
            // 
            // mtpWeighBridge
            // 
            this.mtpWeighBridge.Controls.Add(this.mtTileWeighBridge);
            this.mtpWeighBridge.HorizontalScrollbarBarColor = true;
            this.mtpWeighBridge.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpWeighBridge.HorizontalScrollbarSize = 10;
            this.mtpWeighBridge.Location = new System.Drawing.Point(4, 38);
            this.mtpWeighBridge.Name = "mtpWeighBridge";
            this.mtpWeighBridge.Size = new System.Drawing.Size(1222, 424);
            this.mtpWeighBridge.TabIndex = 1;
            this.mtpWeighBridge.Text = "    Weight Bridge    ";
            this.mtpWeighBridge.VerticalScrollbarBarColor = true;
            this.mtpWeighBridge.VerticalScrollbarHighlightOnWheel = false;
            this.mtpWeighBridge.VerticalScrollbarSize = 10;
            // 
            // mtlTileProduct
            // 
            this.mtlTileProduct.ActiveControl = null;
            this.mtlTileProduct.Location = new System.Drawing.Point(216, 20);
            this.mtlTileProduct.Name = "mtlTileProduct";
            this.mtlTileProduct.Size = new System.Drawing.Size(176, 95);
            this.mtlTileProduct.Style = MetroFramework.MetroColorStyle.Silver;
            this.mtlTileProduct.TabIndex = 11;
            this.mtlTileProduct.Text = "Product";
            this.mtlTileProduct.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtlTileProduct.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtlTileProduct.UseSelectable = true;
            this.mtlTileProduct.Click += new System.EventHandler(this.mtlTileProduct_Click);
            // 
            // mtrTileVehicle
            // 
            this.mtrTileVehicle.ActiveControl = null;
            this.mtrTileVehicle.Location = new System.Drawing.Point(13, 20);
            this.mtrTileVehicle.Name = "mtrTileVehicle";
            this.mtrTileVehicle.Size = new System.Drawing.Size(176, 95);
            this.mtrTileVehicle.TabIndex = 8;
            this.mtrTileVehicle.Text = "Tanker";
            this.mtrTileVehicle.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtrTileVehicle.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtrTileVehicle.UseSelectable = true;
            this.mtrTileVehicle.Click += new System.EventHandler(this.mtrTileVehicle_Click);
            // 
            // mtpMasters
            // 
            this.mtpMasters.Controls.Add(this.mtlCustomer);
            this.mtpMasters.Controls.Add(this.mtlSupplier);
            this.mtpMasters.Controls.Add(this.metroTile1);
            this.mtpMasters.Controls.Add(this.mtlSource);
            this.mtpMasters.Controls.Add(this.mtlDestination);
            this.mtpMasters.Controls.Add(this.mtlPortConfig);
            this.mtpMasters.Controls.Add(this.metroTile3);
            this.mtpMasters.Controls.Add(this.mtlTileProduct);
            this.mtpMasters.Controls.Add(this.mtrTileVehicle);
            this.mtpMasters.HorizontalScrollbarBarColor = true;
            this.mtpMasters.HorizontalScrollbarHighlightOnWheel = false;
            this.mtpMasters.HorizontalScrollbarSize = 10;
            this.mtpMasters.Location = new System.Drawing.Point(4, 38);
            this.mtpMasters.Name = "mtpMasters";
            this.mtpMasters.Size = new System.Drawing.Size(1222, 424);
            this.mtpMasters.TabIndex = 0;
            this.mtpMasters.Text = "    Masters    ";
            this.mtpMasters.VerticalScrollbarBarColor = true;
            this.mtpMasters.VerticalScrollbarHighlightOnWheel = false;
            this.mtpMasters.VerticalScrollbarSize = 10;
            // 
            // mtlCustomer
            // 
            this.mtlCustomer.ActiveControl = null;
            this.mtlCustomer.Location = new System.Drawing.Point(218, 135);
            this.mtlCustomer.Name = "mtlCustomer";
            this.mtlCustomer.Size = new System.Drawing.Size(176, 95);
            this.mtlCustomer.Style = MetroFramework.MetroColorStyle.Teal;
            this.mtlCustomer.TabIndex = 21;
            this.mtlCustomer.Text = "Customer";
            this.mtlCustomer.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtlCustomer.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtlCustomer.UseSelectable = true;
            this.mtlCustomer.Click += new System.EventHandler(this.mtlCustomer_Click);
            // 
            // mtlSupplier
            // 
            this.mtlSupplier.ActiveControl = null;
            this.mtlSupplier.Location = new System.Drawing.Point(13, 135);
            this.mtlSupplier.Name = "mtlSupplier";
            this.mtlSupplier.Size = new System.Drawing.Size(176, 95);
            this.mtlSupplier.Style = MetroFramework.MetroColorStyle.Yellow;
            this.mtlSupplier.TabIndex = 20;
            this.mtlSupplier.Text = "Supplier";
            this.mtlSupplier.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtlSupplier.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.mtlSupplier.UseSelectable = true;
            this.mtlSupplier.Click += new System.EventHandler(this.mtlSupplier_Click);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(413, 20);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(176, 95);
            this.metroTile1.TabIndex = 19;
            this.metroTile1.Text = "Route";
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // metroTile3
            // 
            this.metroTile3.ActiveControl = null;
            this.metroTile3.Location = new System.Drawing.Point(13, 251);
            this.metroTile3.Name = "metroTile3";
            this.metroTile3.Size = new System.Drawing.Size(176, 95);
            this.metroTile3.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroTile3.TabIndex = 15;
            this.metroTile3.Text = "Composite Parameter";
            this.metroTile3.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile3.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.metroTile3.UseSelectable = true;
            this.metroTile3.Visible = false;
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.mtpMasters);
            this.metroTabControl1.Controls.Add(this.mtpWeighBridge);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(1230, 466);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Orange;
            this.metroTabControl1.TabIndex = 1;
            this.metroTabControl1.UseSelectable = true;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnLogout.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnLogout.ForeColor = System.Drawing.Color.Black;
            this.btnLogout.Location = new System.Drawing.Point(266, 19);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(87, 35);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1270, 546);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.metroTabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Teal;
            this.Text = "Weight Bridge";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.mtpWeighBridge.ResumeLayout(false);
            this.mtpMasters.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroTile mtlSource;
        private MetroFramework.Controls.MetroTile mtlDestination;
        private MetroFramework.Controls.MetroTile mtlPortConfig;
        private MetroFramework.Controls.MetroTile mtTileWeighBridge;
        private MetroFramework.Controls.MetroTabPage mtpWeighBridge;
        private MetroFramework.Controls.MetroTile mtlTileProduct;
        private MetroFramework.Controls.MetroTile mtrTileVehicle;
        private MetroFramework.Controls.MetroTabPage mtpMasters;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTile metroTile3;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroTile mtlCustomer;
        private MetroFramework.Controls.MetroTile mtlSupplier;
        private MetroFramework.Controls.MetroButton btnLogout;
    }
}