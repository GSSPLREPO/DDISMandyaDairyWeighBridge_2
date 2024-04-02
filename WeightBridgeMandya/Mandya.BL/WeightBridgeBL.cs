using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mandya.Common;
using Mandya.BO;
using System.Data;
using System.Data.SqlClient;
using Mandya.DataAccess;

namespace Mandya.BL
{
    public class WeightBridgeBL
    {

        #region user defined variables
        public string sSql;
        public string strStoredProcName;
        public SqlParameter[] pSqlParameter = null;
        #endregion

        #region Insert WeighBridge Details
        /// <summary>
        /// To Insert details of WeighBridge in WeighBridge table
        /// Created By : Chirag, 22/03/2022
        /// Modified By :
        /// </summary>
        public ApplicationResult WeightBridge_Insert(WeightBridgeBO objWeightBridgeBO)
        {
            int IsActive = 1;

            try
            {
                pSqlParameter = new SqlParameter[30];

                pSqlParameter[0] = new SqlParameter("@DateTime", SqlDbType.DateTime);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = objWeightBridgeBO.DateTime;

                pSqlParameter[1] = new SqlParameter("@TankerNo", SqlDbType.VarChar);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = objWeightBridgeBO.TankerNo;

                pSqlParameter[2] = new SqlParameter("@Purpose", SqlDbType.Int);
                pSqlParameter[2].Direction = ParameterDirection.Input;
                pSqlParameter[2].Value = objWeightBridgeBO.Purpose;

                pSqlParameter[3] = new SqlParameter("@TankerId", SqlDbType.VarChar);
                pSqlParameter[3].Direction = ParameterDirection.Input;
                pSqlParameter[3].Value = objWeightBridgeBO.TankerID;

                pSqlParameter[4] = new SqlParameter("@DispatchChalanNo", SqlDbType.VarChar);
                pSqlParameter[4].Direction = ParameterDirection.Input;
                pSqlParameter[4].Value = objWeightBridgeBO.DispatchChalanNo;

                pSqlParameter[5] = new SqlParameter("@TankerSealNo1", SqlDbType.VarChar);
                pSqlParameter[5].Direction = ParameterDirection.Input;
                pSqlParameter[5].Value = objWeightBridgeBO.TankerSealNo1;

                pSqlParameter[6] = new SqlParameter("@TankerSealNo2", SqlDbType.VarChar);
                pSqlParameter[6].Direction = ParameterDirection.Input;
                pSqlParameter[6].Value = objWeightBridgeBO.TankerSealNo2;

                pSqlParameter[7] = new SqlParameter("@TankerSealNo3", SqlDbType.VarChar);
                pSqlParameter[7].Direction = ParameterDirection.Input;
                pSqlParameter[7].Value = objWeightBridgeBO.TankerSealNo3;

                pSqlParameter[8] = new SqlParameter("@TankerSealNo4", SqlDbType.VarChar);
                pSqlParameter[8].Direction = ParameterDirection.Input;
                pSqlParameter[8].Value = objWeightBridgeBO.TankerSealNo4;

                pSqlParameter[9] = new SqlParameter("@SourceID", SqlDbType.Int);
                pSqlParameter[9].Direction = ParameterDirection.Input;
                pSqlParameter[9].Value = objWeightBridgeBO.SourceID;

                pSqlParameter[10] = new SqlParameter("@DestinationID", SqlDbType.Int);
                pSqlParameter[10].Direction = ParameterDirection.Input;
                pSqlParameter[10].Value = objWeightBridgeBO.DestinationID;

                pSqlParameter[11] = new SqlParameter("@ProductID", SqlDbType.Int);
                pSqlParameter[11].Direction = ParameterDirection.Input;
                pSqlParameter[11].Value = objWeightBridgeBO.ProductID;

                pSqlParameter[12] = new SqlParameter("@RouteID", SqlDbType.Int);
                pSqlParameter[12].Direction = ParameterDirection.Input;
                pSqlParameter[12].Value = objWeightBridgeBO.RouteID;

                pSqlParameter[13] = new SqlParameter("@WeightBridgeNo", SqlDbType.Int);
                pSqlParameter[13].Direction = ParameterDirection.Input;
                pSqlParameter[13].Value = objWeightBridgeBO.WeightBridgeNo;

                pSqlParameter[14] = new SqlParameter("@WeightType", SqlDbType.VarChar);
                pSqlParameter[14].Direction = ParameterDirection.Input;
                pSqlParameter[14].Value = objWeightBridgeBO.WeightType;

                pSqlParameter[15] = new SqlParameter("@EntryType", SqlDbType.VarChar);
                pSqlParameter[15].Direction = ParameterDirection.Input;
                pSqlParameter[15].Value = objWeightBridgeBO.EntryType;

                pSqlParameter[16] = new SqlParameter("@Remarks", SqlDbType.VarChar);
                pSqlParameter[16].Direction = ParameterDirection.Input;
                pSqlParameter[16].Value = objWeightBridgeBO.Remarks;

                pSqlParameter[17] = new SqlParameter("@TareWeight", SqlDbType.Decimal);
                pSqlParameter[17].Direction = ParameterDirection.Input;
                pSqlParameter[17].Value = objWeightBridgeBO.TareWeight;

                pSqlParameter[18] = new SqlParameter("@TareWeightDateTime", SqlDbType.DateTime);
                pSqlParameter[18].Direction = ParameterDirection.Input;
                pSqlParameter[18].Value = objWeightBridgeBO.TareWeightDateTime;

                pSqlParameter[19] = new SqlParameter("@GrossWeight", SqlDbType.Decimal);
                pSqlParameter[19].Direction = ParameterDirection.Input;
                pSqlParameter[19].Value = objWeightBridgeBO.GrossWeight;

                pSqlParameter[20] = new SqlParameter("@GrossWeightDateTime", SqlDbType.DateTime);
                pSqlParameter[20].Direction = ParameterDirection.Input;
                pSqlParameter[20].Value = objWeightBridgeBO.GrossWeightDateTime;

                pSqlParameter[21] = new SqlParameter("@NetWeight", SqlDbType.Decimal);
                pSqlParameter[21].Direction = ParameterDirection.Input;
                pSqlParameter[21].Value = objWeightBridgeBO.NetWeight;

                pSqlParameter[22] = new SqlParameter("@SuppliedQty", SqlDbType.Decimal);
                pSqlParameter[22].Direction = ParameterDirection.Input;
                pSqlParameter[22].Value = objWeightBridgeBO.SuppliedQty;

                pSqlParameter[23] = new SqlParameter("@DifferenceQty", SqlDbType.Decimal);
                pSqlParameter[23].Direction = ParameterDirection.Input;
                pSqlParameter[23].Value = objWeightBridgeBO.DifferenceQty;

                pSqlParameter[24] = new SqlParameter("@CreatedByID", SqlDbType.Int);
                pSqlParameter[24].Direction = ParameterDirection.Input;
                pSqlParameter[24].Value = objWeightBridgeBO.CreatedByID;

                pSqlParameter[25] = new SqlParameter("@CreatedByDate", SqlDbType.DateTime);
                pSqlParameter[25].Direction = ParameterDirection.Input;
                pSqlParameter[25].Value = objWeightBridgeBO.CreatedByDate;

                pSqlParameter[26] = new SqlParameter("@IsActive", SqlDbType.Int);
                pSqlParameter[26].Direction = ParameterDirection.Input;
                pSqlParameter[26].Value = IsActive;

                pSqlParameter[27] = new SqlParameter("@SupplierID", SqlDbType.Int);
                pSqlParameter[27].Direction = ParameterDirection.Input;
                pSqlParameter[27].Value = objWeightBridgeBO.SupplierID;

                pSqlParameter[28] = new SqlParameter("@CustomerID", SqlDbType.Int);
                pSqlParameter[28].Direction = ParameterDirection.Input;
                pSqlParameter[28].Value = objWeightBridgeBO.CustomerID;

                pSqlParameter[29] = new SqlParameter("@DriverName", SqlDbType.VarChar);
                pSqlParameter[29].Direction = ParameterDirection.Input;
                pSqlParameter[29].Value = objWeightBridgeBO.DriverName;

                sSql = "usp_tbl_WeightBridge_Insert";

                DataTable dtResult = new DataTable();
                dtResult = Database.ExecuteDataTable(CommandType.StoredProcedure, sSql, pSqlParameter);
                ApplicationResult objResults = new ApplicationResult(dtResult);
                objResults.Status = ApplicationResult.CommonStatusType.Success;
                return objResults;

                //int iResult = Database.ExecuteNonQuery(CommandType.StoredProcedure, sSql, pSqlParameter);

                //if (iResult > 0)
                //{
                //    ApplicationResult objResults = new ApplicationResult();
                //    objResults.Status = ApplicationResult.CommonStatusType.Success;
                //    return objResults;
                //}
                //else
                //{
                //    ApplicationResult objResults = new ApplicationResult();
                //    objResults.Status = ApplicationResult.CommonStatusType.Failure;
                //    return objResults;
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objWeightBridgeBO = null;
            }
        }
        #endregion

        #region Auto Generate TankerID
        /// <summary>
        /// 
        /// Created By : Chirag  , 18-03-2022
        /// Modified By : Shweta , 28-03-2024
        /// </summary>
        public ApplicationResult Autogernerate_TankerID(int intPurpose)
        {
            try
            {
                pSqlParameter = new SqlParameter[1];

                pSqlParameter[0] = new SqlParameter("@Purpose", SqlDbType.Int);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = intPurpose;

                //New SP added to generate TankerIds of WeighBridge 2 system by Shweta 28-03-2024
                sSql = "usp_tbl_Autogernerate_TankerID_1";
                DataTable dtResult = new DataTable();
                dtResult = Database.ExecuteDataTable(CommandType.StoredProcedure, sSql, pSqlParameter);

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

        #region Select All WeighBridge Details
        /// <summary>
        /// To Select All data from the WeighBridge table
        /// Created By : VIshal, 11/17/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult WeightBridge_SelectAll()
        {
            try
            {
                sSql = "usp_tbl_WeightBridge_SelectAll";
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
        /// Created By : Chirag, 22/03/2022
        /// Modified By :
        /// </summary>
        [Obsolete]
        public ApplicationResult WeightBridge_Select(int intWeightBridgeId, int EditMode)
        {
            try
            {
                pSqlParameter = new SqlParameter[2];  

                pSqlParameter[0] = new SqlParameter("@WeightBridgeID", SqlDbType.Int);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = intWeightBridgeId;

                pSqlParameter[1] = new SqlParameter("@EditMode", SqlDbType.Int);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = EditMode;

                strStoredProcName = "usp_tbl_WeightBridge_Select";

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

        #region Select All WeighBridge Details for Edit Delete
        /// <summary>
        /// To Select All data from the WeighBridge table
        /// Created By : Chirag, 22-03-2022
        /// Modified By :
        /// </summary>
        public ApplicationResult WeightBridge_SelectAll_Edit_Delete(DateTime FromDate, DateTime ToDate)
        {
            try
            {
                pSqlParameter = new SqlParameter[2];

                pSqlParameter[0] = new SqlParameter("@FromDate", SqlDbType.DateTime);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = FromDate;

                pSqlParameter[1] = new SqlParameter("@ToDate", SqlDbType.DateTime);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = ToDate;

                sSql = "usp_tbl_WeightBridge_SelectAll_Edit_Delete";
                DataTable dtWeighBridge = new DataTable();
                dtWeighBridge = Database.ExecuteDataTable(CommandType.StoredProcedure, sSql, pSqlParameter);

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

        #region Delete Weight Bridge Data
        /// <summary>
        /// Created By : Chirag, 22-03-2022
        /// Modified By :
        /// </summary>
        public ApplicationResult WeightBridge_Delete(int intId,int intUserId)
        {
            try
            {
                pSqlParameter = new SqlParameter[2];

                pSqlParameter[0] = new SqlParameter("@WeightBridgeID", SqlDbType.Int);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = intId;

                pSqlParameter[1] = new SqlParameter("@LastModifiedByID", SqlDbType.Int);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = intUserId;

                sSql = "usp_tbl_WeightBridge_Delete";
                DataTable dtWeighBridge = new DataTable();
               
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
        }
        #endregion

        #region Update WeightBridge Details
        /// <summary>
        /// To Update details of WeighBridge in WeighBridge table
        /// Created By : Chirag, 22-03-2022
        /// Modified By :
        /// </summary>
        public ApplicationResult WeightBridge_Update(WeightBridgeBO objWeightBridgeBO)
        {
            int IsActive = 0;
            try
            {
                pSqlParameter = new SqlParameter[32];

                pSqlParameter[0] = new SqlParameter("@DateTime", SqlDbType.DateTime);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = objWeightBridgeBO.DateTime;

                pSqlParameter[1] = new SqlParameter("@TankerNo", SqlDbType.VarChar);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = objWeightBridgeBO.TankerNo;

                pSqlParameter[2] = new SqlParameter("@Purpose", SqlDbType.Int);
                pSqlParameter[2].Direction = ParameterDirection.Input;
                pSqlParameter[2].Value = objWeightBridgeBO.Purpose;

                pSqlParameter[3] = new SqlParameter("@TankerId", SqlDbType.VarChar);
                pSqlParameter[3].Direction = ParameterDirection.Input;
                pSqlParameter[3].Value = objWeightBridgeBO.TankerID;

                pSqlParameter[4] = new SqlParameter("@DispatchChalanNo", SqlDbType.VarChar);
                pSqlParameter[4].Direction = ParameterDirection.Input;
                pSqlParameter[4].Value = objWeightBridgeBO.DispatchChalanNo;

                pSqlParameter[5] = new SqlParameter("@TankerSealNo1", SqlDbType.VarChar);
                pSqlParameter[5].Direction = ParameterDirection.Input;
                pSqlParameter[5].Value = objWeightBridgeBO.TankerSealNo1;

                pSqlParameter[6] = new SqlParameter("@TankerSealNo2", SqlDbType.VarChar);
                pSqlParameter[6].Direction = ParameterDirection.Input;
                pSqlParameter[6].Value = objWeightBridgeBO.TankerSealNo2;

                pSqlParameter[7] = new SqlParameter("@TankerSealNo3", SqlDbType.VarChar);
                pSqlParameter[7].Direction = ParameterDirection.Input;
                pSqlParameter[7].Value = objWeightBridgeBO.TankerSealNo3;

                pSqlParameter[8] = new SqlParameter("@TankerSealNo4", SqlDbType.VarChar);
                pSqlParameter[8].Direction = ParameterDirection.Input;
                pSqlParameter[8].Value = objWeightBridgeBO.TankerSealNo4;

                pSqlParameter[9] = new SqlParameter("@SourceID", SqlDbType.Int);
                pSqlParameter[9].Direction = ParameterDirection.Input;
                pSqlParameter[9].Value = objWeightBridgeBO.SourceID;

                pSqlParameter[10] = new SqlParameter("@DestinationID", SqlDbType.Int);
                pSqlParameter[10].Direction = ParameterDirection.Input;
                pSqlParameter[10].Value = objWeightBridgeBO.DestinationID;

                pSqlParameter[11] = new SqlParameter("@ProductID", SqlDbType.Int);
                pSqlParameter[11].Direction = ParameterDirection.Input;
                pSqlParameter[11].Value = objWeightBridgeBO.ProductID;

                pSqlParameter[12] = new SqlParameter("@RouteID", SqlDbType.Int);
                pSqlParameter[12].Direction = ParameterDirection.Input;
                pSqlParameter[12].Value = objWeightBridgeBO.RouteID;

                pSqlParameter[13] = new SqlParameter("@WeightBridgeNo", SqlDbType.Int);
                pSqlParameter[13].Direction = ParameterDirection.Input;
                pSqlParameter[13].Value = objWeightBridgeBO.WeightBridgeNo;

                pSqlParameter[14] = new SqlParameter("@WeightType", SqlDbType.VarChar);
                pSqlParameter[14].Direction = ParameterDirection.Input;
                pSqlParameter[14].Value = objWeightBridgeBO.WeightType;

                pSqlParameter[15] = new SqlParameter("@EntryType", SqlDbType.VarChar);
                pSqlParameter[15].Direction = ParameterDirection.Input;
                pSqlParameter[15].Value = objWeightBridgeBO.EntryType;

                pSqlParameter[16] = new SqlParameter("@Remarks", SqlDbType.VarChar);
                pSqlParameter[16].Direction = ParameterDirection.Input;
                pSqlParameter[16].Value = objWeightBridgeBO.Remarks;

                pSqlParameter[17] = new SqlParameter("@TareWeight", SqlDbType.Decimal);
                pSqlParameter[17].Direction = ParameterDirection.Input;
                pSqlParameter[17].Value = objWeightBridgeBO.TareWeight;

                pSqlParameter[18] = new SqlParameter("@TareWeightDateTime", SqlDbType.DateTime);
                pSqlParameter[18].Direction = ParameterDirection.Input;
                pSqlParameter[18].Value = objWeightBridgeBO.TareWeightDateTime;

                pSqlParameter[19] = new SqlParameter("@GrossWeight", SqlDbType.Decimal);
                pSqlParameter[19].Direction = ParameterDirection.Input;
                pSqlParameter[19].Value = objWeightBridgeBO.GrossWeight;

                pSqlParameter[20] = new SqlParameter("@GrossWeightDateTime", SqlDbType.DateTime);
                pSqlParameter[20].Direction = ParameterDirection.Input;
                pSqlParameter[20].Value = objWeightBridgeBO.GrossWeightDateTime;

                pSqlParameter[21] = new SqlParameter("@NetWeight", SqlDbType.Decimal);
                pSqlParameter[21].Direction = ParameterDirection.Input;
                pSqlParameter[21].Value = objWeightBridgeBO.NetWeight;

                pSqlParameter[22] = new SqlParameter("@SuppliedQty", SqlDbType.Decimal);
                pSqlParameter[22].Direction = ParameterDirection.Input;
                pSqlParameter[22].Value = objWeightBridgeBO.SuppliedQty;

                pSqlParameter[23] = new SqlParameter("@DifferenceQty", SqlDbType.Decimal);
                pSqlParameter[23].Direction = ParameterDirection.Input;
                pSqlParameter[23].Value = objWeightBridgeBO.DifferenceQty;

                pSqlParameter[24] = new SqlParameter("@LastModifiedByID", SqlDbType.Int);
                pSqlParameter[24].Direction = ParameterDirection.Input;
                pSqlParameter[24].Value = objWeightBridgeBO.LastModifiedByID;

                pSqlParameter[25] = new SqlParameter("@LastModifiedByDate", SqlDbType.DateTime);
                pSqlParameter[25].Direction = ParameterDirection.Input;
                pSqlParameter[25].Value = objWeightBridgeBO.LastModifiedByDate;

                pSqlParameter[26] = new SqlParameter("@WeightBridgeID", SqlDbType.Int);
                pSqlParameter[26].Direction = ParameterDirection.Input;
                pSqlParameter[26].Value = objWeightBridgeBO.WeightBridgeID;

                pSqlParameter[27] = new SqlParameter("@IsActive", SqlDbType.Int);
                pSqlParameter[27].Direction = ParameterDirection.Input;
                pSqlParameter[27].Value = IsActive;

                pSqlParameter[28] = new SqlParameter("@SupplierID", SqlDbType.Int);
                pSqlParameter[28].Direction = ParameterDirection.Input;
                pSqlParameter[28].Value = objWeightBridgeBO.SupplierID;

                pSqlParameter[29] = new SqlParameter("@CustomerID", SqlDbType.Int);
                pSqlParameter[29].Direction = ParameterDirection.Input;
                pSqlParameter[29].Value = objWeightBridgeBO.CustomerID;

                pSqlParameter[30] = new SqlParameter("@CIPStatus", SqlDbType.VarChar);
                pSqlParameter[30].Direction = ParameterDirection.Input;
                pSqlParameter[30].Value = objWeightBridgeBO.CIPStatus;

                pSqlParameter[31] = new SqlParameter("@DriverName", SqlDbType.VarChar);
                pSqlParameter[31].Direction = ParameterDirection.Input;
                pSqlParameter[31].Value = objWeightBridgeBO.DriverName;


                sSql = "usp_tbl_WeightBridge_Update";

                DataTable dtResult = new DataTable();
                dtResult = Database.ExecuteDataTable(CommandType.StoredProcedure, sSql, pSqlParameter);
                ApplicationResult objResults = new ApplicationResult(dtResult);
                objResults.Status = ApplicationResult.CommonStatusType.Success;
                return objResults;

               /* int iResult = Database.ExecuteNonQuery(CommandType.StoredProcedure, sSql, pSqlParameter);

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
                }*/
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                objWeightBridgeBO = null;
            }
        }
        #endregion

        #region Auto Generate Dispatch Challan No
        /// <summary>
        /// 
        /// Created By : Chirag  , 22-03-2022
        /// Modified By :
        /// </summary>
        public ApplicationResult Autogernerate_DispatchChallanNo()
        {
            try
            {
                sSql = "usp_tbl_Autogernerate_DispatchChallanNo";
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

        #region Select WeighBridge Details by WeighBridgeId for Print Slip(Inlet Outlet)
        /// <summary>
        /// Select all details of WeighBridge for selected WeighBridgeId from WeighBridge table
        /// Created By : Chirag, 
        /// Modified By :
        /// </summary>
        public ApplicationResult WeightBridge_Select_ForPrint(int intWeightBridgeId, int intPrintType)
        {
            try
            {
                pSqlParameter = new SqlParameter[2];

                pSqlParameter[0] = new SqlParameter("@WeightBridgeId", SqlDbType.Int);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = intWeightBridgeId;

                pSqlParameter[1] = new SqlParameter("@PrintType", SqlDbType.Int);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = intPrintType;

                strStoredProcName = "usp_tbl_WeightBridge_Select_ForPrint";

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

        #region Select Tankar CIPStatus
        /// <summary>
        /// Select Tankar CIPStatus from Tanker Dispatch Report
        /// Created By : Chirag, 09-04-2022
        /// Modified By :
        /// </summary>
        public ApplicationResult WeightBridge_Select_CIPStatus(string strTankerID)
        {
            try
            {
                pSqlParameter = new SqlParameter[1];

                pSqlParameter[0] = new SqlParameter("@TankerID", SqlDbType.VarChar);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = strTankerID;

                strStoredProcName = "usp_tbl_WeightBridge_Select_CIPStatus";

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

        #region Auto complite Tanker No
        /// <summary>
        /// Auto complite Tanker No
        /// Created By : Chirag, 06-10-2022
        /// Modified By :
        /// </summary>
        [Obsolete]
        public ApplicationResult AutoCompliteTankerNo()
        {
            try
            {
                strStoredProcName = "usp_tbl_AutoCompliteTankerNo";

                
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
