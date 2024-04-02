using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mandya.BO;
using Mandya.Common;
using Mandya.DataAccess;

namespace Mandya.BL
{
   public class TerminalBL
    {
        #region user defined variables
        public string sSql;
        public string strStoredProcName;
        public SqlParameter[] pSqlParameter = null;
        #endregion



        #region Select All WeighBridgeBL Details
        /// <summary>
        /// To Select All data from the Terminal_M table
        /// Created By : Vishal, 11/4/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult WeighBridgeBL_SelectAll()
        {
            try
            {
                sSql = "usp_tbl_Terminal_M_SelectAll";
                DataTable dtWeighBridgeBL = new DataTable();
                dtWeighBridgeBL = Database.ExecuteDataTable(CommandType.StoredProcedure, sSql, null);

                ApplicationResult objResults = new ApplicationResult(dtWeighBridgeBL);
                objResults.Status = ApplicationResult.CommonStatusType.Success;
                return objResults;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion



        #region Select WeighBridgeBL Details by TerminalId
        /// <summary>
        /// Select all details of WeighBridgeBL for selected TerminalId from Terminal_M table
        /// Created By : Vishal, 11/4/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult WeighBridgeBL_Select(int intTerminalId)
        {
            try
            {
                pSqlParameter = new SqlParameter[1];

                pSqlParameter[0] = new SqlParameter("@TerminalId", SqlDbType.Int);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = intTerminalId;

                strStoredProcName = "usp_tbl_Terminal_M_Select";

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



        #region Delete WeighBridgeBL Details by TerminalId
        /// <summary>
        /// To Delete details of WeighBridgeBL for selected TerminalId from Terminal_M table
        /// Created By : Vishal, 11/4/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult WeighBridgeBL_Delete(int intTerminalId, int intLastModifiedBy, string strLastModifiedDate)
        {
            try
            {
                pSqlParameter = new SqlParameter[3];

                pSqlParameter[0] = new SqlParameter("@TerminalId", SqlDbType.Int);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = intTerminalId;

                pSqlParameter[1] = new SqlParameter("@LastModifiedBy", SqlDbType.Int);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = intLastModifiedBy;

                pSqlParameter[2] = new SqlParameter("@LastModifiedDate", SqlDbType.VarChar);
                pSqlParameter[2].Direction = ParameterDirection.Input;
                pSqlParameter[2].Value = strLastModifiedDate;

                strStoredProcName = "usp_tbl_Terminal_M_Delete";

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



        #region Insert WeighBridgeBL Details
        /// <summary>
        /// To Insert details of WeighBridgeBL in Terminal_M table
        /// Created By : Vishal, 11/4/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult WeighBridgeBL_Insert(TerminalBO objWeighBridgeBo)
        {
            try
            {
                pSqlParameter = new SqlParameter[3];


                pSqlParameter[0] = new SqlParameter("@TerminalName", SqlDbType.VarChar);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = objWeighBridgeBo.TerminalName;

                pSqlParameter[1] = new SqlParameter("@Inlet", SqlDbType.Bit);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = objWeighBridgeBo.Inlet;

                pSqlParameter[2] = new SqlParameter("@Outlet", SqlDbType.Bit);
                pSqlParameter[2].Direction = ParameterDirection.Input;
                pSqlParameter[2].Value = objWeighBridgeBo.Outlet;


                sSql = "usp_tbl_Terminal_M_Insert";
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
                objWeighBridgeBo = null;
            }
        }
        #endregion



        #region Update WeighBridgeBL Details
        /// <summary>
        /// To Update details of WeighBridgeBL in Terminal_M table
        /// Created By : Vishal, 11/4/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult WeighBridgeBL_Update(TerminalBO objWeighBridgeBo)
        {
            try
            {
                pSqlParameter = new SqlParameter[4];


                pSqlParameter[0] = new SqlParameter("@TerminalId", SqlDbType.Int);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = objWeighBridgeBo.TerminalId;

                pSqlParameter[1] = new SqlParameter("@TerminalName", SqlDbType.VarChar);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = objWeighBridgeBo.TerminalName;

                pSqlParameter[2] = new SqlParameter("@Inlet", SqlDbType.Bit);
                pSqlParameter[2].Direction = ParameterDirection.Input;
                pSqlParameter[2].Value = objWeighBridgeBo.Inlet;

                pSqlParameter[3] = new SqlParameter("@Outlet", SqlDbType.Bit);
                pSqlParameter[3].Direction = ParameterDirection.Input;
                pSqlParameter[3].Value = objWeighBridgeBo.Outlet;


                sSql = "usp_tbl_Terminal_M_Update";

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
                objWeighBridgeBo = null;
            }
        }
        #endregion



        #region ValidateName for WeighBridgeBL
        /// <summary>
        /// Function which validates whether the WeighBridgeBLName already exits in Terminal_M table.
        /// Created By : Vishal, 11/4/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult WeighBridgeBL_ValidateName(int intWeighBridgeBLId, string strName)
        {
            try
            {
                pSqlParameter = new SqlParameter[2];

                pSqlParameter[0] = new SqlParameter("@WeighBridgeBLId", SqlDbType.Int);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = intWeighBridgeBLId;

                pSqlParameter[1] = new SqlParameter("@Name", SqlDbType.VarChar);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = strName;

                strStoredProcName = "usp_tbl_Terminal_M_ValidateName";

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
