using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace WeightBridgeMandya.clientui
{
    public partial class Home : MetroForm
    {
        public Home()
        {
            InitializeComponent();
        }

        #region Form Load Event
        private void Home_Load(object sender, EventArgs e)
        {
            metroTabControl1.SelectTab(mtpWeighBridge);
        }
        #endregion

        #region Tile Click Event
        private void mtTileWeighBridge_Click(object sender, EventArgs e)
        {
            ListWeighBridge frmListWeighBridge = new ListWeighBridge();
            frmListWeighBridge.ShowDialog();

        }

        private void mtlSource_Click(object sender, EventArgs e)
        {
            Source frmSource = new Source();
            frmSource.ShowDialog();
        }

        private void mtlDestination_Click(object sender, EventArgs e)
        {
            Destination frmdestination = new Destination();
            frmdestination.ShowDialog();
        }

        private void mtrTileVehicle_Click(object sender, EventArgs e)
        {
            Vehicle frmVehical = new Vehicle();
            frmVehical.ShowDialog();
        }

        private void mtlTileProduct_Click(object sender, EventArgs e)
        {
            Product frmProduct = new Product();
            frmProduct.ShowDialog();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            Route frmRoute = new Route();
            frmRoute.ShowDialog();
        }

        private void mtlPortConfig_Click(object sender, EventArgs e)
        {
          
                PortConfiguration frmPortConfiguration = new PortConfiguration();
                frmPortConfiguration.ShowDialog();
           
        }

        private void mtlSupplier_Click(object sender, EventArgs e)
        {
            Supplier frmSupplier = new Supplier();
            frmSupplier.ShowDialog();
        }

        private void mtlCustomer_Click(object sender, EventArgs e)
        {
            Customer frmCustomer = new Customer();
            frmCustomer.ShowDialog();
        }
        #endregion

        #region Logout Button Click Event
       
        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frmLogin = new Login();
            frmLogin.Show();
        }
        #endregion

        #region Form Closing Event
        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        #endregion


    }
}
