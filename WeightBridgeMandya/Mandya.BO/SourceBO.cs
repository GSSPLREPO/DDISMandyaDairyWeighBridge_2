using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandya.BO
{
   public class SourceBO
    {
        #region SOURCE Class Properties

        public const string SOURCE_TABLE = "Source";
        public const string SOURCE_SOURCEID = "id";
        public const string SOURCE_SOURCECODE = "SourceCode";
        public const string SOURCE_SOURCENAME = "SourceName";
       /// public const string SOURCE_REMARKS = "Remarks";
        public const string SOURCE_CREATEDBY = "CreatedBy";
        public const string SOURCE_CREATEDDATE = "CreatedDate";
        public const string SOURCE_LASTMODIFIEDBY = "LastModifiedBy";
        public const string SOURCE_LASTMODIFIEDDATE = "LastModifiedDate";
        public const string SOURCE_ISDELETED = "IsDeleted";



        private int intSourceId = 0;
        private string strSourceCode = string.Empty;
        private string strSourceName = string.Empty;
       // private string strRemarks = string.Empty;
        private int intCreatedBy = 0;
        private string strCreatedDate = string.Empty;
        private int strLastModifiedBy = 0;
        private string strLastModifiedDate = string.Empty;
        private int intIsDeleted = 0;

        #endregion

        #region ---Properties---
        public int SourceId
        {
            get { return intSourceId; }
            set { intSourceId = value; }
        }
     
        public string SourceName
        {
            get { return strSourceName; }
            set { strSourceName = value; }
        }

        public string SourceCode
        {
            get { return strSourceCode; }
            set { strSourceCode = value; }
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
