using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandya.BO
{
   public class DestinationBO
    {
        #region DESTINATION Class Properties

        public const string DESTINATION_TABLE = "DESTINATION";
        public const string DESTINATION_DESTINATIONID = "id";
        public const string DESTINATION_DESTINATIONCODE = "DestinationCode";
        public const string DESTINATION_DESTINATIONNAME = "DestinationName";
       /// public const string DESTINATION_REMARKS = "Remarks";
        public const string DESTINATION_CREATEDBY = "CreatedBy";
        public const string DESTINATION_CREATEDDATE = "CreatedDate";
        public const string DESTINATION_LASTMODIFIEDBY = "LastModifiedBy";
        public const string DESTINATION_LASTMODIFIEDDATE = "LastModifiedDate";
        public const string DESTINATION_ISDELETED = "IsDeleted";



        private int intDestinationId = 0;
        private string strDESTINATIONCode = string.Empty;
        private string strDestinationName = string.Empty;
       // private string strRemarks = string.Empty;
        private int intCreatedBy = 0;
        private string strCreatedDate = string.Empty;
        private int strLastModifiedBy = 0;
        private string strLastModifiedDate = string.Empty;
        private int intIsDeleted = 0;

        #endregion

        #region ---Properties---
        public int DESTINATIONId
        {
            get { return intDestinationId; }
            set { intDestinationId = value; }
        }
     
        public string DESTINATIONName
        {
            get { return strDestinationName; }
            set { strDestinationName = value; }
        }

        public string DESTINATIONCode
        {
            get { return strDESTINATIONCode; }
            set { strDESTINATIONCode = value; }
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
