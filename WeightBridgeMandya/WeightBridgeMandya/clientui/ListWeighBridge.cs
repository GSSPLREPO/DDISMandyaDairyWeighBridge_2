using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Mandya.BL;
using Mandya.BO;
using Mandya.Common;
using MetroFramework;
using WeightBridgeMandya.Print;

namespace WeightBridgeMandya.clientui
{
    public partial class ListWeighBridge : MetroForm
    {
        private static readonly log4net.ILog log =
        log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DataTable dtWeighbridge = new DataTable();

        #region Initialize Component
        public ListWeighBridge()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Load Event
        private void ListWeighBridge_Load(object sender, EventArgs e)
        {
            BindWeightBridge();
        }
        #endregion

        #region BindWeighBridge
        private void BindWeightBridge()
        {
            try
            {
                WeightBridgeBL objWeighBridgeBL = new WeightBridgeBL();
                var objResult = objWeighBridgeBL.WeightBridge_SelectAll();
                if (objResult != null)
                {
                    if (objResult.ResultDt.Rows.Count > 0)
                    {
                        gvWeightBridge.AutoGenerateColumns = false;
                        gvWeightBridge.DataSource = objResult.ResultDt;
                        dtWeighbridge = objResult.ResultDt;
                        gvWeightBridge.Visible = true;
                        txtTankerNo.Enabled = true;
                    }
                    else
                    {
                        gvWeightBridge.AutoGenerateColumns = false;
                        gvWeightBridge.DataSource = objResult.ResultDt;
                        dtWeighbridge = objResult.ResultDt;
                        gvWeightBridge.Visible = false;
                        txtTankerNo.Enabled = false;
                    }
                }
            }
            catch(Exception ex)
            {
                log.Error("error", ex);
                MessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Add Button Click Event
        [Obsolete]
        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                WeightBridge frmWeightBridge = new WeightBridge(-1,0);
                frmWeightBridge.ShowDialog();
                this.Activate();
                this.Show();
                BindWeightBridge();
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region WeightBridge Gridview Cell contennt Click Event
        [Obsolete]
        private void gvWeightBridge_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1 && e.ColumnIndex == 0)
                {
                    int WeighBridgeId = Convert.ToInt32(gvWeightBridge[2, e.RowIndex].Value);
                    using (Printing demo = new Printing())
                    {
                        int a = 0;
                        a = 1;
                        Print frmPrint = new Print();
                        frmPrint.Show();
                        frmPrint.Run(WeighBridgeId, a);
                    }
                }
                if (e.RowIndex != -1 && e.ColumnIndex == 1)
                {
                    int id = Convert.ToInt32(gvWeightBridge[2, e.RowIndex].Value);
                    this.Hide();
                    WeightBridge frmWeightBridge = new WeightBridge(id,1);
                    frmWeightBridge.ShowDialog();
                    this.Activate();
                    this.Show();
                    BindWeightBridge();
                }
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.",
                    "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Tanker No Textbox KeyPress Event
        private void txtTankerNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8 || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
            txtTankerNo.Text.ToUpper();
        }
        #endregion

        #region Tanker No Textbox Text Changed Event
        private void txtTankerNo_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataView dv = new DataView(dtWeighbridge);
                dv.RowFilter = string.Concat("CONVERT(TankerNo,System.String) LIKE '%", txtTankerNo.Text, "%'");
                gvWeightBridge.DataSource = dv.ToTable();
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Edit / Delete Button Click Event
        private void btnEditDelete_Click(object sender, EventArgs e)
        {
            try
            {

                this.Hide();
                EditDeleteWeightBridge frmEditDeleteWeightBridge = new EditDeleteWeightBridge();
                frmEditDeleteWeightBridge.ShowDialog();
                this.Activate();
                this.Show();


            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.",
                    "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Close Button Click Event
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
