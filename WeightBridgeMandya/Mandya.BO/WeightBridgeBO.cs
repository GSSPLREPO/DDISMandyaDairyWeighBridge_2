using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandya.BO
{
    public class WeightBridgeBO
    {
        #region WeightBridge Class Properties

        public const string WEIGHTBRIDGE_TABLE = "tbl_WeightBridge";
        public const string WEIGHTBRIDGE_WEIGHTBRIDGEID = "WeightBridgeID";
        public const string WEIGHTBRIDGE_DATETIME = "DateTime";
        public const string WEIGHTBRIDGE_TANKERNO = "TankerNo";
        public const string WEIGHTBRIDGE_PURPOSE = "Purpose";
        public const string WEIGHTBRIDGE_TANKERID = "TankerID";
        public const string WEIGHTBRIDGE_ISACTIVE = "IsActive";
        public const string WEIGHTBRIDGE_DISPATCHCHALANNO = "DispatchChalanNo";
        public const string WEIGHTBRIDGE_TANKERSEALNO1 = "TankerSealNo1";
        public const string WEIGHTBRIDGE_TANKERSEALNO2 = "TankerSealNo2";
        public const string WEIGHTBRIDGE_TANKERSEALNO3 = "TankerSealNo3";
        public const string WEIGHTBRIDGE_TANKERSEALNO4 = "TankerSealNo4";
        public const string WEIGHTBRIDGE_SUPPLIERID = "SupplierID";
        public const string WEIGHTBRIDGE_CUSTOMERID = "CustomerID";
        public const string WEIGHTBRIDGE_SOURCEID = "SourceID";
        public const string WEIGHTBRIDGE_DESTINATIONID = "DestinationID";
        public const string WEIGHTBRIDGE_PRODUCTID = "ProductID";
        public const string WEIGHTBRIDGE_ROUTEID = "RouteID";
        public const string WEIGHTBRIDGE_WEIGHTBRIDGENO = "WeightBridgeNo";
        public const string WEIGHTBRIDGE_WEIGHTTYPE = "WeightType";
        public const string WEIGHTBRIDGE_WEIGHTSTEP = "WeightStep";
        public const string WEIGHTBRIDGE_ENTRYTYPE = "EntryType";
        public const string WEIGHTBRIDGE_CIPSTATUS = "CIPStatus";
        public const string WEIGHTBRIDGE_DRIVERNAME = "DriverName";
        public const string WEIGHTBRIDGE_REMARKS = "Remarks";
        public const string WEIGHTBRIDGE_TAREWEIGHT = "TareWeight";
        public const string WEIGHTBRIDGE_TAREWEIGHTDATETIME = "TareWeightDateTime";
        public const string WEIGHTBRIDGE_GROSSWEIGHT = "GrossWeight";
        public const string WEIGHTBRIDGE_GROSSWEIGHTDATETIME = "GrossWeightDateTime";
        public const string WEIGHTBRIDGE_NETWEIGHT = "NetWeight";
        public const string WEIGHTBRIDGE_SUPPLIEDQTY = "SuppliedQty";
        public const string WEIGHTBRIDGE_DIFFERENCEQTY = "DifferenceQty";
        public const string WEIGHTBRIDGE_ISDELETED = "IsDeleted";
        public const string WEIGHTBRIDGE_CREATEDBYID = "CreatedByID";
        public const string WEIGHTBRIDGE_CREATEDBYDATE = "CreatedByDate";
        public const string WEIGHTBRIDGE_LASTMODIFIEDBYID = "LastModifiedByID";
        public const string WEIGHTBRIDGE_LASTMODIFIEDBYDATE = "LastModifiedByDate";



        private int intWeightBridgeID = 0;
        private DateTime dtDateTime;
        private string strTankerNo = string.Empty;
        private int intPurpose = 0;
        private string strTankerID = string.Empty;
        private int intIsActive = 0;
        private string strDispatchChalanNo = string.Empty;
        private string strTankerSealNo1 = string.Empty;
        private string strTankerSealNo2 = string.Empty;
        private string strTankerSealNo3 = string.Empty;
        private string strTankerSealNo4 = string.Empty;
        private int intSupplierID = 0;
        private int intCustomerID = 0;
        private int intSourceID = 0;
        private int intDestinationID = 0;
        private int intProductID = 0;
        private int intRouteID = 0;
        private int intWeightBridgeNo = 0;
        private string strWeightType = string.Empty;
        private int intWeightStep = 0;
        private string strEntryType =string.Empty;
        private string strCIPStatus = string.Empty;
        private string strDriverName = string.Empty;
        private string strRemarks = string.Empty;
        private double dblTareWeight = 0;
        private DateTime dtTareWeightDateTime;
        private double dblGrossWeight = 0;
        private DateTime dtGorssWeightDateTime;
        private double dblNetWeight = 0;
        private double dblSuppliedQty = 0;
        private double dblDifferenceQty = 0;
        private int intIsDeleted = 0;
        private int intCreatedByID = 0;
        private DateTime dtCreatedByDate;
        private int intLastModifiedByID = 0;
        private DateTime dtLastModifiedByDate;


        #endregion

        #region ---Properties---
        public int WeightBridgeID
        {
            get { return intWeightBridgeID; }
            set { intWeightBridgeID = value; }
        }
        public DateTime DateTime
        {
            get { return dtDateTime; }
            set { dtDateTime = value; }
        }
        public string TankerNo
        {
            get { return strTankerNo; }
            set { strTankerNo = value; }
        }
        public int Purpose
        {
            get { return intPurpose; }
            set { intPurpose = value; }
        }
        public string TankerID
        {
            get { return strTankerID; }
            set { strTankerID = value; }
        }
        public int IsActive
        {
            get { return intIsActive; }
            set { intIsActive = value; }
        }
        public string DispatchChalanNo
        {
            get { return strDispatchChalanNo; }
            set { strDispatchChalanNo = value; }
        }
        public string TankerSealNo1
        {
            get { return strTankerSealNo1; }
            set { strTankerSealNo1 = value; }
        }
        public string TankerSealNo2
        {
            get { return strTankerSealNo2; }
            set { strTankerSealNo2 = value; }
        }
        public string TankerSealNo3
        {
            get { return strTankerSealNo3; }
            set { strTankerSealNo3 = value; }
        }
        public string TankerSealNo4
        {
            get { return strTankerSealNo4; }
            set { strTankerSealNo4 = value; }
        }

        public int SupplierID
        {
            get { return intSupplierID; }
            set { intSupplierID = value; }
        }

        public int CustomerID
        {
            get { return intCustomerID;}
            set { intCustomerID = value; }
        }
        public int SourceID
        {
            get { return intSourceID; }
            set { intSourceID = value; }
        }
        public int DestinationID
        {
            get { return intDestinationID; }
            set { intDestinationID = value; }
        }
        public int ProductID
        {
            get { return intProductID; }
            set { intProductID = value; }
        }
        public int RouteID
        {
            get { return intRouteID; }
            set { intRouteID = value; }
        }
        public int WeightBridgeNo
        {
            get { return intWeightBridgeNo; }
            set { intWeightBridgeNo = value; }
        }

        public string WeightType
        {
            get { return strWeightType; }
            set { strWeightType = value; }
        }

        public int WeightStep
        {
            get { return intWeightStep; }
            set { intWeightStep = value; }
        }

        public string EntryType
        {
            get { return strEntryType; }
            set { strWeightType = value; }
        }

        public string CIPStatus
        {
            get { return strCIPStatus; }
            set { strCIPStatus = value; }
        }

        public string DriverName
        {
            get { return strDriverName; }
            set { strDriverName = value; }
        }

        public string Remarks
        {
            get { return strRemarks; }
            set { strRemarks = value; }
        }

        public double TareWeight
        {
            get {return dblTareWeight; }
            set { dblTareWeight = value; }
        }

        public DateTime TareWeightDateTime
        {
            get { return dtTareWeightDateTime; }
            set { dtTareWeightDateTime = value; }
        }

        public double GrossWeight
        {
            get { return dblGrossWeight; }
            set { dblGrossWeight = value; }
        }

        public DateTime GrossWeightDateTime
        {
            get { return dtGorssWeightDateTime; }
            set { dtGorssWeightDateTime = value; }
        }

        public double NetWeight
        {
            get { return dblNetWeight; }
            set { dblNetWeight = value; }
        }

        public double SuppliedQty
        {
            get { return dblSuppliedQty; }
            set { dblSuppliedQty = value; }
        }

        public double DifferenceQty
        {
            get { return dblDifferenceQty; }
            set { dblDifferenceQty = value; }
        }

        public int IsDeleted
        {
            get { return intIsDeleted; }
            set { intIsDeleted = value; }
        }

        public int CreatedByID
        {
            get { return intCreatedByID; }
            set { intCreatedByID = value; }
        }

        public DateTime CreatedByDate
        {
            get { return dtCreatedByDate; }
            set { dtCreatedByDate = value; }
        }

        public int LastModifiedByID
        {
            get { return intLastModifiedByID; }
            set { intLastModifiedByID = value; }
        }

        public DateTime LastModifiedByDate
        {
            get { return dtLastModifiedByDate; }
            set { dtLastModifiedByDate = value; }
        }

        #endregion
    }
}
