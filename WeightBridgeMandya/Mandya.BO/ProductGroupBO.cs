using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandya.BO
{
    public class ProductGroupBO
    {

        #region ProductGroup Class Properties

        public const string PRODUCTGROUP_TABLE = "ProductGroup";
        public const string PRODUCTGROUP_PRODUCTGROUPID = "ProductGroupId";
        public const string PRODUCTGROUP_PRODUCTGROUPCODE = "ProductGroupCode";
        public const string PRODUCTGROUP_PRODUCTGROUPNAME = "ProductGroupName";
        public const string PRODUCTGROUP_REMARKS = "Remarks";
        public const string PRODUCTGROUP_CREATEDBY = "CreatedBy";
        public const string PRODUCTGROUP_CREATEDDATE = "CreatedDate";
        public const string PRODUCTGROUP_LASTMODIFIEDBY = "LastModifiedBy";
        public const string PRODUCTGROUP_LASTMODIFIEDDATE = "LastModifiedDate";
        public const string PRODUCTGROUP_ISDELETED = "IsDeleted";



        private int intProductGroupId = 0;
        private string strProductGroupCode = string.Empty;
        private string strProductGroupName = string.Empty;
        private string strRemarks = string.Empty;
        private int intCreatedBy = 0;
        private string strCreatedDate = string.Empty;
        private int strLastModifiedBy = 0;
        private string strLastModifiedDate = string.Empty;
        private int intIsDeleted = 0;

        #endregion

        #region ---Properties---
        public int ProductGroupId
        {
            get { return intProductGroupId; }
            set { intProductGroupId = value; }
        }
        public string ProductGroupCode
        {
            get { return strProductGroupCode; }
            set { strProductGroupCode = value; }
        }
        public string ProductGroupName
        {
            get { return strProductGroupName; }
            set { strProductGroupName = value; }
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
