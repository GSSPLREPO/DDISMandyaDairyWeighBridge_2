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
    public class WeighBridgeBL
    {
        #region user defined variables
        public string sSql;
        public string strStoredProcName;
        public SqlParameter[] pSqlParameter = null;
        #endregion
        
        #region Select All WeighBridge Details
        /// <summary>
        /// To Select All data from the WeighBridge table
        /// Created By : VIshal, 11/17/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult WeighBridge_SelectAll()
        {
            try
            {
                sSql = "usp_tbl_WeighBridge_SelectAll";
                DataTable dtWeighBridge = new DataTable();
                dtWeighBridge = Database.ExecuteDataTable(CommandType.StoredProcedure, sSql, null);

                ApplicationResult objResults = new ApplicationResult(dtWeighBridge);
                objResults.Status = ApplicationResult.CommonStatusType.Success;
                return objResults;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        
        #region Select All WeighBridge Details by CurrentDate
        /// <summary>
        /// To Select All data from the WeighBridge table
        /// Created By : VIshal, 11/17/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult WeighBridge_SelectAll_ByDate()
        {
            try
            {
                sSql = "usp_tbl_WeighBridge_SelectAll_ByDate";
                DataTable dtWeighBridge = new DataTable();
                dtWeighBridge = Database.ExecuteDataTable(CommandType.StoredProcedure, sSql, null);

                ApplicationResult objResults = new ApplicationResult(dtWeighBridge);
                objResults.Status = ApplicationResult.CommonStatusType.Success;
                return objResults;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        
        #region Select WeighBridge Details by WeighBridgeId
        /// <summary>
        /// Select all details of WeighBridge for selected WeighBridgeId from WeighBridge table
        /// Created By : VIshal, 11/17/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult WeighBridge_Select(int intWeighBridgeId)
        {
            try
            {
                pSqlParameter = new SqlParameter[1];

                pSqlParameter[0] = new SqlParameter("@WeighBridgeId", SqlDbType.Int);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = intWeighBridgeId;

                strStoredProcName = "usp_tbl_WeighBridge_Select";

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
        
        #region Select WeighBridge Details by WeighBridgeId for Print Slip(Inlet Outlet)
        /// <summary>
        /// Select all details of WeighBridge for selected WeighBridgeId from WeighBridge table
        /// Created By : VIshal, 11/17/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult WeighBridge_Select_ForPrint(int intWeighBridgeId,int intPrintType)
        {
            try
            {
                pSqlParameter = new SqlParameter[2];

                pSqlParameter[0] = new SqlParameter("@WeighBridgeId", SqlDbType.Int);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = intWeighBridgeId;

                pSqlParameter[1] = new SqlParameter("@PrintType", SqlDbType.Int);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = intPrintType;

                strStoredProcName = "usp_tbl_WeighBridge_Select_ForPrint1";

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

        #region Select WeighBridge Details for Print Report(Tanker Utilization)
        /// <summary>
        /// Select all details of WeighBridge for selected WeighBridgeId from WeighBridge table
        /// Created By : VIshal, 11/17/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult WeighBridge_Select_For_TankerUtilization_Report_Print(string strVehicleNo, string strPurpose,string strFromDate,string strToDate)
        {
            try
            {
                pSqlParameter = new SqlParameter[4];

                pSqlParameter[0] = new SqlParameter("@VehicleNo", SqlDbType.VarChar);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = strVehicleNo;

                pSqlParameter[1] = new SqlParameter("@Purpose", SqlDbType.VarChar);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = strPurpose;

                pSqlParameter[2] = new SqlParameter("@FromDate", SqlDbType.VarChar);
                pSqlParameter[2].Direction = ParameterDirection.Input;
                pSqlParameter[2].Value = strFromDate;

                pSqlParameter[3] = new SqlParameter("@ToDate", SqlDbType.VarChar);
                pSqlParameter[3].Direction = ParameterDirection.Input;
                pSqlParameter[3].Value = strToDate;

                strStoredProcName = "usp_tbl_WeighBridge_SelectAll_For_TankerUtilization_Report";

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

        #region Select WeighBridge Details for Print Receipt(WB Receipts)
        /// <summary>
        /// Select all details of WeighBridge for selected WeighBridgeId from WeighBridge table
        /// Created By : VIshal, 11/17/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult WeighBridge_Select_For_Print(string strVehicleNo, string strPurpose, string strFromDate, string strToDate)
        {
            try
            {
                pSqlParameter = new SqlParameter[4];

                pSqlParameter[0] = new SqlParameter("@VehicleNo", SqlDbType.VarChar);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = strVehicleNo;

                pSqlParameter[1] = new SqlParameter("@Purpose", SqlDbType.VarChar);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = strPurpose;

                pSqlParameter[2] = new SqlParameter("@FromDate", SqlDbType.VarChar);
                pSqlParameter[2].Direction = ParameterDirection.Input;
                pSqlParameter[2].Value = strFromDate;

                pSqlParameter[3] = new SqlParameter("@ToDate", SqlDbType.VarChar);
                pSqlParameter[3].Direction = ParameterDirection.Input;
                pSqlParameter[3].Value = strToDate;

                strStoredProcName = "usp_tbl_Weighbridge_SelectAll_Print";

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
        
        #region Select WeighBridge Details for Print Report(Waiting Tanker Report)
        /// <summary>
        /// Select all details of WeighBridge for selected WeighBridgeId from WeighBridge table
        /// Created By : VIshal, 11/17/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult WeighBridge_Select_For_WaitingTanker_Report_Print(string strLocation, string strPurpose)
        {
            try
            {
                pSqlParameter = new SqlParameter[2];

                pSqlParameter[0] = new SqlParameter("@Location", SqlDbType.VarChar);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = strLocation;

                pSqlParameter[1] = new SqlParameter("@Purpose", SqlDbType.VarChar);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = strPurpose;

              
                strStoredProcName = "usp_tbl_WeighBridge_SelectAll_For_WaitingTanker_Report";

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

        #region Delete WeighBridge Details by WeighBridgeId
        /// <summary>
        /// To Delete details of WeighBridge for selected WeighBridgeId from WeighBridge table
        /// Created By : VIshal, 11/17/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult WeighBridge_Delete(int intWeighBridgeId, int intLastModifiedBy, string strLastModifiedDate)
        {
            try
            {
                pSqlParameter = new SqlParameter[3];

                pSqlParameter[0] = new SqlParameter("@WeighBridgeId", SqlDbType.Int);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = intWeighBridgeId;

                pSqlParameter[1] = new SqlParameter("@LastModifiedBy", SqlDbType.Int);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = intLastModifiedBy;

                pSqlParameter[2] = new SqlParameter("@LastModifiedDate", SqlDbType.VarChar);
                pSqlParameter[2].Direction = ParameterDirection.Input;
                pSqlParameter[2].Value = strLastModifiedDate;

                strStoredProcName = "usp_tbl_WeighBridge_Delete";

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
        
        //#region Insert WeighBridge Details
        ///// <summary>
        ///// To Insert details of WeighBridge in WeighBridge table
        ///// Created By : VIshal, 11/17/2015
        ///// Modified By :
        ///// </summary>
        //public ApplicationResult WeighBridge_Insert(WeighBridgeBO objWeighBridgeBo, string strVehicleNumber, string strDriverName, string strConductorName, string strRouteNo, string strVehicleId)
        //{
        //    try
        //    {
        //        pSqlParameter = new SqlParameter[35];

        //        //pSqlParameter[0] = new SqlParameter("@TerminalId", SqlDbType.Int);
        //        //pSqlParameter[0].Direction = ParameterDirection.Input;
        //        //pSqlParameter[0].Value = objWeighBridgeBo.TerminalId;

        //        pSqlParameter[0] = new SqlParameter("@TankerId", SqlDbType.VarChar);
        //        pSqlParameter[0].Direction = ParameterDirection.Input;
        //        pSqlParameter[0].Value = objWeighBridgeBo.TankerId;

        //        pSqlParameter[1] = new SqlParameter("@VehicleId", SqlDbType.Int);
        //        pSqlParameter[1].Direction = ParameterDirection.Input;
        //        pSqlParameter[1].Value = objWeighBridgeBo.VehicleId;

        //        pSqlParameter[2] = new SqlParameter("@ContractorId", SqlDbType.Int);
        //        pSqlParameter[2].Direction = ParameterDirection.Input;
        //        pSqlParameter[2].Value = objWeighBridgeBo.ContractorId;

        //        pSqlParameter[3] = new SqlParameter("@ChallanNo", SqlDbType.VarChar);
        //        pSqlParameter[3].Direction = ParameterDirection.Input;
        //        pSqlParameter[3].Value = objWeighBridgeBo.ChallanNo;

        //        pSqlParameter[4] = new SqlParameter("@Source", SqlDbType.VarChar);
        //        pSqlParameter[4].Direction = ParameterDirection.Input;
        //        pSqlParameter[4].Value = objWeighBridgeBo.Source;

        //        pSqlParameter[5] = new SqlParameter("@Destination", SqlDbType.VarChar);
        //        pSqlParameter[5].Direction = ParameterDirection.Input;
        //        pSqlParameter[5].Value = objWeighBridgeBo.Destination;

        //        pSqlParameter[6] = new SqlParameter("@Purpose", SqlDbType.VarChar);
        //        pSqlParameter[6].Direction = ParameterDirection.Input;
        //        pSqlParameter[6].Value = objWeighBridgeBo.Purpose;

        //        pSqlParameter[7] = new SqlParameter("@SupplierId", SqlDbType.Int);
        //        pSqlParameter[7].Direction = ParameterDirection.Input;
        //        pSqlParameter[7].Value = objWeighBridgeBo.SupplierId;

        //        pSqlParameter[8] = new SqlParameter("@ProductGroupId", SqlDbType.Int);
        //        pSqlParameter[8].Direction = ParameterDirection.Input;
        //        pSqlParameter[8].Value = objWeighBridgeBo.ProductGroupId;

        //        pSqlParameter[9] = new SqlParameter("@ProductId", SqlDbType.Int);
        //        pSqlParameter[9].Direction = ParameterDirection.Input;
        //        pSqlParameter[9].Value = objWeighBridgeBo.ProductId;

        //        pSqlParameter[10] = new SqlParameter("@RouteId", SqlDbType.Int);
        //        pSqlParameter[10].Direction = ParameterDirection.Input;
        //        pSqlParameter[10].Value = objWeighBridgeBo.RouteId;

        //        pSqlParameter[11] = new SqlParameter("@EntryType", SqlDbType.VarChar);
        //        pSqlParameter[11].Direction = ParameterDirection.Input;
        //        pSqlParameter[11].Value = objWeighBridgeBo.EntryType;

        //        pSqlParameter[12] = new SqlParameter("@TareWeight", SqlDbType.Decimal);
        //        pSqlParameter[12].Direction = ParameterDirection.Input;
        //        pSqlParameter[12].Value = objWeighBridgeBo.TareWeight;

        //        pSqlParameter[13] = new SqlParameter("@GrossWeight", SqlDbType.Decimal);
        //        pSqlParameter[13].Direction = ParameterDirection.Input;
        //        pSqlParameter[13].Value = objWeighBridgeBo.GrossWeight;

        //        pSqlParameter[14] = new SqlParameter("@NetWeight", SqlDbType.VarChar);
        //        pSqlParameter[14].Direction = ParameterDirection.Input;
        //        pSqlParameter[14].Value = objWeighBridgeBo.NetWeight;

        //        pSqlParameter[15] = new SqlParameter("@TWTDate", SqlDbType.VarChar);
        //        pSqlParameter[15].Direction = ParameterDirection.Input;
        //        pSqlParameter[15].Value = objWeighBridgeBo.TWTDate;

        //        pSqlParameter[16] = new SqlParameter("@GWTDate", SqlDbType.VarChar);
        //        pSqlParameter[16].Direction = ParameterDirection.Input;
        //        pSqlParameter[16].Value = objWeighBridgeBo.GWTDate;

        //        pSqlParameter[17] = new SqlParameter("@TWTTime", SqlDbType.VarChar);
        //        pSqlParameter[17].Direction = ParameterDirection.Input;
        //        pSqlParameter[17].Value = objWeighBridgeBo.TWTTime;

        //        pSqlParameter[18] = new SqlParameter("@GWTTime", SqlDbType.VarChar);
        //        pSqlParameter[18].Direction = ParameterDirection.Input;
        //        pSqlParameter[18].Value = objWeighBridgeBo.GWTTime;

        //        pSqlParameter[19] = new SqlParameter("@CIPStatus", SqlDbType.VarChar);
        //        pSqlParameter[19].Direction = ParameterDirection.Input;
        //        pSqlParameter[19].Value = objWeighBridgeBo.CIPStatus;

        //        pSqlParameter[20] = new SqlParameter("@CreatedBy", SqlDbType.Int);
        //        pSqlParameter[20].Direction = ParameterDirection.Input;
        //        pSqlParameter[20].Value = objWeighBridgeBo.CreatedBy;

        //        pSqlParameter[21] = new SqlParameter("@CreatedDate", SqlDbType.VarChar);
        //        pSqlParameter[21].Direction = ParameterDirection.Input;
        //        pSqlParameter[21].Value = objWeighBridgeBo.CreatedDate;

        //        pSqlParameter[22] = new SqlParameter("@LastModifiedBy", SqlDbType.Int);
        //        pSqlParameter[22].Direction = ParameterDirection.Input;
        //        pSqlParameter[22].Value = objWeighBridgeBo.LastModifiedBy;

        //        pSqlParameter[23] = new SqlParameter("@LastModifiedDate", SqlDbType.VarChar);
        //        pSqlParameter[23].Direction = ParameterDirection.Input;
        //        pSqlParameter[23].Value = objWeighBridgeBo.LastModifiedDate;

        //        pSqlParameter[24] = new SqlParameter("@IsDeleted", SqlDbType.Int);
        //        pSqlParameter[24].Direction = ParameterDirection.Input;
        //        pSqlParameter[24].Value = objWeighBridgeBo.IsDeleted;

        //        pSqlParameter[25] = new SqlParameter("@WeighType", SqlDbType.Int);
        //        pSqlParameter[25].Direction = ParameterDirection.Input;
        //        pSqlParameter[25].Value = objWeighBridgeBo.WeighType;

        //        pSqlParameter[26] = new SqlParameter("@Type", SqlDbType.Int);
        //        pSqlParameter[26].Direction = ParameterDirection.Input;
        //        pSqlParameter[26].Value = objWeighBridgeBo.Type;

        //        pSqlParameter[27] = new SqlParameter("@VehicleNumber", SqlDbType.VarChar);
        //        pSqlParameter[27].Direction = ParameterDirection.Input;
        //        pSqlParameter[27].Value = strVehicleNumber;

        //        pSqlParameter[28] = new SqlParameter("@DriverName", SqlDbType.VarChar);
        //        pSqlParameter[28].Direction = ParameterDirection.Input;
        //        pSqlParameter[28].Value = strDriverName;

        //        pSqlParameter[29] = new SqlParameter("@ConductorName", SqlDbType.VarChar);
        //        pSqlParameter[29].Direction = ParameterDirection.Input;
        //        pSqlParameter[29].Value = strConductorName;

        //        pSqlParameter[30] = new SqlParameter("@RouteNo", SqlDbType.VarChar);
        //        pSqlParameter[30].Direction = ParameterDirection.Input;
        //        pSqlParameter[30].Value = strRouteNo;

        //        pSqlParameter[31] = new SqlParameter("@Remark", SqlDbType.VarChar);
        //        pSqlParameter[31].Direction = ParameterDirection.Input;
        //        pSqlParameter[31].Value = objWeighBridgeBo.Remark;

        //        pSqlParameter[32] = new SqlParameter("@DateTime", SqlDbType.DateTime);
        //        pSqlParameter[32].Direction = ParameterDirection.Input;
        //        pSqlParameter[32].Value = objWeighBridgeBo.DateTime;

        //        pSqlParameter[33] = new SqlParameter("@GatePassNo", SqlDbType.VarChar);
        //        pSqlParameter[33].Direction = ParameterDirection.Input;
        //        pSqlParameter[33].Value = objWeighBridgeBo.GatePassNo;

        //        pSqlParameter[34] = new SqlParameter("@WeighbridgeNo", SqlDbType.VarChar);
        //        pSqlParameter[34].Direction = ParameterDirection.Input;
        //        pSqlParameter[34].Value = objWeighBridgeBo.WeighbridgeNo;

        //        sSql = "usp_tbl_WeighBridge_Insert";

        //        DataTable dtResult = new DataTable();
        //        dtResult = Database.ExecuteDataTable(CommandType.StoredProcedure, sSql, pSqlParameter);
        //        ApplicationResult objResults = new ApplicationResult(dtResult);
        //        objResults.Status = ApplicationResult.CommonStatusType.Success;
        //        return objResults;

        //        //int iResult = Database.ExecuteNonQuery(CommandType.StoredProcedure, sSql, pSqlParameter);

        //        //if (iResult > 0)
        //        //{
        //        //    ApplicationResult objResults = new ApplicationResult();
        //        //    objResults.Status = ApplicationResult.CommonStatusType.Success;
        //        //    return objResults;
        //        //}
        //        //else
        //        //{
        //        //    ApplicationResult objResults = new ApplicationResult();
        //        //    objResults.Status = ApplicationResult.CommonStatusType.Failure;
        //        //    return objResults;
        //        //}
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        objWeighBridgeBo = null;
        //    }
        //}
        //#endregion
        
        //#region Update WeighBridge Details
        ///// <summary>
        ///// To Update details of WeighBridge in WeighBridge table
        ///// Created By : VIshal, 11/17/2015
        ///// Modified By :
        ///// </summary>
        //public ApplicationResult WeighBridge_Update(WeighBridgeBO objWeighBridgeBo, string strVehicleNumber, string strDriverName, string strConductorName, string strRouteNo, string strVehicleId)
        //{
        //    try
        //    {
        //        pSqlParameter = new SqlParameter[35];

        //        pSqlParameter[0] = new SqlParameter("@TankerId", SqlDbType.VarChar);
        //        pSqlParameter[0].Direction = ParameterDirection.Input;
        //        pSqlParameter[0].Value = objWeighBridgeBo.TankerId;

        //        pSqlParameter[1] = new SqlParameter("@VehicleId", SqlDbType.Int);
        //        pSqlParameter[1].Direction = ParameterDirection.Input;
        //        pSqlParameter[1].Value = objWeighBridgeBo.VehicleId;

        //        pSqlParameter[2] = new SqlParameter("@ContractorId", SqlDbType.Int);
        //        pSqlParameter[2].Direction = ParameterDirection.Input;
        //        pSqlParameter[2].Value = objWeighBridgeBo.ContractorId;

        //        pSqlParameter[3] = new SqlParameter("@ChallanNo", SqlDbType.VarChar);
        //        pSqlParameter[3].Direction = ParameterDirection.Input;
        //        pSqlParameter[3].Value = objWeighBridgeBo.ChallanNo;

        //        pSqlParameter[4] = new SqlParameter("@Source", SqlDbType.VarChar);
        //        pSqlParameter[4].Direction = ParameterDirection.Input;
        //        pSqlParameter[4].Value = objWeighBridgeBo.Source;

        //        pSqlParameter[5] = new SqlParameter("@Destination", SqlDbType.VarChar);
        //        pSqlParameter[5].Direction = ParameterDirection.Input;
        //        pSqlParameter[5].Value = objWeighBridgeBo.Destination;

        //        pSqlParameter[6] = new SqlParameter("@Purpose", SqlDbType.VarChar);
        //        pSqlParameter[6].Direction = ParameterDirection.Input;
        //        pSqlParameter[6].Value = objWeighBridgeBo.Purpose;

        //        pSqlParameter[7] = new SqlParameter("@SupplierId", SqlDbType.Int);
        //        pSqlParameter[7].Direction = ParameterDirection.Input;
        //        pSqlParameter[7].Value = objWeighBridgeBo.SupplierId;

        //        pSqlParameter[8] = new SqlParameter("@ProductGroupId", SqlDbType.Int);
        //        pSqlParameter[8].Direction = ParameterDirection.Input;
        //        pSqlParameter[8].Value = objWeighBridgeBo.ProductGroupId;

        //        pSqlParameter[9] = new SqlParameter("@ProductId", SqlDbType.Int);
        //        pSqlParameter[9].Direction = ParameterDirection.Input;
        //        pSqlParameter[9].Value = objWeighBridgeBo.ProductId;

        //        pSqlParameter[10] = new SqlParameter("@RouteId", SqlDbType.Int);
        //        pSqlParameter[10].Direction = ParameterDirection.Input;
        //        pSqlParameter[10].Value = objWeighBridgeBo.RouteId;

        //        pSqlParameter[11] = new SqlParameter("@EntryType", SqlDbType.VarChar);
        //        pSqlParameter[11].Direction = ParameterDirection.Input;
        //        pSqlParameter[11].Value = objWeighBridgeBo.EntryType;

        //        pSqlParameter[12] = new SqlParameter("@TareWeight", SqlDbType.Decimal);
        //        pSqlParameter[12].Direction = ParameterDirection.Input;
        //        pSqlParameter[12].Value = objWeighBridgeBo.TareWeight;

        //        pSqlParameter[13] = new SqlParameter("@GrossWeight", SqlDbType.Decimal);
        //        pSqlParameter[13].Direction = ParameterDirection.Input;
        //        pSqlParameter[13].Value = objWeighBridgeBo.GrossWeight;

        //        pSqlParameter[14] = new SqlParameter("@NetWeight", SqlDbType.VarChar);
        //        pSqlParameter[14].Direction = ParameterDirection.Input;
        //        pSqlParameter[14].Value = objWeighBridgeBo.NetWeight;

        //        pSqlParameter[15] = new SqlParameter("@TWTDate", SqlDbType.VarChar);
        //        pSqlParameter[15].Direction = ParameterDirection.Input;
        //        pSqlParameter[15].Value = objWeighBridgeBo.TWTDate;

        //        pSqlParameter[16] = new SqlParameter("@GWTDate", SqlDbType.VarChar);
        //        pSqlParameter[16].Direction = ParameterDirection.Input;
        //        pSqlParameter[16].Value = objWeighBridgeBo.GWTDate;

        //        pSqlParameter[17] = new SqlParameter("@TWTTime", SqlDbType.VarChar);
        //        pSqlParameter[17].Direction = ParameterDirection.Input;
        //        pSqlParameter[17].Value = objWeighBridgeBo.TWTTime;

        //        pSqlParameter[18] = new SqlParameter("@GWTTime", SqlDbType.VarChar);
        //        pSqlParameter[18].Direction = ParameterDirection.Input;
        //        pSqlParameter[18].Value = objWeighBridgeBo.GWTTime;

        //        pSqlParameter[19] = new SqlParameter("@CIPStatus", SqlDbType.VarChar);
        //        pSqlParameter[19].Direction = ParameterDirection.Input;
        //        pSqlParameter[19].Value = objWeighBridgeBo.CIPStatus;

        //        pSqlParameter[20] = new SqlParameter("@CreatedBy", SqlDbType.Int);
        //        pSqlParameter[20].Direction = ParameterDirection.Input;
        //        pSqlParameter[20].Value = objWeighBridgeBo.CreatedBy;

        //        pSqlParameter[21] = new SqlParameter("@CreatedDate", SqlDbType.VarChar);
        //        pSqlParameter[21].Direction = ParameterDirection.Input;
        //        pSqlParameter[21].Value = objWeighBridgeBo.CreatedDate;

        //        pSqlParameter[22] = new SqlParameter("@LastModifiedBy", SqlDbType.Int);
        //        pSqlParameter[22].Direction = ParameterDirection.Input;
        //        pSqlParameter[22].Value = objWeighBridgeBo.LastModifiedBy;

        //        pSqlParameter[23] = new SqlParameter("@LastModifiedDate", SqlDbType.VarChar);
        //        pSqlParameter[23].Direction = ParameterDirection.Input;
        //        pSqlParameter[23].Value = objWeighBridgeBo.LastModifiedDate;

        //        pSqlParameter[24] = new SqlParameter("@IsDeleted", SqlDbType.Int);
        //        pSqlParameter[24].Direction = ParameterDirection.Input;
        //        pSqlParameter[24].Value = objWeighBridgeBo.IsDeleted;

        //        pSqlParameter[25] = new SqlParameter("@WeighType", SqlDbType.Int);
        //        pSqlParameter[25].Direction = ParameterDirection.Input;
        //        pSqlParameter[25].Value = objWeighBridgeBo.WeighType;

        //        pSqlParameter[26] = new SqlParameter("@Type", SqlDbType.Int);
        //        pSqlParameter[26].Direction = ParameterDirection.Input;
        //        pSqlParameter[26].Value = objWeighBridgeBo.Type;

        //        pSqlParameter[27] = new SqlParameter("@VehicleNumber", SqlDbType.VarChar);
        //        pSqlParameter[27].Direction = ParameterDirection.Input;
        //        pSqlParameter[27].Value = strVehicleNumber;

        //        pSqlParameter[28] = new SqlParameter("@DriverName", SqlDbType.VarChar);
        //        pSqlParameter[28].Direction = ParameterDirection.Input;
        //        pSqlParameter[28].Value = strDriverName;

        //        pSqlParameter[29] = new SqlParameter("@ConductorName", SqlDbType.VarChar);
        //        pSqlParameter[29].Direction = ParameterDirection.Input;
        //        pSqlParameter[29].Value = strConductorName;

        //        pSqlParameter[30] = new SqlParameter("@RouteNo", SqlDbType.VarChar);
        //        pSqlParameter[30].Direction = ParameterDirection.Input;
        //        pSqlParameter[30].Value = strRouteNo;

        //        pSqlParameter[31] = new SqlParameter("@Remark", SqlDbType.VarChar);
        //        pSqlParameter[31].Direction = ParameterDirection.Input;
        //        pSqlParameter[31].Value = objWeighBridgeBo.Remark;

        //        pSqlParameter[32] = new SqlParameter("@DateTime", SqlDbType.DateTime);
        //        pSqlParameter[32].Direction = ParameterDirection.Input;
        //        pSqlParameter[32].Value = objWeighBridgeBo.DateTime;

        //        //pSqlParameter[33] = new SqlParameter("@GatePassNo", SqlDbType.VarChar);
        //        //pSqlParameter[33].Direction = ParameterDirection.Input;
        //        //pSqlParameter[33].Value = objWeighBridgeBo.GatePassNo;

        //        pSqlParameter[33] = new SqlParameter("@WeighbridgeNo", SqlDbType.VarChar);
        //        pSqlParameter[33].Direction = ParameterDirection.Input;
        //        pSqlParameter[33].Value = objWeighBridgeBo.WeighbridgeNo;

        //        pSqlParameter[34] = new SqlParameter("@WeighBridgeId", SqlDbType.Int);
        //        pSqlParameter[34].Direction = ParameterDirection.Input;
        //        pSqlParameter[34].Value = objWeighBridgeBo.WeighBridgeId;

        //        sSql = "usp_tbl_WeighBridge_Update";

        //        DataTable dtResult = Database.ExecuteDataTable(CommandType.StoredProcedure, sSql, pSqlParameter);
        //        dtResult = Database.ExecuteDataTable(CommandType.StoredProcedure, sSql, pSqlParameter);
        //        ApplicationResult objResults = new ApplicationResult(dtResult);
        //        objResults.Status = ApplicationResult.CommonStatusType.Success;
        //        return objResults;
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        objWeighBridgeBo = null;
        //    }
        //}
        //#endregion
        
        #region ValidateName for WeighBridge
        /// <summary>
        /// Function which validates whether the WeighBridgeName already exits in WeighBridge table.
        /// Created By : VIshal, 11/17/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult WeighBridge_ValidateName(int intWeighBridgeId, string strName)
        {
            try
            {
                pSqlParameter = new SqlParameter[2];

                pSqlParameter[0] = new SqlParameter("@WeighBridgeId", SqlDbType.Int);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = intWeighBridgeId;

                pSqlParameter[1] = new SqlParameter("@Name", SqlDbType.VarChar);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = strName;

                strStoredProcName = "usp_tbl_WeighBridge_ValidateName";

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

        #region Select All Latest VehicleCode From WeighBrdige Table
        /// <summary>
        /// To Select All data from the WeighBrdige table
        /// Created By : Sohag  , 29/10/2018
        /// Modified By :
        /// </summary>
        public ApplicationResult Select_GenerateVehicleCode()
        {
            try
            {
                sSql = "usp_tbl_WeighBridge_Generate_TankerId";
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

        #region Select data from Temp Table Countinously
        /// <summary>
        /// Created By : Sonal , 24/01/2019
        /// Modified By :
        /// </summary>
        public ApplicationResult Select_Data()
        {
            try
            {
                sSql = "usp_tbl_Select_TankerId";
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
    }
}
