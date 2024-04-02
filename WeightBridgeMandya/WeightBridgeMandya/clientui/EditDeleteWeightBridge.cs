using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mandya.Common;
using Mandya.BO;
using Mandya.BL;
using MetroFramework;
using MetroFramework.Forms;
using System.Globalization;
using WeightBridgeMandya.Print;

namespace WeightBridgeMandya.clientui
{
    public partial class EditDeleteWeightBridge : MetroForm
    {
        private static readonly log4net.ILog log =
        log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        DataTable dtWeighbridge = new DataTable();

        #region Initialize Component
        public EditDeleteWeightBridge()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Load Event
        private void EditDeleteWeightBridge_Load(object sender, EventArgs e)
        {
            gvWeightBridge.Visible = false;
            lblTankerNo.Visible = false;
            txtTankerNo.Visible = false;
        }
        #endregion

        #region BindWeighBridge
        private void BindWeightBridge()
        {

            DateTime FromDate = Convert.ToDateTime(dtFromDate.Text);
            DateTime ToDate = Convert.ToDateTime(dtToDate.Text);
            WeightBridgeBL objWeighBridgeBL = new WeightBridgeBL();
            var objResult = objWeighBridgeBL.WeightBridge_SelectAll_Edit_Delete(FromDate, ToDate);

            if (objResult != null)
            {
                if (objResult.ResultDt.Rows.Count > 0)
                {
                    gvWeightBridge.AutoGenerateColumns = false;
                    gvWeightBridge.DataSource = objResult.ResultDt;
                    dtWeighbridge = objResult.ResultDt;
                    lblTankerNo.Visible = true;
                    txtTankerNo.Visible = true;
                    gvWeightBridge.Visible = true;
                    txtTankerNo.Focus();
                }
                else
                {
                    gvWeightBridge.AutoGenerateColumns = false;
                    gvWeightBridge.DataSource = objResult.ResultDt;
                    dtWeighbridge = objResult.ResultDt;
                    lblTankerNo.Visible = false;
                    txtTankerNo.Visible = false;
                    gvWeightBridge.Visible = false;
                    MetroMessageBox.Show(this, "Record Not Found !", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        #endregion

        #region Tanker No Textbox Text Changed Event
        #endregion

        #region Go Button Click Event
        private void btnGo_Click(object sender, EventArgs e)
        {
            if (Convert.ToDateTime(dtFromDate.Text) > Convert.ToDateTime(dtToDate.Text))
            {
                MetroMessageBox.Show(this, "From Date Cannto Be Greter then To Date",
                                "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                BindWeightBridge();
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
                    int id = Convert.ToInt32(gvWeightBridge[3, e.RowIndex].Value);
                    using (Printing demo = new Printing())
                    {
                        int a = 0;
                        a = 2;
                        Print frmPrint = new Print();
                        frmPrint.Show();
                        frmPrint.Run(id, a);
                    }

                }
                else if (e.RowIndex != -1 && e.ColumnIndex == 1)
                {
                    if (Program.intRoleId == 1)
                    {
                        int id = Convert.ToInt32(gvWeightBridge[3, e.RowIndex].Value);
                        this.Hide();
                        WeightBridge frmWeightBridge = new WeightBridge(id, 2);
                        frmWeightBridge.ShowDialog();
                        this.Activate();
                        this.Show();
                        btnGo_Click(sender, e);
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Access Denied","WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (e.RowIndex != -1 && e.ColumnIndex == 2)
                {
                    if (Program.intRoleId == 1)
                    {
                        int id = Convert.ToInt32(gvWeightBridge[3, e.RowIndex].Value);
                        DialogResult result = MetroMessageBox.Show(this, "Do you really want to delete this record?", "WeighBridge", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            ApplicationResult objResult = new ApplicationResult();
                            WeightBridgeBL objWeightBridgeBL = new WeightBridgeBL();
                            objResult = objWeightBridgeBL.WeightBridge_Delete(id, Program.intUserId);
                            if (objResult.Status.ToString() == "Success")
                            {
                                MetroMessageBox.Show(this, "Record Deleted Successfully.", "WeighBridge",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                                btnGo_Click(sender, e);
                            }
                            else
                            {
                                MetroMessageBox.Show(this, "You cannot delete this record. Because it is in use.",
                                    "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MetroMessageBox.Show(this, "Access Denied", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.",
                    "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Close Button Click Event
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region TankerNo Textbox KeyPress Event
        private void txtTankerNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
        }
        #endregion

        #region Textbox TankerNo text Changed Event
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
    }
}
