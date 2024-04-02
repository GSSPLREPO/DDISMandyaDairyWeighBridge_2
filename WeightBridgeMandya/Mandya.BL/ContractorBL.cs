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
    /// <summary>
    /// Class Created By : Vishal, 11/16/2015
    /// Summary description for Organisation.
    /// </summary>
    public class ContractorBL
    {
        
        #region user defined variables
        public string sSql;
        public string strStoredProcName;
        public SqlParameter[] pSqlParameter = null;
        #endregion



        #region Select All Contractor Details
        /// <summary>
        /// To Select All data from the Contractor table
        /// Created By : Vishal, 11/16/2015
        /// Modified By :
        /// </summary>
        [Obsolete]
        public ApplicationResult Contractor_SelectAll()
        {
            try
            {
                sSql = "usp_tbl_Contractor_SelectAll";
                DataTable dtContractor = new DataTable();
                dtContractor = Database.ExecuteDataTable(CommandType.StoredProcedure, sSql, null);

                ApplicationResult objResults = new ApplicationResult(dtContractor);
                objResults.Status = ApplicationResult.CommonStatusType.Success;
                return objResults;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion



        #region Select All Contractor Details
        /// <summary>
        /// To Select All data from the Contractor table
        /// Created By : Vishal, 11/16/2015
        /// Modified By :
        /// </summary>
        [Obsolete]
        public ApplicationResult Contractor_SelectAll_ForContractorSearch(string strContractorName)
        {
            try
            {
                pSqlParameter = new SqlParameter[1];

                pSqlParameter[0] = new SqlParameter("@ContractorName", SqlDbType.VarChar);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = strContractorName;

                sSql = "usp_tbl_Contractor_SelectAll_ForContractor_Search";
                DataTable dtContractor = new DataTable();
                dtContractor = Database.ExecuteDataTable(CommandType.StoredProcedure, sSql, pSqlParameter);

                ApplicationResult objResults = new ApplicationResult(dtContractor);
                objResults.Status = ApplicationResult.CommonStatusType.Success;
                return objResults;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion



        #region Select Contractor Details by ContractorId
        /// <summary>
        /// Select all details of Contractor for selected ContractorId from Contractor table
        /// Created By : Vishal, 11/16/2015
        /// Modified By :
        /// </summary>
        [Obsolete]
        public ApplicationResult Contractor_Select(int intContractorId)
        {
            try
            {
                pSqlParameter = new SqlParameter[1];

                pSqlParameter[0] = new SqlParameter("@ContractorId", SqlDbType.Int);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = intContractorId;

                strStoredProcName = "usp_tbl_Contractor_Select";

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



        #region Delete Contractor Details by ContractorId
        /// <summary>
        /// To Delete details of Contractor for selected ContractorId from Contractor table
        /// Created By : Vishal, 11/16/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult Contractor_Delete(int intContractorId, int intLastModifiedBy, string strLastModifiedDate)
        {
            try
            {
                pSqlParameter = new SqlParameter[3];

                pSqlParameter[0] = new SqlParameter("@ContractorId", SqlDbType.Int);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = intContractorId;

                pSqlParameter[1] = new SqlParameter("@LastModifiedBy", SqlDbType.Int);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = intLastModifiedBy;

                pSqlParameter[2] = new SqlParameter("@LastModifiedDate", SqlDbType.VarChar);
                pSqlParameter[2].Direction = ParameterDirection.Input;
                pSqlParameter[2].Value = strLastModifiedDate;

                strStoredProcName = "usp_tbl_Contractor_Delete";

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



        #region Insert Contractor Details
        /// <summary>
        /// To Insert details of Contractor in Contractor table
        /// Created By : Vishal, 11/16/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult Contractor_Insert(ContractorBO objContractorBo)
        {
            try
            {
                pSqlParameter = new SqlParameter[14];

              
                pSqlParameter[0] = new SqlParameter("@ContractorName", SqlDbType.VarChar);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = objContractorBo.ContractorName;

                pSqlParameter[1] = new SqlParameter("@Address", SqlDbType.VarChar);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = objContractorBo.Address;

                pSqlParameter[2] = new SqlParameter("@City", SqlDbType.VarChar);
                pSqlParameter[2].Direction = ParameterDirection.Input;
                pSqlParameter[2].Value = objContractorBo.City;

                pSqlParameter[3] = new SqlParameter("@State", SqlDbType.VarChar);
                pSqlParameter[3].Direction = ParameterDirection.Input;
                pSqlParameter[3].Value = objContractorBo.State;

                pSqlParameter[4] = new SqlParameter("@Phone", SqlDbType.VarChar);
                pSqlParameter[4].Direction = ParameterDirection.Input;
                pSqlParameter[4].Value = objContractorBo.Phone;

                pSqlParameter[5] = new SqlParameter("@Email", SqlDbType.VarChar);
                pSqlParameter[5].Direction = ParameterDirection.Input;
                pSqlParameter[5].Value = objContractorBo.Email;

                pSqlParameter[6] = new SqlParameter("@AliasName", SqlDbType.VarChar);
                pSqlParameter[6].Direction = ParameterDirection.Input;
                pSqlParameter[6].Value = objContractorBo.AliasName;

                pSqlParameter[7] = new SqlParameter("@Remarks", SqlDbType.VarChar);
                pSqlParameter[7].Direction = ParameterDirection.Input;
                pSqlParameter[7].Value = objContractorBo.Remarks;

                pSqlParameter[8] = new SqlParameter("@CreatedBy", SqlDbType.Int);
                pSqlParameter[8].Direction = ParameterDirection.Input;
                pSqlParameter[8].Value = objContractorBo.CreatedBy;

                pSqlParameter[9] = new SqlParameter("@CreatedDate", SqlDbType.VarChar);
                pSqlParameter[9].Direction = ParameterDirection.Input;
                pSqlParameter[9].Value = objContractorBo.CreatedDate;

                pSqlParameter[10] = new SqlParameter("@LastModifiedBy", SqlDbType.Int);
                pSqlParameter[10].Direction = ParameterDirection.Input;
                pSqlParameter[10].Value = objContractorBo.LastModifiedBy;

                pSqlParameter[11] = new SqlParameter("@LastModifiedDate", SqlDbType.VarChar);
                pSqlParameter[11].Direction = ParameterDirection.Input;
                pSqlParameter[11].Value = objContractorBo.LastModifiedDate;

                pSqlParameter[12] = new SqlParameter("@IsDeleted", SqlDbType.Int);
                pSqlParameter[12].Direction = ParameterDirection.Input;
                pSqlParameter[12].Value = objContractorBo.IsDeleted;

                pSqlParameter[13] = new SqlParameter("@ContractorCode", SqlDbType.VarChar);
                pSqlParameter[13].Direction = ParameterDirection.Input;
                pSqlParameter[13].Value = objContractorBo.ContractorCode;



                sSql = "usp_tbl_Contractor_Insert";
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
                objContractorBo = null;
            }
        }
        #endregion



        #region Update Contractor Details
        /// <summary>
        /// To Update details of Contractor in Contractor table
        /// Created By : Vishal, 11/16/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult Contractor_Update(ContractorBO objContractorBo)
        {
            try
            {
                pSqlParameter = new SqlParameter[15];


                pSqlParameter[0] = new SqlParameter("@ContractorId", SqlDbType.Int);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = objContractorBo.ContractorId;

                pSqlParameter[1] = new SqlParameter("@ContractorCode", SqlDbType.VarChar);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = objContractorBo.ContractorCode;

                pSqlParameter[2] = new SqlParameter("@ContractorName", SqlDbType.VarChar);
                pSqlParameter[2].Direction = ParameterDirection.Input;
                pSqlParameter[2].Value = objContractorBo.ContractorName;

                pSqlParameter[3] = new SqlParameter("@Address", SqlDbType.VarChar);
                pSqlParameter[3].Direction = ParameterDirection.Input;
                pSqlParameter[3].Value = objContractorBo.Address;

                pSqlParameter[4] = new SqlParameter("@City", SqlDbType.VarChar);
                pSqlParameter[4].Direction = ParameterDirection.Input;
                pSqlParameter[4].Value = objContractorBo.City;

                pSqlParameter[5] = new SqlParameter("@State", SqlDbType.VarChar);
                pSqlParameter[5].Direction = ParameterDirection.Input;
                pSqlParameter[5].Value = objContractorBo.State;

                pSqlParameter[6] = new SqlParameter("@Phone", SqlDbType.VarChar);
                pSqlParameter[6].Direction = ParameterDirection.Input;
                pSqlParameter[6].Value = objContractorBo.Phone;

                pSqlParameter[7] = new SqlParameter("@Email", SqlDbType.VarChar);
                pSqlParameter[7].Direction = ParameterDirection.Input;
                pSqlParameter[7].Value = objContractorBo.Email;

                pSqlParameter[8] = new SqlParameter("@AliasName", SqlDbType.VarChar);
                pSqlParameter[8].Direction = ParameterDirection.Input;
                pSqlParameter[8].Value = objContractorBo.AliasName;

                pSqlParameter[9] = new SqlParameter("@Remarks", SqlDbType.VarChar);
                pSqlParameter[9].Direction = ParameterDirection.Input;
                pSqlParameter[9].Value = objContractorBo.Remarks;

                pSqlParameter[10] = new SqlParameter("@CreatedBy", SqlDbType.Int);
                pSqlParameter[10].Direction = ParameterDirection.Input;
                pSqlParameter[10].Value = objContractorBo.CreatedBy;

                pSqlParameter[11] = new SqlParameter("@CreatedDate", SqlDbType.VarChar);
                pSqlParameter[11].Direction = ParameterDirection.Input;
                pSqlParameter[11].Value = objContractorBo.CreatedDate;

                pSqlParameter[12] = new SqlParameter("@LastModifiedBy", SqlDbType.VarChar);
                pSqlParameter[12].Direction = ParameterDirection.Input;
                pSqlParameter[12].Value = objContractorBo.LastModifiedBy;

                pSqlParameter[13] = new SqlParameter("@LastModifiedDate", SqlDbType.VarChar);
                pSqlParameter[13].Direction = ParameterDirection.Input;
                pSqlParameter[13].Value = objContractorBo.LastModifiedDate;

                pSqlParameter[14] = new SqlParameter("@IsDeleted", SqlDbType.Int);
                pSqlParameter[14].Direction = ParameterDirection.Input;
                pSqlParameter[14].Value = objContractorBo.IsDeleted;


                sSql = "usp_tbl_Contractor_Update";

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
                objContractorBo = null;
            }
        }
        #endregion



        #region ValidateName for Contractor
        /// <summary>
        /// Function which validates whether the ContractorName already exits in Contractor table.
        /// Created By : Vishal, 11/16/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult Contractor_ValidateName(int intContractorId, string strName)
        {
            try
            {
                pSqlParameter = new SqlParameter[2];

                pSqlParameter[0] = new SqlParameter("@ContractorId", SqlDbType.Int);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = intContractorId;

                pSqlParameter[1] = new SqlParameter("@ContractorCode", SqlDbType.VarChar);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = strName;

                strStoredProcName = "usp_tbl_Contractor_ValidateName";

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
