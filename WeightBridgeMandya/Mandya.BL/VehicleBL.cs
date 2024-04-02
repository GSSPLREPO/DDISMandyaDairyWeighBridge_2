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
    public class VehicleBL
    {
        #region user defined variables
        public string sSql;
        public string strStoredProcName;
        public SqlParameter[] pSqlParameter = null;
        #endregion



        #region Select All Vehicle Details
        /// <summary>
        /// To Select All data from the Vehicle table
        /// Created By : Vishal, 11/16/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult Vehicle_SelectAll()
        {
            try
            {
                sSql = "usp_tbl_Vehicle_SelectAll";
                DataTable dtVehicle = new DataTable();
                dtVehicle = Database.ExecuteDataTable(CommandType.StoredProcedure, sSql, null);

                ApplicationResult objResults = new ApplicationResult(dtVehicle);
                objResults.Status = ApplicationResult.CommonStatusType.Success;
                return objResults;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region Select All Vehicle Details
        /// <summary>
        /// To Select All data from the Vehicle table
        /// Created By : Vishal, 11/16/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult Vehicle_SelectAll_ForUtilization()
        {
            try
            {
                sSql = "usp_tbl_Vehicle_SelectAll_ForUtilization";
                DataTable dtVehicle = new DataTable();
                dtVehicle = Database.ExecuteDataTable(CommandType.StoredProcedure, sSql, null);

                ApplicationResult objResults = new ApplicationResult(dtVehicle);
                objResults.Status = ApplicationResult.CommonStatusType.Success;
                return objResults;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion


        #region Select All Latest VehicleCode
        /// <summary>
        /// To Select All data from the Vehicle table
        /// Created By : Vishal, 11/16/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult Select_GenerateVehicleCode()
        {
            try
            {
                sSql = "usp_tbl_Vehicle_Generate_VehicleCode";
                DataTable dtResult = new DataTable();
                dtResult = Database.ExecuteDataTable(CommandType.StoredProcedure, sSql, null);

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

        #region Select Vehicle Details by VehicleId
        /// <summary>
        /// Select all details of Vehicle for selected VehicleId from Vehicle table
        /// Created By : Vishal, 11/16/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult Vehicle_Select(int intVehicleId)
        {
            try
            {
                pSqlParameter = new SqlParameter[1];

                pSqlParameter[0] = new SqlParameter("@VehicleId", SqlDbType.Int);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = intVehicleId;

                strStoredProcName = "usp_tbl_Vehicle_Select";

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

        #region Select Vehicle Details by VehicleId for Contractor
        /// <summary>
        /// Select all details of Vehicle for selected VehicleId from Vehicle table
        /// Created By : Vishal, 11/16/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult Vehicle_Select_ForContractor(int intContractorId)
        {
            try
            {
                pSqlParameter = new SqlParameter[1];

                pSqlParameter[0] = new SqlParameter("@ContractorCode", SqlDbType.Int);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = intContractorId;

                strStoredProcName = "usp_tbl_Vehicle_Select_ForContractor";

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

        #region Select Vehicle Details by By VehicleNumber
        /// <summary>
        /// Select all details of Vehicle for selected VehicleId from Vehicle table
        /// Created By : Vishal, 11/16/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult Vehicle_Select_ByVehicleNumber(string strVehicleNumber, int intMode)
        {
            try
            {
                pSqlParameter = new SqlParameter[2];

                pSqlParameter[0] = new SqlParameter("@TankerNo", SqlDbType.VarChar);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = strVehicleNumber;

                pSqlParameter[1] = new SqlParameter("@Mode", SqlDbType.Int);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = intMode;

                strStoredProcName = "usp_tbl_Vehicle_Select_ByVehicleNumber";

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

        #region Delete Vehicle Details by VehicleId
        /// <summary>
        /// To Delete details of Vehicle for selected VehicleId from Vehicle table
        /// Created By : Vishal, 11/16/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult Vehicle_Delete(int intVehicleId, int intLastModifiedBy, string strLastModifiedDate)
        {
            try
            {
                pSqlParameter = new SqlParameter[3];

                pSqlParameter[0] = new SqlParameter("@VehicleId", SqlDbType.Int);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = intVehicleId;

                pSqlParameter[1] = new SqlParameter("@LastModifiedBy", SqlDbType.Int);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = intLastModifiedBy;

                pSqlParameter[2] = new SqlParameter("@LastModifiedDate", SqlDbType.VarChar);
                pSqlParameter[2].Direction = ParameterDirection.Input;
                pSqlParameter[2].Value = strLastModifiedDate;

                strStoredProcName = "usp_tbl_Vehicle_Delete";

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

        #region Insert Vehicle Details
        /// <summary>
        /// To Insert details of Vehicle in Vehicle table
        /// Created By : Vishal, 11/16/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult Vehicle_Insert(VehicleBO objVehicleBo)
        {
            try
            {
                pSqlParameter = new SqlParameter[11];


                pSqlParameter[0] = new SqlParameter("@VehicleNumber", SqlDbType.VarChar);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = objVehicleBo.VehicleNumber;

                pSqlParameter[1] = new SqlParameter("@VehicleType", SqlDbType.Int);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = objVehicleBo.VehicleType;

                pSqlParameter[2] = new SqlParameter("@Capacity", SqlDbType.Int);
                pSqlParameter[2].Direction = ParameterDirection.Input;
                pSqlParameter[2].Value = objVehicleBo.Capacity;

                pSqlParameter[3] = new SqlParameter("@DriverName", SqlDbType.VarChar);
                pSqlParameter[3].Direction = ParameterDirection.Input;
                pSqlParameter[3].Value = objVehicleBo.DriverName;

                pSqlParameter[4] = new SqlParameter("@Compartments", SqlDbType.Int);
                pSqlParameter[4].Direction = ParameterDirection.Input;
                pSqlParameter[4].Value = objVehicleBo.Compartments;

                pSqlParameter[5] = new SqlParameter("@Remarks", SqlDbType.VarChar);
                pSqlParameter[5].Direction = ParameterDirection.Input;
                pSqlParameter[5].Value = objVehicleBo.Remarks;

                pSqlParameter[6] = new SqlParameter("@CreatedBy", SqlDbType.Int);
                pSqlParameter[6].Direction = ParameterDirection.Input;
                pSqlParameter[6].Value = objVehicleBo.CreatedBy;

                pSqlParameter[7] = new SqlParameter("@CreatedDate", SqlDbType.VarChar);
                pSqlParameter[7].Direction = ParameterDirection.Input;
                pSqlParameter[7].Value = objVehicleBo.CreatedDate;

                pSqlParameter[8] = new SqlParameter("@TareWeight", SqlDbType.Float);
                pSqlParameter[8].Direction = ParameterDirection.Input;
                pSqlParameter[8].Value = objVehicleBo.TareWeight;

                pSqlParameter[9] = new SqlParameter("@RouteID", SqlDbType.Int);
                pSqlParameter[9].Direction = ParameterDirection.Input;
                pSqlParameter[9].Value = objVehicleBo.RouteID;

                pSqlParameter[10] = new SqlParameter("@IsActive", SqlDbType.Int);
                pSqlParameter[10].Direction = ParameterDirection.Input;
                pSqlParameter[10].Value = objVehicleBo.IsActive;

                sSql = "usp_tbl_Vehicle_Insert";

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
                objVehicleBo = null;
            }
        }
        #endregion

        #region Update Vehicle Details
        /// <summary>
        /// To Update details of Vehicle in Vehicle table
        /// Created By : Vishal, 11/16/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult Vehicle_Update(VehicleBO objVehicleBo)
        {
            try
            {
                pSqlParameter = new SqlParameter[11];


                pSqlParameter[0] = new SqlParameter("@VehicleId", SqlDbType.Int);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = objVehicleBo.VehicleId;

                pSqlParameter[1] = new SqlParameter("@VehicleNumber", SqlDbType.VarChar);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = objVehicleBo.VehicleNumber;

                pSqlParameter[2] = new SqlParameter("@VehicleType", SqlDbType.Int);
                pSqlParameter[2].Direction = ParameterDirection.Input;
                pSqlParameter[2].Value = objVehicleBo.VehicleType;

                pSqlParameter[3] = new SqlParameter("@Capacity", SqlDbType.Int);
                pSqlParameter[3].Direction = ParameterDirection.Input;
                pSqlParameter[3].Value = objVehicleBo.Capacity;

                pSqlParameter[4] = new SqlParameter("@DriverName", SqlDbType.VarChar);
                pSqlParameter[4].Direction = ParameterDirection.Input;
                pSqlParameter[4].Value = objVehicleBo.DriverName;

                pSqlParameter[5] = new SqlParameter("@Compartments", SqlDbType.Int);
                pSqlParameter[5].Direction = ParameterDirection.Input;
                pSqlParameter[5].Value = objVehicleBo.Compartments;

                pSqlParameter[6] = new SqlParameter("@Remarks", SqlDbType.VarChar);
                pSqlParameter[6].Direction = ParameterDirection.Input;
                pSqlParameter[6].Value = objVehicleBo.Remarks;

                pSqlParameter[7] = new SqlParameter("@LastModifiedBy", SqlDbType.VarChar);
                pSqlParameter[7].Direction = ParameterDirection.Input;
                pSqlParameter[7].Value = objVehicleBo.LastModifiedBy;

                pSqlParameter[8] = new SqlParameter("@LastModifiedDate", SqlDbType.VarChar);
                pSqlParameter[8].Direction = ParameterDirection.Input;
                pSqlParameter[8].Value = objVehicleBo.LastModifiedDate;

                pSqlParameter[9] = new SqlParameter("@TareWeight", SqlDbType.Float);
                pSqlParameter[9].Direction = ParameterDirection.Input;
                pSqlParameter[9].Value = objVehicleBo.TareWeight;

                pSqlParameter[10] = new SqlParameter("@RouteID", SqlDbType.Int);
                pSqlParameter[10].Direction = ParameterDirection.Input;
                pSqlParameter[10].Value = objVehicleBo.RouteID;


                sSql = "usp_tbl_Vehicle_Update";

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
                objVehicleBo = null;
            }
        }
        #endregion

        #region ValidateName for Vehicle
        /// <summary>
        /// Function which validates whether the VehicleName already exits in Vehicle table.
        /// Created By : Vishal, 11/16/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult Vehicle_ValidateName(string strTankerNo)
        {
            try
            {
                pSqlParameter = new SqlParameter[1];

                pSqlParameter[0] = new SqlParameter("@TankerNo", SqlDbType.VarChar);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = strTankerNo;

                strStoredProcName = "usp_tbl_Vehicle_ValidateName";

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
