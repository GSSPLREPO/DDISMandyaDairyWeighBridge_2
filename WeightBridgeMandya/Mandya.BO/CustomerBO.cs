using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mandya.BO
{
    public class CustomerBO
    {

        #region Customer Class Properties

        public const string CUSTOMER_TABLE = "tbl_Customer";
        public const string CUSTOMER_CUSTOMERID = "CustomerID";
        public const string CUSTOMER_CUSTOMERCODE = "CustomerCode";
        public const string CUSTOMER_CUSTOMERNAME = "CustomerName";
        public const string CUSTOMER_ADDRESS = "Address";
        public const string CUSTOMER_CITY = "City";
        public const string CUSTOMER_DISTRICT = "District";
        public const string CUSTOMER_STATE = "State";
        public const string CUSTOMER_COUNTRY = "Country";
        public const string CUSTOMER_PHONE = "Phone";
        public const string CUSTOMER_EMAIL = "Email";
        public const string CUSTOMER_REMARKS = "Remarks";
        public const string CUSTOMER_CREATEDBYID = "CreatedByID";
        public const string CUSTOMER_CREATEDBYDATE = "CreatedBYDate";
        public const string CUSTOMER_LASTMODIFIEDBYID = "LastModifiedByID";
        public const string CUSTOMER_LASTMODIFIEDBYDATE = "LastModifiedBYDate";
        public const string CUSTOMER_ISDELETED = "IsDeleted";



        private int intCustomerID = 0;
        private string strCustomerCode = string.Empty;
        private string strCustomerName = string.Empty;
        private string strAddress = string.Empty;
        private string strCity = string.Empty;
        private string strDistrict = string.Empty;
        private string strState = string.Empty;
        private string strCountry = string.Empty;
        private string strPhone = string.Empty;
        private string strEmail = string.Empty;
        private string strRemarks = string.Empty;
        private int intCreatedByID = 0;
        private DateTime strCreatedByDate ;
        private int intLastModifiedByID = 0;
        private DateTime strLastModifiedByDate;
        private int intIsDeleted = 0;

        #endregion

        #region ---Properties---
        public int CustomerID
        {
            get { return intCustomerID; }
            set { intCustomerID = value; }
        }
        public string CustomerCode
        {
            get { return strCustomerCode; }
            set { strCustomerCode = value; }
        }
        public string CustomerName
        {
            get { return strCustomerName; }
            set { strCustomerName = value; }
        }
        public string Address
        {
            get { return strAddress; }
            set { strAddress = value; }
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
        public string Country
        {
            get { return strCountry; }
            set { strCountry = value; }
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
            get { return intLastModifiedByID; }
            set { intLastModifiedByID = value; }
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
