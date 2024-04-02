using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Mandya.BO;
using Mandya.Common;
using Mandya.DataAccess;

namespace Mandya.BL
{
    public class CustomerBL
    {
        #region user defined variables
        public string sSql;
        public string strStoredProcName;
        public SqlParameter[] pSqlParameter = null;
        #endregion

        #region Select All Customer Details
        /// <summary>
        /// To Select All data from the Customer table
        /// Created By : Vishal, 12/11/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult Customer_SelectAll()
        {
            try
            {
                sSql = "usp_tbl_Customer_SelectAll";
                DataTable dtCustomer = new DataTable();
                dtCustomer = Database.ExecuteDataTable(CommandType.StoredProcedure, sSql, null);

                ApplicationResult objResults = new ApplicationResult(dtCustomer);
                objResults.Status = ApplicationResult.CommonStatusType.Success;
                return objResults;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Select Customer Details by CustomerId
        /// <summary>
        /// Select all details of Customer for selected CustomerId from Customer table
        /// Created By : Vishal, 12/11/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult Customer_Select(int intCustomerID)
        {
            try
            {
                pSqlParameter = new SqlParameter[1];

                pSqlParameter[0] = new SqlParameter("@CustomerID", SqlDbType.Int);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = intCustomerID;

                strStoredProcName = "usp_tbl_Customer_Select";

                DataTable dtResult = new DataTable();
                dtResult = Database.ExecuteDataTable(CommandType.StoredProcedure, strStoredProcName, pSqlParameter);
                ApplicationResult objResults = new ApplicationResult(dtResult);
                objResults.Status = ApplicationResult.CommonStatusType.Success;
                return objResults;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Delete Customer Details by CustomerId
        /// <summary>
        /// To Delete details of Customer for selected CustomerId from Customer table
        /// Created By : Vishal, 12/11/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult Customer_Delete(int intCustomerId, int intLastModifiedByID, DateTime dtDateTime)
        {
            try
            {
                pSqlParameter = new SqlParameter[3];

                pSqlParameter[0] = new SqlParameter("@CustomerID", SqlDbType.Int);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = intCustomerId;

                pSqlParameter[1] = new SqlParameter("@LastModifiedByID", SqlDbType.Int);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = intLastModifiedByID;

                pSqlParameter[2] = new SqlParameter("@LastModifiedByDate", SqlDbType.DateTime);
                pSqlParameter[2].Direction = ParameterDirection.Input;
                pSqlParameter[2].Value = dtDateTime;

                strStoredProcName = "usp_tbl_Customer_Delete";

                int iResult = Database.ExecuteNonQuery(CommandType.StoredProcedure, strStoredProcName, pSqlParameter);

                if (iResult > 0)
                {
                    ApplicationResult objResults = new ApplicationResult();
                    objResults.Status = ApplicationResult.CommonStatusType.Success;
                    return objResults;
                }
                else
                {
                    ApplicationResult objResults = new ApplicationResult();
                    objResults.Status = ApplicationResult.CommonStatusType.Failure;
                    return objResults;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Insert Customer Details
        /// <summary>
        /// To Insert details of Customer in Customer table
        /// Created By : Vishal, 12/11/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult Customer_Insert(CustomerBO objCustomerBo)
        {
            try
            {
                pSqlParameter = new SqlParameter[12];


                pSqlParameter[0] = new SqlParameter("@CustomerCode", SqlDbType.VarChar);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = objCustomerBo.CustomerCode;

                pSqlParameter[1] = new SqlParameter("@CustomerName", SqlDbType.VarChar);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = objCustomerBo.CustomerName;

                pSqlParameter[2] = new SqlParameter("@Address", SqlDbType.VarChar);
                pSqlParameter[2].Direction = ParameterDirection.Input;
                pSqlParameter[2].Value = objCustomerBo.Address;

                pSqlParameter[3] = new SqlParameter("@City", SqlDbType.VarChar);
                pSqlParameter[3].Direction = ParameterDirection.Input;
                pSqlParameter[3].Value = objCustomerBo.City;

                pSqlParameter[4] = new SqlParameter("@District", SqlDbType.VarChar);
                pSqlParameter[4].Direction = ParameterDirection.Input;
                pSqlParameter[4].Value = objCustomerBo.District;

                pSqlParameter[5] = new SqlParameter("@State", SqlDbType.VarChar);
                pSqlParameter[5].Direction = ParameterDirection.Input;
                pSqlParameter[5].Value = objCustomerBo.State;

                pSqlParameter[6] = new SqlParameter("@Country", SqlDbType.VarChar);
                pSqlParameter[6].Direction = ParameterDirection.Input;
                pSqlParameter[6].Value = objCustomerBo.Country;

                pSqlParameter[7] = new SqlParameter("@Phone", SqlDbType.VarChar);
                pSqlParameter[7].Direction = ParameterDirection.Input;
                pSqlParameter[7].Value = objCustomerBo.Phone;

                pSqlParameter[8] = new SqlParameter("@Email", SqlDbType.VarChar);
                pSqlParameter[8].Direction = ParameterDirection.Input;
                pSqlParameter[8].Value = objCustomerBo.Email;

                pSqlParameter[9] = new SqlParameter("@Remarks", SqlDbType.VarChar);
                pSqlParameter[9].Direction = ParameterDirection.Input;
                pSqlParameter[9].Value = objCustomerBo.Remarks;

                pSqlParameter[10] = new SqlParameter("@CreatedByID", SqlDbType.Int);
                pSqlParameter[10].Direction = ParameterDirection.Input;
                pSqlParameter[10].Value = objCustomerBo.CreatedByID;

                pSqlParameter[11] = new SqlParameter("@CreatedByDate", SqlDbType.DateTime);
                pSqlParameter[11].Direction = ParameterDirection.Input;
                pSqlParameter[11].Value = objCustomerBo.CreatedByDate;

                sSql = "usp_tbl_Customer_Insert";
                int iResult = Database.ExecuteNonQuery(CommandType.StoredProcedure, sSql, pSqlParameter);

                if (iResult > 0)
                {
                    ApplicationResult objResults = new ApplicationResult();
                    objResults.Status = ApplicationResult.CommonStatusType.Success;
                    return objResults;
                }
                else
                {
                    ApplicationResult objResults = new ApplicationResult();
                    objResults.Status = ApplicationResult.CommonStatusType.Failure;
                    return objResults;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objCustomerBo = null;
            }
        }
        #endregion

        #region Update Customer Details
        /// <summary>
        /// To Update details of Customer in Customer table
        /// Created By : Vishal, 12/11/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult Customer_Update(CustomerBO objCustomerBo)
        {
            try
            {
                pSqlParameter = new SqlParameter[13];


                pSqlParameter[0] = new SqlParameter("@CustomerID", SqlDbType.Int);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = objCustomerBo.CustomerID;

                pSqlParameter[1] = new SqlParameter("@CustomerCode", SqlDbType.VarChar);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = objCustomerBo.CustomerCode;

                pSqlParameter[2] = new SqlParameter("@CustomerName", SqlDbType.VarChar);
                pSqlParameter[2].Direction = ParameterDirection.Input;
                pSqlParameter[2].Value = objCustomerBo.CustomerName;

                pSqlParameter[3] = new SqlParameter("@Address", SqlDbType.VarChar);
                pSqlParameter[3].Direction = ParameterDirection.Input;
                pSqlParameter[3].Value = objCustomerBo.Address;

                pSqlParameter[4] = new SqlParameter("@City", SqlDbType.VarChar);
                pSqlParameter[4].Direction = ParameterDirection.Input;
                pSqlParameter[4].Value = objCustomerBo.City;

                pSqlParameter[5] = new SqlParameter("@District", SqlDbType.VarChar);
                pSqlParameter[5].Direction = ParameterDirection.Input;
                pSqlParameter[5].Value = objCustomerBo.District;

                pSqlParameter[6] = new SqlParameter("@State", SqlDbType.VarChar);
                pSqlParameter[6].Direction = ParameterDirection.Input;
                pSqlParameter[6].Value = objCustomerBo.State;

                pSqlParameter[7] = new SqlParameter("@Country", SqlDbType.VarChar);
                pSqlParameter[7].Direction = ParameterDirection.Input;
                pSqlParameter[7].Value = objCustomerBo.Country;

                pSqlParameter[8] = new SqlParameter("@Phone", SqlDbType.VarChar);
                pSqlParameter[8].Direction = ParameterDirection.Input;
                pSqlParameter[8].Value = objCustomerBo.Phone;

                pSqlParameter[9] = new SqlParameter("@Email", SqlDbType.VarChar);
                pSqlParameter[9].Direction = ParameterDirection.Input;
                pSqlParameter[9].Value = objCustomerBo.Email;

                pSqlParameter[10] = new SqlParameter("@Remarks", SqlDbType.VarChar);
                pSqlParameter[10].Direction = ParameterDirection.Input;
                pSqlParameter[10].Value = objCustomerBo.Remarks;

                pSqlParameter[11] = new SqlParameter("@LastModifiedByID", SqlDbType.Int);
                pSqlParameter[11].Direction = ParameterDirection.Input;
                pSqlParameter[11].Value = objCustomerBo.LastModifiedByID;

                pSqlParameter[12] = new SqlParameter("@LastModifiedByDate", SqlDbType.DateTime);
                pSqlParameter[12].Direction = ParameterDirection.Input;
                pSqlParameter[12].Value = objCustomerBo.LastModifiedByDate;

                sSql = "usp_tbl_Customer_Update";

                int iResult = Database.ExecuteNonQuery(CommandType.StoredProcedure, sSql, pSqlParameter);

                if (iResult > 0)
                {
                    ApplicationResult objResults = new ApplicationResult();
                    objResults.Status = ApplicationResult.CommonStatusType.Success;
                    return objResults;
                }
                else
                {
                    ApplicationResult objResults = new ApplicationResult();
                    objResults.Status = ApplicationResult.CommonStatusType.Failure;
                    return objResults;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objCustomerBo = null;
            }
        }
        #endregion

        #region ValidateName for Customer
        /// <summary>
        /// Function which validates whether the CustomerName already exits in Customer table.
        /// Created By : Vishal, 12/11/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult Customer_ValidateName(string strName)
        {
            try
            {
                pSqlParameter = new SqlParameter[1];

                pSqlParameter[0] = new SqlParameter("@Name", SqlDbType.VarChar);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = strName;

                strStoredProcName = "usp_tbl_Customer_ValidateName";

                DataTable dtResult = new DataTable();
                dtResult = Database.ExecuteDataTable(CommandType.StoredProcedure, strStoredProcName, pSqlParameter);
                ApplicationResult objResults = new ApplicationResult(dtResult);
                objResults.Status = ApplicationResult.CommonStatusType.Success;
                return objResults;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
    }
}
