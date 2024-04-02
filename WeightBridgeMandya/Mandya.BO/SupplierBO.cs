using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandya.BO
{
    public class SupplierBO
    {
        #region Supplier Class Properties

        public const string SUPPLIER_TABLE = "tbl_Supplier";
        public const string SUPPLIER_SUPPLIERID = "SupplierID";
        public const string SUPPLIER_SUPPLIERCODE = "SupplierCode";
        public const string SUPPLIER_SUPPLIERNAME = "SupplierName";
        public const string SUPPLIER_ADDRESS = "Address";
        public const string SUPPLIER_CITY = "City";
        public const string SUPPLIER_DISTRICT = "District";
        public const string SUPPLIER_STATE = "State";
        public const string SUPPLIER_PHONE = "Phone";
        public const string SUPPLIER_EMAIL = "Email";
        public const string SUPPLIER_COUNTRY = "Country";
        public const string SUPPLIER_REMARKS = "Remarks";
        public const string SUPPLIER_CREATEDBYID = "CreatedByID";
        public const string SUPPLIER_CREATEDBYDATE = "CreatedByDate";
        public const string SUPPLIER_LASTMODIFIEDBYID = "LastModifiedByID";
        public const string SUPPLIER_LASTMODIFIEDBYDATE = "LastModifiedByDate";
        public const string SUPPLIER_ISDELETED = "IsDeleted";



        private int intSupplierID = 0;
        private string strSupplierCode = string.Empty;
        private string strSupplierName = string.Empty;
        private string strAddress = string.Empty;
        private string strCity = string.Empty;
        private string strDistrict = string.Empty;
        private string strState = string.Empty;
        private string strPhone = string.Empty;
        private string strEmail = string.Empty;
        private string strRemarks = string.Empty;
        private int intCreatedByID = 0;
        private DateTime strCreatedByDate ;
        private int strLastModifiedByID = 0;
        private DateTime strLastModifiedByDate;
        private string strCountry = string.Empty;
        private int intIsDeleted = 0;

        #endregion

        #region ---Properties---
        public int SupplierID
        {
            get { return intSupplierID; }
            set { intSupplierID = value; }
        }
        public string SupplierCode
        {
            get { return strSupplierCode; }
            set { strSupplierCode = value; }
        }
        public string SupplierName
        {
            get { return strSupplierName; }
            set { strSupplierName = value; }
        }

        public string Address
        {
            get { return strAddress; }
            set { strAddress = value; }
        }

        public string Country
        {
            get { return strCountry; }
            set { strCountry = value; }
        }
       
        public string City
        {
            get { return strCity; }
            set { strCity = value; }
        }
        public string District
        {
            get { return strDistrict; }
            set { strDistrict = value; }
        }
        public string State
        {
            get { return strState; }
            set { strState = value; }
        }
        public string Phone
        {
            get { return strPhone; }
            set { strPhone = value; }
        }
        public string Email
        {
            get { return strEmail; }
            set { strEmail = value; }
        }
        
        public string Remarks
        {
            get { return strRemarks; }
            set { strRemarks = value; }
        }
        public int CreatedByID
        {
            get { return intCreatedByID; }
            set { intCreatedByID = value; }
        }
        public DateTime CreatedByDate
        {
            get { return strCreatedByDate; }
            set { strCreatedByDate = value; }
        }
        public int LastModifiedByID
        {
            get { return strLastModifiedByID; }
            set { strLastModifiedByID = value; }
        }
        public DateTime LastModifiedByDate
        {
            get { return strLastModifiedByDate; }
            set { strLastModifiedByDate = value; }
        }
        public int IsDeleted
        {
            get { return intIsDeleted; }
            set { intIsDeleted = value; }
        }

        #endregion
    }
}
