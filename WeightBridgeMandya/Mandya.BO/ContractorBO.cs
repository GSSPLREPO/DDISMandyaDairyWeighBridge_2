using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandya.BO
{
   public  class ContractorBO
    {
        #region Contractor Class Properties

        public const string CONTRACTOR_TABLE = "Contractor";
        public const string CONTRACTOR_CONTRACTORID = "ContractorId";
        public const string CONTRACTOR_CONTRACTORCODE = "ContractorCode";
        public const string CONTRACTOR_CONTRACTORNAME = "ContractorName";
        public const string CONTRACTOR_ADDRESS = "Address";
        public const string CONTRACTOR_CITY = "City";
        public const string CONTRACTOR_STATE = "State";
        public const string CONTRACTOR_PHONE = "Phone";
        public const string CONTRACTOR_EMAIL = "Email";
        public const string CONTRACTOR_ALIASNAME = "AliasName";
        public const string CONTRACTOR_REMARKS = "Remarks";
        public const string CONTRACTOR_CREATEDBY = "CreatedBy";
        public const string CONTRACTOR_CREATEDDATE = "CreatedDate";
        public const string CONTRACTOR_LASTMODIFIEDBY = "LastModifiedBy";
        public const string CONTRACTOR_LASTMODIFIEDDATE = "LastModifiedDate";
        public const string CONTRACTOR_ISDELETED = "IsDeleted";



        private int intContractorId = 0;
        private string strContractorCode = string.Empty;
        private string strContractorName = string.Empty;
        private string strAddress = string.Empty;
        private string strCity = string.Empty;
        private string strState = string.Empty;
        private string strPhone = string.Empty;
        private string strEmail = string.Empty;
        private string strAliasName = string.Empty;
        private string strRemarks = string.Empty;
        private int intCreatedBy = 0;
        private string strCreatedDate = string.Empty;
        private int strLastModifiedBy = 0;
        private string strLastModifiedDate = string.Empty;
        private int intIsDeleted = 0;

        #endregion

        #region ---Properties---
        public int ContractorId
        {
            get { return intContractorId; }
            set { intContractorId = value; }
        }
        public string ContractorCode
        {
            get { return strContractorCode; }
            set { strContractorCode = value; }
        }
        public string ContractorName
        {
            get { return strContractorName; }
            set { strContractorName = value; }
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
        public string AliasName
        {
            get { return strAliasName; }
            set { strAliasName = value; }
        }
        public string Remarks
        {
            get { return strRemarks; }
            set { strRemarks = value; }
        }
        public int CreatedBy
        {
            get { return intCreatedBy; }
            set { intCreatedBy = value; }
        }
        public string CreatedDate
        {
            get { return strCreatedDate; }
            set { strCreatedDate = value; }
        }
        public int LastModifiedBy
        {
            get { return strLastModifiedBy; }
            set { strLastModifiedBy = value; }
        }
        public string LastModifiedDate
        {
            get { return strLastModifiedDate; }
            set { strLastModifiedDate = value; }
        }
        public int IsDeleted
        {
            get { return intIsDeleted; }
            set { intIsDeleted = value; }
        }

        #endregion

        
    }
}
