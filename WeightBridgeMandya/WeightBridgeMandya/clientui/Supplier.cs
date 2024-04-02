using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Mandya.Common;
using Mandya.BO;
using Mandya.BL;
using MetroFramework;
using MetroFramework.Forms;
using System.Globalization;

namespace WeightBridgeMandya.clientui
{
    public partial class Supplier : MetroForm
    {
        private static readonly log4net.ILog log =
        log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #region Initialize Component
        public Supplier()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Load Event
        private void Supplier_Load(object sender, EventArgs e)
        {
            try
            {
               
                BindSupplier();
                VisibilityMode(1);
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Bind Supplier 
        public void BindSupplier()
        {
            try
            {
                ApplicationResult objResult = new ApplicationResult();
                SupplierBL objSupplierBL = new SupplierBL();
                objResult = objSupplierBL.Supplier_SelectAll();
                if (objResult != null)
                {
                    if (objResult.ResultDt.Rows.Count > 0)
                    {
                        cmbSearchSupplier.DataSource = objResult.ResultDt;
                        cmbSearchSupplier.ValueMember = SupplierBO.SUPPLIER_SUPPLIERID;
                        cmbSearchSupplier.DisplayMember = SupplierBO.SUPPLIER_SUPPLIERNAME;

                        cmbSearchSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
                        cmbSearchSupplier.AutoCompleteSource = AutoCompleteSource.ListItems;
                        cmbSearchSupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    }
                }

            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region VisibilityMode Method
        //1 = page load
        //2 = dropdown change
        //3 = edit button
        //4 = add button
        public void VisibilityMode(int intMode)
        {
            if (intMode == 1)
            {
                pnlDropdown.Visible = true;
                pnlForm.Visible = false;
                btnAddnew.Visible = true;
                btnEdit.Visible = false;
                btnDelete.Visible = false;
                pnlButton.Visible = false;

                lblAdd.Visible = true;
                lblEdit.Visible = false;
                lblDelete.Visible = false;
            }
            else if (intMode == 2)
            {
                pnlDropdown.Visible = true;
                pnlForm.Visible = true;
                pnlForm.Enabled = false;
                pnlButton.Visible = false;
                btnAddnew.Visible = false;
                btnEdit.Visible = true;
                btnDelete.Visible = true;

                lblAdd.Visible = false;
                lblEdit.Visible = true;
                lblDelete.Visible = true;
            }
            else if (intMode == 3)
            {
                pnlDropdown.Visible = false;
                pnlForm.Visible = true;
                pnlForm.Enabled = true;
                pnlButton.Visible = true;
                btnSave.Text = "Update";
                btnEdit.Visible = false;
                btnDelete.Visible = false;

                lblEdit.Visible = false;
                lblDelete.Visible = false;
            }
            else if (intMode == 4)
            {
                pnlDropdown.Visible = false;
                pnlForm.Visible = true;
                pnlForm.Enabled = true;
                pnlButton.Visible = true;
                btnSave.Text = "Save";
                btnEdit.Visible = false;
                btnDelete.Visible = false;

                lblEdit.Visible = false;
                lblDelete.Visible = false;
            }
        }
        #endregion

        #region Clear All Method

        private void ClearAll()
        {
            txtSupplierName.Text = "";
            txtSupplierCode.Text = "";
            txtAddress.Text = "";
            txtState.Text = "";
            txtDistrict.Text = "";
            txtCountry.Text = "";
            txtPhone.Text = "";
            txtCity.Text = "";
            txtEmail.Text = "";
        }
        #endregion
        
        #region Close Button Click Event
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Add New Button Click Event
        private void btnAddnew_Click(object sender, EventArgs e)
        {
            ClearAll();
            VisibilityMode(4);
        }
        #endregion

        #region Edit Button Click Event
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSearchSupplier.SelectedValue.ToString() != "0")
                {
                    VisibilityMode(3);
                }
                else
                {
                    MetroMessageBox.Show(this, "Select Supplier.", "Mandya WeighBridge", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {

            }
        }
        #endregion

        #region Delete Button Click Event
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSearchSupplier.SelectedValue.ToString() != "0")
                {
                    DialogResult result = MetroMessageBox.Show(this, "Do you really want to delete this record?", "Mandya WeighBridge", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        ApplicationResult objResult = new ApplicationResult();
                        SupplierBL objSupplierBL = new SupplierBL();
                        objResult = objSupplierBL.Supplier_Delete(Convert.ToInt32(cmbSearchSupplier.SelectedValue), 1, DateTime.UtcNow.AddHours(5.5));
                        if (objResult.Status.ToString() == "Success")
                        {
                            MetroMessageBox.Show(this, "Record Deleted Successfully.", "Mandya WeighBridge",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "You cannot delete this record. Because it is in use.",
                                "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        ClearAll();
                        BindSupplier();
                        VisibilityMode(1);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Select Supplier.", "Mandya WeighBridge'", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Save Button Click Event
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int intValidate = 0;

                if (txtSupplierName.Text.Trim() == "")
                {
                    MetroMessageBox.Show(this, "Enter Supplier Name.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }
               /* else if (txtSupplierCode.Text.Trim() == "")
                {
                    MetroMessageBox.Show(this, "Enter Supplier Code.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }*/

                if (intValidate == 0)
                {
                    ApplicationResult objResult = new ApplicationResult();
                    SupplierBO objSupplierBO = new SupplierBO();
                    SupplierBL objSupplierBL = new SupplierBL();

                    int intValidateNameId = 0;
                    objSupplierBO.SupplierName = txtSupplierName.Text;
                    if (txtSupplierCode.Text == "")
                    {
                        objSupplierBO.SupplierCode = "0";
                    }
                    else
                    {
                        objSupplierBO.SupplierCode = txtSupplierCode.Text;
                    }
                    
                    objSupplierBO.Address = txtAddress.Text;
                    objSupplierBO.State = txtState.Text;
                    objSupplierBO.District = txtDistrict.Text;
                    objSupplierBO.Country = txtCountry.Text;
                    objSupplierBO.Phone = txtPhone.Text;
                    objSupplierBO.Email = txtEmail.Text;
                    objSupplierBO.City = txtCity.Text;
                    
                    if (btnSave.Text == "Save")
                    {
                        intValidateNameId = -1;
                    }
                    else if (btnSave.Text == "Update")
                    {
                        intValidateNameId = Convert.ToInt32(lblSupplierId.Text);
                    }
                    objResult = objSupplierBL.Supplier_ValidateName(objSupplierBO.SupplierName);
                    if (objResult != null)
                    {
                        if (objResult.ResultDt.Rows.Count > 0)
                        {
                           MetroMessageBox.Show(this, "Supplier Name already exist.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (btnSave.Text == "Save")
                            {
                                objSupplierBO.CreatedByID = 1;
                                objSupplierBO.CreatedByDate = DateTime.UtcNow.AddHours(5.5);
                                objResult = objSupplierBL.Supplier_Insert(objSupplierBO);
                                if (objResult.Status == ApplicationResult.CommonStatusType.Success)
                                {
                                    MetroMessageBox.Show(this, "Record Saved Successfully.", "WeighBridge", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                                }
                            }
                            else if (btnSave.Text == "Update")
                            {
                                objSupplierBO.LastModifiedByID = 1;
                                objSupplierBO.LastModifiedByDate = DateTime.UtcNow.AddHours(5.5);
                                objSupplierBO.SupplierID = Convert.ToInt32(lblSupplierId.Text);
                                objResult = objSupplierBL.Supplier_Update(objSupplierBO);
                                if (objResult.Status.ToString() == "Success")
                                {
                                    MetroMessageBox.Show(this, "Record Updated Successfully.", "WeighBridge",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                                }
                                else
                                {
                                    MetroMessageBox.Show(this, "Supplier Name Already Exist.", "WeighBridge",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                                }
                            }
                            ClearAll();
                            BindSupplier();
                            VisibilityMode(1);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Clear Button Click Event
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
            VisibilityMode(1);
            cmbSearchSupplier.SelectedValue = "0";

        }
        #endregion

        #region Combobox Search Supplier Selection Change  Committed Event
        private void cmbSearchSupplier_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbSearchSupplier.SelectedValue.ToString() != "0")
                {
                    ApplicationResult objResult = new ApplicationResult();
                    SupplierBL objSupplierBL = new SupplierBL();

                    objResult = objSupplierBL.Supplier_Select(Convert.ToInt32(cmbSearchSupplier.SelectedValue));
                    if (objResult != null)
                    {
                        if (objResult.ResultDt.Rows.Count > 0)
                        {
                            lblSupplierId.Text = objResult.ResultDt.Rows[0][SupplierBO.SUPPLIER_SUPPLIERID].ToString();
                            txtSupplierName.Text = objResult.ResultDt.Rows[0][SupplierBO.SUPPLIER_SUPPLIERNAME].ToString();
                            txtSupplierCode.Text = objResult.ResultDt.Rows[0][SupplierBO.SUPPLIER_SUPPLIERCODE].ToString();
                            txtAddress.Text = objResult.ResultDt.Rows[0][SupplierBO.SUPPLIER_ADDRESS].ToString();
                            txtState.Text = objResult.ResultDt.Rows[0][SupplierBO.SUPPLIER_STATE].ToString();
                            txtDistrict.Text = objResult.ResultDt.Rows[0][SupplierBO.SUPPLIER_DISTRICT].ToString();
                            txtCountry.Text = objResult.ResultDt.Rows[0][SupplierBO.SUPPLIER_COUNTRY].ToString();
                            txtPhone.Text = objResult.ResultDt.Rows[0][SupplierBO.SUPPLIER_PHONE].ToString();
                            txtEmail.Text = objResult.ResultDt.Rows[0][SupplierBO.SUPPLIER_EMAIL].ToString();
                            txtRemark.Text = objResult.ResultDt.Rows[0][SupplierBO.SUPPLIER_REMARKS].ToString();
                            txtCity.Text = objResult.ResultDt.Rows[0][SupplierBO.SUPPLIER_CITY].ToString();

                            VisibilityMode(2);
                        }
                    }
                }
                else
                {
                    VisibilityMode(1);
                }
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region SupplierName Textbox KeyPress Event 
        private void txtSupplierName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
        }
        #endregion

        #region SupplierCode Textbox KeyPress Event 
        private void txtSupplierCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
        }
        #endregion

        #region City Textbox KeyPress Event 
        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
        }
        #endregion

        #region State Textbox KeyPress Event 
        private void txtState_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
        }
        #endregion

        #region District Textbox KeyPress Event 
        private void txtDistrict_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
        }
        #endregion

        #region Country Textbox KeyPress Event 
        private void txtCountry_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar == 32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Phone Textbox KeyPress Event 
        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar >= 48 && e.KeyChar <= 57)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
        }
        #endregion
    }
}
