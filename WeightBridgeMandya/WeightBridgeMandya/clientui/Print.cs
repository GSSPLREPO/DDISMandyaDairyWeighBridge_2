using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Mandya.BO;
using Mandya.BL;
using Mandya.Common;
using Microsoft.Reporting.WinForms;

namespace WeightBridgeMandya.clientui
{
    public partial class Print : MetroForm
    {
        private static readonly log4net.ILog log =
        log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public Print()
        {
            InitializeComponent();
        }

        #region Form Load Event
        private void Print_Load(object sender, EventArgs e)
        {

            this.rptViewerPrint.RefreshReport();
        }
        #endregion

        #region Form Run Event

        public void Run(int intPrintid, int intType)
        {
            try
            {
                List<Label> list = GetLabelDetail(intPrintid, intType);
                
                if (intType == 1)
                {
                    LocalReport report = new LocalReport();
                    report.ReportPath = Application.StartupPath + "\\Print\\InletSlip.rdlc";
                    report.DataSources.Add(new ReportDataSource("Print", list));
                    rptViewerPrint.LocalReport.ReportPath = Application.StartupPath + "\\Print\\InletSlip.rdlc"; // bind reportviewer with .rdlc

                    ReportDataSource dataset = new ReportDataSource("Print", list); // set the datasource
                    rptViewerPrint.LocalReport.DataSources.Add(dataset);
                    dataset.Value = list;
                     
                    rptViewerPrint.LocalReport.Refresh();
                    rptViewerPrint.RefreshReport(); // refresh report


                }
                else if (intType == 2)
                {
                    LocalReport report = new LocalReport();
                    report.ReportPath = Application.StartupPath + "\\Print\\OutletSlip.rdlc";
                    report.DataSources.Add(new ReportDataSource("Print", list));
                    rptViewerPrint.LocalReport.ReportPath = Application.StartupPath + "\\Print\\OutletSlip.rdlc"; // bind reportviewer with .rdlc

                    ReportDataSource dataset = new ReportDataSource("Print", list); // set the datasource
                    rptViewerPrint.LocalReport.DataSources.Add(dataset);
                    dataset.Value = list;

                    rptViewerPrint.LocalReport.Refresh();
                    rptViewerPrint.RefreshReport();
                }

                else
                {
                    MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Print();
        }

        #endregion

        #region Get Label List Event
        private List<Label> GetLabelDetail(int intPrintId, int intType)
        {
            WeightBridgeBL objWeightBridgeBL = new WeightBridgeBL();
            ApplicationResult objResult = new ApplicationResult();
            int intid = intPrintId;
            int Type = intType;
            List<Label> list = null;
            objResult = objWeightBridgeBL.WeightBridge_Select_ForPrint(Convert.ToInt32(intid), Convert.ToInt32(Type));
            if (objResult != null)
            {
                if (objResult.ResultDt.Rows.Count > 0)
                {

                    list = new List<Label>{
                        new Label
                        {
                            TankerID = objResult.ResultDt.Rows[0]["TankerID"].ToString(),
                            TankerNo = objResult.ResultDt.Rows[0]["TankerNo"].ToString(),
                            ProductName = objResult.ResultDt.Rows[0]["ProductName"].ToString(),
                            GrossWeight = objResult.ResultDt.Rows[0]["GrossWeight"].ToString(),
                            TareWeight = objResult.ResultDt.Rows[0]["TareWeight"].ToString(),
                            NetWeight =objResult.ResultDt.Rows[0]["NetWeight"].ToString(),
                            Purpose =objResult.ResultDt.Rows[0]["Purpose"].ToString(),
                            DriverName =objResult.ResultDt.Rows[0]["DriverName"].ToString(),
                            TWDate =objResult.ResultDt.Rows[0]["TWDate"].ToString(),
                            GWDate =objResult.ResultDt.Rows[0]["GWDate"].ToString(),
                            GWTime = objResult.ResultDt.Rows[0]["GWTime"].ToString(),
                            TWTime = objResult.ResultDt.Rows[0]["TWTime"].ToString(),
                            SuppliedQty =objResult.ResultDt.Rows[0]["SuppliedQty"].ToString(),
                            DifferenceQty =objResult.ResultDt.Rows[0]["DifferenceQty"].ToString(),
                            ChallanNo =objResult.ResultDt.Rows[0]["ChallanNo"].ToString(),
                            SupplierName =objResult.ResultDt.Rows[0]["SupplierName"].ToString(),
                            CustomerName =objResult.ResultDt.Rows[0]["CustomerName"].ToString()

                        }
                    };
                }
            }

            return list;
        }
        #endregion

        #region Label Class Get Set Method

        public class Label
        {
            public string TankerID { get; set; }
            public string GrossWeight { get; set; }
            public string TareWeight { get; set; }
            public string NetWeight { get; set; }
            public string Purpose { get; set; }
            public string DriverName { get; set; }
            public string TWDate { get; set; }
            public string GWDate { get; set; }
            public string GWTime { get; set; }
            public string TWTime { get; set; }
            public string TankerNo { get; set; }
            public string ProductName { get; set; }
            public string SuppliedQty { get; set; }
            public string DifferenceQty { get; set; }
            public string ChallanNo { get; set; }
            public string SupplierName { get; set; }
            public string CustomerName { get; set; }

        }

        #endregion
        private void rptViewerPrint_Load(object sender, EventArgs e)
        {

        }
    }
}
