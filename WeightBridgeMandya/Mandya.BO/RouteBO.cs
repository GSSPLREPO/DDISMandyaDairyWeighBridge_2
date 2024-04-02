    using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mandya.BO
{
   public class RouteBO
    {
        #region Route Class Properties

        public const string ROUTE_TABLE = "tbl_Route";
        public const string ROUTE_ROUTEID = "RouteID";
        public const string ROUTE_ROUTENAME = "RouteName";
        public const string ROUTE_ROUTECODE = "RouteCode";
        public const string ROUTE_ISDELETED = "IsDeleted";
        public const string ROUTE_CREATEDBY = "CreatedBy";
        public const string ROUTE_CREATEDDATE = "CreatedDate";
        public const string ROUTE_LASTMODIFIEDBY = "LastModifiedBy";
        public const string ROUTE_LASTMODIFIEDDATE = "LastModifiedDate";



        private int intRouteID = 0;
        private string strRouteCode = string.Empty;
        private string strRouteName = string.Empty;
        private bool boolIsDeleted = false;
        private int intCreatedBy = 0;
        private DateTime dtCreatedDate;
        private int intLastModifiedBy = 0;
        private DateTime dtLastModifiedDate;

        #endregion

        #region ---Properties---
        public int RouteID
        {
            get { return intRouteID; }
            set { intRouteID = value; }
        }
        public string RouteCode
        {
            get { return strRouteCode; }
            set { strRouteCode = value; }
        }
        public string RouteName
        {
            get { return strRouteName; }
            set { strRouteName = value; }
        }

       
       public bool IsDeleted
       {
           get{return boolIsDeleted;}
           set { boolIsDeleted = value; }
       }
        public int CreatedBy
        {
            get { return intCreatedBy; }
            set { intCreatedBy = value; }
        }
        public DateTime CreatedDate
        {
            get { return dtCreatedDate; }
            set { dtCreatedDate = value; }
        }
        public int LastModifiedBy
        {
            get { return intLastModifiedBy; }
            set { intLastModifiedBy = value; }
        }
        public DateTime LastModifiedDate
        {
            get { return dtLastModifiedDate; }
            set { dtLastModifiedDate = value; }
        }

        #endregion
    }
}
