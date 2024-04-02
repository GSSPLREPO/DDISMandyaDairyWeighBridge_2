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
    public class SupplierBL
    {
        #region user defined variables
        public string sSql;
        public string strStoredProcName;
        public SqlParameter[] pSqlParameter = null;
        #endregion

        #region Select All Supplier Details
        /// <summary>
        /// To Select All data from the Supplier table
        /// Created By : Vishal, 11/16/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult Supplier_SelectAll()
        {
            try
            {
                sSql = "usp_tbl_Supplier_SelectAll";
                DataTable dtSupplier = new DataTable();
                dtSupplier = Database.ExecuteDataTable(CommandType.StoredProcedure, sSql, null);

                ApplicationResult objResults = new ApplicationResult(dtSupplier);
                objResults.Status = ApplicationResult.CommonStatusType.Success;
                return objResults;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

       /* public IEnumerable<SupplierBO> Supplier_SelectAll1()
        {
            List<SupplierBO> resultList = new List<SupplierBO>();
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Sample;Integrated Security=true;");
                SqlCommand com = new SqlCommand("Select State from tbl_State", con);
                con.Open();
                SqlDataReader rdr = com.ExecuteReader();
                //AutoCompleteStringCollection Contains a collection of strings to use for the auto-complete feature on certain Windows Forms controls.
                //AutoCompleteStringCollection autoCompleteCollection = new AutoCompleteStringCollection();
                while (rdr.Read())
                {
                    var result = new SupplierBO
                    {
                        SupplierName = rdr["SupplierName"].ToString()
                    };

                    resultList.Add(result);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return resultList;
        }*/


        #endregion

        #region Select Supplier Details by SupplierId
        /// <summary>
        /// Select all details of Supplier for selected SupplierId from Supplier table
        /// Created By : Vishal, 11/16/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult Supplier_Select(int intSupplierID)
        {
            try
            {
                pSqlParameter = new SqlParameter[1];

                pSqlParameter[0] = new SqlParameter("@SupplierID", SqlDbType.Int);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = intSupplierID;

                strStoredProcName = "usp_tbl_Supplier_Select";

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

        #region Delete Supplier Details by SupplierId
        /// <summary>
        /// To Delete details of Supplier for selected SupplierId from Supplier table
        /// Created By : Vishal, 11/16/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult Supplier_Delete(int intSupplierID, int intLastModifiedBy, DateTime dtDateTime)
        {
            try
            {
                pSqlParameter = new SqlParameter[3];

                pSqlParameter[0] = new SqlParameter("@SupplierID", SqlDbType.Int);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = intSupplierID;

                pSqlParameter[1] = new SqlParameter("@LastModifiedByID", SqlDbType.Int);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = intLastModifiedBy;

                pSqlParameter[2] = new SqlParameter("@LastModifiedByDate", SqlDbType.DateTime);
                pSqlParameter[2].Direction = ParameterDirection.Input;
                pSqlParameter[2].Value = dtDateTime;

                strStoredProcName = "usp_tbl_Supplier_Delete";

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

        #region Insert Supplier Details
        /// <summary>
        /// To Insert details of Supplier in Supplier table
        /// Created By : Vishal, 11/16/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult Supplier_Insert(SupplierBO objSupplierBo)
        {
            try
            {
                pSqlParameter = new SqlParameter[12];


                pSqlParameter[0] = new SqlParameter("@SupplierCode", SqlDbType.VarChar);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = objSupplierBo.SupplierCode;

                pSqlParameter[1] = new SqlParameter("@SupplierName", SqlDbType.VarChar);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = objSupplierBo.SupplierName;

                pSqlParameter[2] = new SqlParameter("@Address", SqlDbType.VarChar);
                pSqlParameter[2].Direction = ParameterDirection.Input;
                pSqlParameter[2].Value = objSupplierBo.Address;

                pSqlParameter[3] = new SqlParameter("@City", SqlDbType.VarChar);
                pSqlParameter[3].Direction = ParameterDirection.Input;
                pSqlParameter[3].Value = objSupplierBo.City;

                pSqlParameter[4] = new SqlParameter("@District", SqlDbType.VarChar);
                pSqlParameter[4].Direction = ParameterDirection.Input;
                pSqlParameter[4].Value = objSupplierBo.District;

                pSqlParameter[5] = new SqlParameter("@State", SqlDbType.VarChar);
                pSqlParameter[5].Direction = ParameterDirection.Input;
                pSqlParameter[5].Value = objSupplierBo.State;

                pSqlParameter[6] = new SqlParameter("@Phone", SqlDbType.VarChar);
                pSqlParameter[6].Direction = ParameterDirection.Input;
                pSqlParameter[6].Value = objSupplierBo.Phone;

                pSqlParameter[7] = new SqlParameter("@Email", SqlDbType.VarChar);
                pSqlParameter[7].Direction = ParameterDirection.Input;
                pSqlParameter[7].Value = objSupplierBo.Email;

                pSqlParameter[8] = new SqlParameter("@Remarks", SqlDbType.VarChar);
                pSqlParameter[8].Direction = ParameterDirection.Input;
                pSqlParameter[8].Value = objSupplierBo.Remarks;

                pSqlParameter[9] = new SqlParameter("@CreatedByID", SqlDbType.Int);
                pSqlParameter[9].Direction = ParameterDirection.Input;
                pSqlParameter[9].Value = objSupplierBo.CreatedByID;

                pSqlParameter[10] = new SqlParameter("@CreatedByDate", SqlDbType.DateTime);
                pSqlParameter[10].Direction = ParameterDirection.Input;
                pSqlParameter[10].Value = objSupplierBo.CreatedByDate;

                pSqlParameter[11] = new SqlParameter("@Country", SqlDbType.VarChar);
                pSqlParameter[11].Direction = ParameterDirection.Input;
                pSqlParameter[11].Value = objSupplierBo.Country;


                sSql = "usp_tbl_Supplier_Insert";
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
                objSupplierBo = null;
            }
        }
        #endregion

        #region Update Supplier Details
        /// <summary>
        /// To Update details of Supplier in Supplier table
        /// Created By : Vishal, 11/16/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult Supplier_Update(SupplierBO objSupplierBo)
        {
            try
            {
                pSqlParameter = new SqlParameter[13];


                pSqlParameter[0] = new SqlParameter("@SupplierID", SqlDbType.Int);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = objSupplierBo.SupplierID;

                pSqlParameter[1] = new SqlParameter("@SupplierCode", SqlDbType.VarChar);
                pSqlParameter[1].Direction = ParameterDirection.Input;
                pSqlParameter[1].Value = objSupplierBo.SupplierCode;

                pSqlParameter[2] = new SqlParameter("@SupplierName", SqlDbType.VarChar);
                pSqlParameter[2].Direction = ParameterDirection.Input;
                pSqlParameter[2].Value = objSupplierBo.SupplierName;

                pSqlParameter[3] = new SqlParameter("@Address", SqlDbType.VarChar);
                pSqlParameter[3].Direction = ParameterDirection.Input;
                pSqlParameter[3].Value = objSupplierBo.Address;

                pSqlParameter[4] = new SqlParameter("@City", SqlDbType.VarChar);
                pSqlParameter[4].Direction = ParameterDirection.Input;
                pSqlParameter[4].Value = objSupplierBo.City;

                pSqlParameter[5] = new SqlParameter("@District", SqlDbType.VarChar);
                pSqlParameter[5].Direction = ParameterDirection.Input;
                pSqlParameter[5].Value = objSupplierBo.District;

                pSqlParameter[6] = new SqlParameter("@State", SqlDbType.VarChar);
                pSqlParameter[6].Direction = ParameterDirection.Input;
                pSqlParameter[6].Value = objSupplierBo.State;

                pSqlParameter[7] = new SqlParameter("@Phone", SqlDbType.VarChar);
                pSqlParameter[7].Direction = ParameterDirection.Input;
                pSqlParameter[7].Value = objSupplierBo.Phone;

                pSqlParameter[8] = new SqlParameter("@Email", SqlDbType.VarChar);
                pSqlParameter[8].Direction = ParameterDirection.Input;
                pSqlParameter[8].Value = objSupplierBo.Email;

                pSqlParameter[9] = new SqlParameter("@Remarks", SqlDbType.VarChar);
                pSqlParameter[9].Direction = ParameterDirection.Input;
                pSqlParameter[9].Value = objSupplierBo.Remarks;

                pSqlParameter[10] = new SqlParameter("@LastModifiedByID", SqlDbType.VarChar);
                pSqlParameter[10].Direction = ParameterDirection.Input;
                pSqlParameter[10].Value = objSupplierBo.LastModifiedByID;

                pSqlParameter[11] = new SqlParameter("@LastModifiedByDate", SqlDbType.DateTime);
                pSqlParameter[11].Direction = ParameterDirection.Input;
                pSqlParameter[11].Value = objSupplierBo.LastModifiedByDate;

                pSqlParameter[12] = new SqlParameter("@Country", SqlDbType.VarChar);
                pSqlParameter[12].Direction = ParameterDirection.Input;
                pSqlParameter[12].Value = objSupplierBo.Country;

                sSql = "usp_tbl_Supplier_Update";

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
                objSupplierBo = null;
            }
        }
        #endregion

        #region ValidateName for Supplier
        /// <summary>
        /// Function which validates whether the SupplierName already exits in Supplier table.
        /// Created By : Vishal, 11/16/2015
        /// Modified By :
        /// </summary>
        public ApplicationResult Supplier_ValidateName(string strName)
        {
            try
            {
                pSqlParameter = new SqlParameter[1];

                pSqlParameter[0] = new SqlParameter("@Name", SqlDbType.VarChar);
                pSqlParameter[0].Direction = ParameterDirection.Input;
                pSqlParameter[0].Value = strName;

                strStoredProcName = "usp_tbl_Supplier_ValidateName";

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
