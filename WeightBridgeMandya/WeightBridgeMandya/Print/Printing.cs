using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mandya.BL;
using Mandya.Common;
using Microsoft.Reporting.WinForms;
using System.Web;

namespace WeightBridgeMandya.Print
{
    public class Printing :IDisposable
    {
        #region Declaration
        private int m_currentPageIndex;
        private IList<Stream> m_streams;
        #endregion

        #region Run Method
        public void Run(int intPrintid, int intType)
        {
            List<Label> list = GetLabelDetail(intPrintid, intType);  
            if (intType == 1)
            {
                LocalReport report = new LocalReport();
                report.ReportPath = Application.StartupPath + "\\Print\\InletSlip.rdlc";
                report.DataSources.Add(new ReportDataSource("Print", list));
            }
            else if (intType == 2)
            {
                LocalReport report = new LocalReport();
                report.ReportPath = Application.StartupPath + "\\Print\\OutletSlip.rdlc";
                report.DataSources.Add(new ReportDataSource("Print", list));
            }
            else
            {
                MessageBox.Show("Oops! There is some technical issue. Please Contact to your administrator.");
            }
        }
        #endregion

        #region Get Label Details Method
        public static List<Label> GetLabelDetail(int intPrintId, int intType)
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
                            ChallanNo = objResult.ResultDt.Rows[0]["ChallanNo"].ToString(),
                            TankerID = objResult.ResultDt.Rows[0]["TankerID"].ToString(),
                            TankerNo = objResult.ResultDt.Rows[0]["TankerNo"].ToString(),
                            ProductName = objResult.ResultDt.Rows[0]["ProductName"].ToString(),
                            GrossWeight = objResult.ResultDt.Rows[0]["GrossWeight"].ToString(),
                            TareWeight= objResult.ResultDt.Rows[0]["TareWeight"].ToString(),
                            NetWeight =objResult.ResultDt.Rows[0]["NetWeight"].ToString(),
                            Purpose =objResult.ResultDt.Rows[0]["Purpose"].ToString(),
                            DriverName =objResult.ResultDt.Rows[0]["DriverName"].ToString(),
                            TWDate =objResult.ResultDt.Rows[0]["TWDate"].ToString(),
                            GWDate =objResult.ResultDt.Rows[0]["GWDate"].ToString(),
                            GWTime = objResult.ResultDt.Rows[0]["GWTime"].ToString(),
                            TWTime = objResult.ResultDt.Rows[0]["TWTime"].ToString(),
                            WeighMode = objResult.ResultDt.Rows[0]["WeightMode"].ToString(),
                            SuppliedQty = objResult.ResultDt.Rows[0]["SuppliedQty"].ToString(),
                            DifferenceQty = objResult.ResultDt.Rows[0]["DifferenceQty"].ToString()
                        }
                    };
                }
            }


            return list;
        }
        #endregion

        #region Dispose Method
        public void Dispose()
        {
            if (m_streams != null)
            {
                foreach (Stream stream in m_streams)
                    stream.Close();
                m_streams = null;
            }
        }
        #endregion

        #region Label Class Variable Initialization
        public class Label
        {
            public string ChallanNo { get; set; }
            public string TankerID { get; set; }
            public string TankerNo { get; set; }
            public string ProductName { get; set; }
            public string GrossWeight { get; set; }
            public string TareWeight { get; set; }
            public string NetWeight { get; set; }
            public string Purpose { get; set; }
            public string DriverName { get; set; }
            public string TWDate { get; set; }
            public string GWDate { get; set; }
            public string GWTime { get; set; }
            public string TWTime { get; set; }
            public string WeighMode { get; set; }

            public string SuppliedQty { get; set; }

            public string DifferenceQty { get; set; }

        }
        #endregion
    }
        
}
