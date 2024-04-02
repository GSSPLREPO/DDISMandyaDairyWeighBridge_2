using System;
using System.Windows.Forms;
using Mandya.BO;
using Mandya.BL;
using Mandya.Common;
using MetroFramework;
using MetroFramework.Forms;

namespace WeightBridgeMandya.clientui
{
    public partial class Customer : MetroForm
    {

        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public Customer()
        {
            InitializeComponent();
        }

        #region Form Load Event
        private void Customer_Load(object sender, EventArgs e)
        {
            try
            {
                BindCustomer();
                VisibilityMode(1);
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Bind Customer
        public void BindCustomer()
        {
            try
            {
                ApplicationResult objResult = new ApplicationResult();
                CustomerBL objCustomerBL = new CustomerBL();
                objResult = objCustomerBL.Customer_SelectAll();
                if (objResult != null)
                {
                    if (objResult.ResultDt.Rows.Count > 0)
                    {
                        cmbSearchCustomer.DataSource = objResult.ResultDt;
                        cmbSearchCustomer.ValueMember = CustomerBO.CUSTOMER_CUSTOMERID;
                        cmbSearchCustomer.DisplayMember = CustomerBO.CUSTOMER_CUSTOMERNAME;

                        cmbSearchCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
                        cmbSearchCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
                        cmbSearchCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                    }
                }

            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "Schneider_WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Save Button Click Event
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int intValidate = 0;
                
                if (txtCustomerName.Text.Trim() == "")
                {
                    MetroMessageBox.Show(this, "Enter Customer Name.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }
                /*else if (txtCustomerCode.Text.Trim() == "")
                {
                    MetroMessageBox.Show(this, "Enter Customer Code.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }*/

                if (intValidate == 0)
                {
                    ApplicationResult objResult = new ApplicationResult();
                    CustomerBO objCustomerBO = new CustomerBO();
                    CustomerBL objCustomerBL = new CustomerBL();

                    int intValidateNameId = 0;

                    objCustomerBO.CustomerName = txtCustomerName.Text;
                    if (txtCustomerCode.Text == "")
                    {
                        objCustomerBO.CustomerCode = "0";
                    }
                    else
                    {
                        objCustomerBO.CustomerCode = txtCustomerCode.Text;
                    }
                    
                    objCustomerBO.Address = txtAddress.Text;
                    objCustomerBO.State = txtState.Text;
                    objCustomerBO.District = txtDistrict.Text;
                    objCustomerBO.Country = txtCountry.Text;
                    objCustomerBO.Phone = txtPhone.Text;
                    objCustomerBO.Email = txtEmail.Text;
                    objCustomerBO.City = txtCity.Text;
                    objCustomerBO.Remarks = txtRemark.Text;
                    if (btnSave.Text == "Save")
                    {
                        intValidateNameId = -1;
                    }
                    else if (btnSave.Text == "Update")
                    {
                        intValidateNameId = Convert.ToInt32(lblCustomerId.Text);
                    }
                    objResult = objCustomerBL.Customer_ValidateName(objCustomerBO.CustomerName);
                    if (objResult != null)
                    {
                        if (objResult.ResultDt.Rows.Count > 0)
                        {
                            MetroMessageBox.Show(this, "Customer Name already exist.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (btnSave.Text == "Save")
                            {
                                objCustomerBO.CreatedByID = 1;
                                objCustomerBO.CreatedByDate = DateTime.UtcNow.AddHours(5.5);
                                objResult = objCustomerBL.Customer_Insert(objCustomerBO);
                                if (objResult.Status == ApplicationResult.CommonStatusType.Success)
                                {
                                    MetroMessageBox.Show(this, "Record Saved Successfully.", "WeighBridge", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                                }
                            }
                            else if (btnSave.Text == "Update")
                            {
                                objCustomerBO.LastModifiedByID = 1;
                                objCustomerBO.LastModifiedByDate = DateTime.UtcNow.AddHours(5.5);
                                objCustomerBO.CustomerID = Convert.ToInt32(lblCustomerId.Text);
                                objResult = objCustomerBL.Customer_Update(objCustomerBO);
                                if (objResult.Status.ToString() == "Success")
                                {
                                    MetroMessageBox.Show(this, "Record Updated Successfully.", "WeighBridge",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MetroMessageBox.Show(this, "Customer Name Already Exist.", "WeighBridge",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                                }
                            }
                            ClearAll();
                            BindCustomer();
                            VisibilityMode(1);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Clear Button Click Event
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
            VisibilityMode(1);
            cmbSearchCustomer.SelectedValue = "0";
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
                if (cmbSearchCustomer.SelectedValue.ToString() != "0")
                {
                    VisibilityMode(3);

                }
                else
                {
                    MetroMessageBox.Show(this, "Select Supplier", "Mandya WeighBridge", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Delete Button Click Event
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbSearchCustomer.SelectedValue.ToString() != "0")
                {
                    DialogResult result = MetroMessageBox.Show(this, "Do you really want to delete this record?", "Mandya WeighBridge", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        ApplicationResult objResult = new ApplicationResult();
                        CustomerBL objCustomerBL = new CustomerBL();
                        objResult = objCustomerBL.Customer_Delete(Convert.ToInt32(cmbSearchCustomer.SelectedValue),Convert.ToInt32(Program.intUserId),  DateTime.UtcNow.AddHours(5.5));
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
                        BindCustomer();
                        VisibilityMode(1);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Select Supplier.", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Close Button Click Event
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Combobox Search Supplier Selection Change  Committed Event
        private void cmbSearchCustomer_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbSearchCustomer.SelectedValue.ToString() != "0")
                {
                    ApplicationResult objResult = new ApplicationResult();
                    CustomerBL objCustomerBL = new CustomerBL();

                    objResult = objCustomerBL.Customer_Select(Convert.ToInt32(cmbSearchCustomer.SelectedValue));
                    if (objResult != null)
                    {
                        if (objResult.ResultDt.Rows.Count > 0)
                        {
                            lblCustomerId.Text = objResult.ResultDt.Rows[0][CustomerBO.CUSTOMER_CUSTOMERID].ToString();
                            txtCustomerName.Text = objResult.ResultDt.Rows[0][CustomerBO.CUSTOMER_CUSTOMERNAME].ToString();
                            txtCustomerCode.Text = objResult.ResultDt.Rows[0][CustomerBO.CUSTOMER_CUSTOMERCODE].ToString();
                            txtAddress.Text = objResult.ResultDt.Rows[0][CustomerBO.CUSTOMER_ADDRESS].ToString();
                            txtState.Text = objResult.ResultDt.Rows[0][CustomerBO.CUSTOMER_STATE].ToString();
                            txtDistrict.Text = objResult.ResultDt.Rows[0][CustomerBO.CUSTOMER_DISTRICT].ToString();
                            txtCountry.Text = objResult.ResultDt.Rows[0][CustomerBO.CUSTOMER_COUNTRY].ToString();
                            txtPhone.Text = objResult.ResultDt.Rows[0][CustomerBO.CUSTOMER_PHONE].ToString();
                            txtEmail.Text = objResult.ResultDt.Rows[0][CustomerBO.CUSTOMER_EMAIL].ToString();
                            txtRemark.Text = objResult.ResultDt.Rows[0][CustomerBO.CUSTOMER_REMARKS].ToString();
                            txtCity.Text = objResult.ResultDt.Rows[0][CustomerBO.CUSTOMER_CITY].ToString();
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
            txtCustomerName.Text = "";
            txtCustomerCode.Text = "";
            txtAddress.Text = "";
            txtState.Text = "";
            txtDistrict.Text = "";
            txtCountry.Text = "";
            txtCity.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtRemark.Text = "";
        }
        #endregion

        #region CustomerName Textbox KeyPress Event 
        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
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

        #region CustomerCode Textbox KeyPress Event 
        private void txtCustomerCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar>=48 && e.KeyChar<=57 )
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
