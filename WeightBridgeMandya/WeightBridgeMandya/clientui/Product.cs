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
using Mandya.BL;
using Mandya.BO;
using MetroFramework;
using MetroFramework.Forms;
using System.Globalization;

namespace WeightBridgeMandya.clientui
{
    public partial class Product : MetroForm
    {
        private static readonly log4net.ILog log =
        log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #region Initialize Component
        public Product()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Load Event
        private void Product_Load(object sender, EventArgs e)
        {
            try
            {
                VisibilityMode(1);
                BindProductName();
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Bind Product Name
        public void BindProductName()
        {
            try
            {
                ApplicationResult objResult = new ApplicationResult();
                ProductBL objProductBL = new ProductBL();
                objResult = objProductBL.Product_SelectAll();
                if (objResult != null)
                {
                    if (objResult.ResultDt.Rows.Count > 0)
                    {
                       
                        cmbProductName.DataSource = objResult.ResultDt;
                        cmbProductName.ValueMember = ProductBO.PRODUCT_PRODUCTID;
                        cmbProductName.DisplayMember = ProductBO.PRODUCT_PRODUCTNAME;

                        cmbProductName.DropDownStyle = ComboBoxStyle.DropDownList;
                        cmbProductName.AutoCompleteSource = AutoCompleteSource.ListItems;
                        cmbProductName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
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

        #region Save Button Click Event
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int intValidate = 0;
                if (txtProductName.Text.Trim() == "")
                {
                    MetroMessageBox.Show(this, "Enter Product Name.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                    return;
                }
                /*else if (txtProductCode.Text.Trim() == "")
                {
                    MetroMessageBox.Show(this, "Enter Product Code.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }*/
                if (intValidate == 0)
                {
                    ApplicationResult objResult = new ApplicationResult();
                    ProductBO objProductBO = new ProductBO();
                    ProductBL objProductBL = new ProductBL();

                    int intValidateNameId = 0;
                    objProductBO.ProductName = txtProductName.Text.Trim();
                    if (txtProductCode.Text == "")
                    {
                        objProductBO.ProductCode = "0";
                    }
                    else
                    {
                        objProductBO.ProductCode = txtProductCode.Text.Trim();
                    }
                    

                    if (btnSave.Text == "Save")
                    {
                        intValidateNameId = -1;
                    }
                    else if (btnSave.Text == "Update")
                    {
                        intValidateNameId = Convert.ToInt32(lblProductName.Text);
                    }
                    objResult = objProductBL.Product_ValidateName(objProductBO.ProductName);

                    
                    if (objResult != null)
                    {
                        if (objResult.ResultDt.Rows.Count > 0)
                        {
                            MetroMessageBox.Show(this, "Product Name already exist.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                          
                        }
                        else
                        {
                            if (btnSave.Text == "Save")
                            {
                                objProductBO.CreatedBy = Program.intUserId;
                                objProductBO.CreatedDate = DateTime.UtcNow.AddHours(5.5).ToString(CultureInfo.GetCultureInfo("en-GB"));
                                objResult = objProductBL.Product_Insert(objProductBO);
                                if (objResult.Status == ApplicationResult.CommonStatusType.Success)
                                {
                                    MetroMessageBox.Show(this, "Record Saved Successfully.", "WeighBridge", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                                    BindProductName();
                                }
                            }
                            else if (btnSave.Text == "Update")
                            {
                                objProductBO.LastModifiedBy = Program.intUserId;
                                objProductBO.LastModifiedDate = DateTime.UtcNow.AddHours(5.5).ToString(CultureInfo.GetCultureInfo("en-GB"));
                                objProductBO.ProductId = Convert.ToInt32(lblProductName.Text);
                                objResult = objProductBL.Product_Update(objProductBO);
                                if (objResult.Status.ToString() == "Success")
                                {
                                    MetroMessageBox.Show(this, "Record Updated Successfully.", "WeighBridge",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                                    BindProductName();
                                }
                                else
                                {
                                    MetroMessageBox.Show(this, "Product Name Already Exist.", "WeighBridge",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                                }
                            }
                            ClearAll();
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
            finally
            {

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
                pnlButton.Visible = false;
                btnSave.Text = "Save";
                btnEdit.Visible = false;
                btnDelete.Visible = false;
                lblProductName.Text = "";
                btnAddnew.Visible = true;

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
            lblProductName.Text = "";
            txtProductName.Text = "";
            txtProductCode.Text = "";
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
                if (cmbProductName.SelectedValue.ToString() != "0")
                {
                    VisibilityMode(3);
                }
                else
                {
                    MetroMessageBox.Show(this, "Select Product Name.", "Mandya WeighBridge", MessageBoxButtons.OK,
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
                if (cmbProductName.SelectedValue.ToString() != "0")
                {
                    DialogResult result = MetroMessageBox.Show(this, "Do you really want to delete this record?", "Mandya WeighBridge", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        ApplicationResult objResult = new ApplicationResult();
                        ProductBL objProductBL = new ProductBL();
                        objResult = objProductBL.Product_Delete(Convert.ToInt32(cmbProductName.SelectedValue), Program.intUserId, DateTime.UtcNow.AddHours(5.5).ToString(CultureInfo.GetCultureInfo("en-GB")));
                        if (objResult.Status.ToString() == "Success")
                        {

                            MetroMessageBox.Show(this, "Record Deleted Successfully.", "Mandya WeighBridge",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            BindProductName();
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "You cannot delete this record. Because it is in use.",
                                "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        ClearAll();
                        VisibilityMode(1);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Select Unit Category.", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        }
        #endregion

        #region Product Name Combobox selection change committed
        private void cmbProductName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbProductName.SelectedValue.ToString() != "0")
                {
                    ApplicationResult objResult = new ApplicationResult();
                    ProductBL objProductBL = new ProductBL();
                    objResult = objProductBL.Product_Select(Convert.ToInt32(cmbProductName.SelectedValue));
                    if (objResult != null)
                    {
                        if (objResult.ResultDt.Rows.Count > 0)
                        {
                            lblProductName.Text = objResult.ResultDt.Rows[0][ProductBO.PRODUCT_PRODUCTID].ToString();
                            txtProductName.Text = objResult.ResultDt.Rows[0][ProductBO.PRODUCT_PRODUCTNAME].ToString();
                            txtProductCode.Text = objResult.ResultDt.Rows[0][ProductBO.PRODUCT_PRODUCTCODE].ToString();
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

        #region Textbox Product Code Leave Event
        private void txtProductCode_Leave(object sender, EventArgs e)
        {
            if (txtProductCode.Text != "")
            {
                System.Text.RegularExpressions.Regex.IsMatch(txtProductCode.Text, @"^\d$");
                int validNumbers = 0;
                bool isValid = int.TryParse(txtProductCode.Text, out validNumbers);
                if (!isValid)
                {
                    MessageBox.Show("Numerics Only!");
                    txtProductCode.Text = "";
                }
            }
        }
        #endregion

        #region ProductName Textbox KeyPress Event
        private void txtProductName_KeyPress(object sender, KeyPressEventArgs e)
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

        #region ProductCode Textbox KeyPress Event
        private void txtProductCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 ||e.KeyChar>=48 && e.KeyChar<=57)
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
