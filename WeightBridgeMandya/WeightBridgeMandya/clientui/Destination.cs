using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Mandya.BL;
using Mandya.BO;
using Mandya.Common;
using System.Globalization;

namespace WeightBridgeMandya.clientui
{
    public partial class Destination : MetroForm
    {
        private static readonly log4net.ILog log =
        log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #region Initilize Component
        public Destination()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Load Event
        private void Destination_Load(object sender, EventArgs e)
        {
            try
            {
                BindDestination();
                VisibilityMode(1);
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Bind Destination Method
        public void BindDestination()
        {
            try
            {
                ApplicationResult objResult = new ApplicationResult();
                DestinationBL objDestinationBL = new DestinationBL();
                objResult = objDestinationBL.Destination_SelectAll();
                if (objResult != null)
                {
                    if (objResult.ResultDt.Rows.Count > 0)
                    {
                        cmbSearchDestination.DataSource = objResult.ResultDt;
                        cmbSearchDestination.ValueMember = DestinationBO.DESTINATION_DESTINATIONID;
                        cmbSearchDestination.DisplayMember = DestinationBO.DESTINATION_DESTINATIONNAME;

                        cmbSearchDestination.DropDownStyle = ComboBoxStyle.DropDownList;
                        cmbSearchDestination.AutoCompleteSource = AutoCompleteSource.ListItems;
                        cmbSearchDestination.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
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
                btnEdit.Visible = false;
                btnAddnew.Visible = true;
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
            cmbSearchDestination.SelectedValue = "0";
            TxtDestinationName.Text = "";
            txtDestinationCode.Text = "";
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
                if (cmbSearchDestination.SelectedValue.ToString() != "0")
                {
                    VisibilityMode(3);
                }
                else
                {
                    MetroMessageBox.Show(this, "Select Destination Code.", "WeighBridge", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (cmbSearchDestination.SelectedValue.ToString() != "0")
                {
                    DialogResult result = MetroMessageBox.Show(this, "Do you really want to delete this record?", "WeighBridge", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        ApplicationResult objResult = new ApplicationResult();
                        DestinationBL objDestinationBL = new DestinationBL();
                        objResult = objDestinationBL.Destination_Delete(Convert.ToInt32(cmbSearchDestination.SelectedValue), 1, DateTime.UtcNow.AddHours(5.5).ToString(CultureInfo.GetCultureInfo("en-GB")));
                        if (objResult.Status.ToString() == "Success")
                        {

                            MetroMessageBox.Show(this, "Record Deleted Successfully.", "WeighBridge",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "You cannot delete this record. Because it is in use.",
                                "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        ClearAll();
                        BindDestination();
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

        #region Save Button Click Event
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int intValidate = 0;
                if (TxtDestinationName.Text.Trim() == "")
                {
                    MetroMessageBox.Show(this, "Enter Destination Name.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }
               /* else if (txtDestinationCode.Text.Trim() == "")
                {
                    MetroMessageBox.Show(this, "Enter Destination Code.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }*/
                if (intValidate == 0)
                {
                    ApplicationResult objResult = new ApplicationResult();
                    DestinationBO objDestinationBO = new DestinationBO();
                    DestinationBL objDestinationBL = new DestinationBL();

                    int intValidateNameId = 0;
                    objDestinationBO.DESTINATIONName = TxtDestinationName.Text.Trim();
                    if (txtDestinationCode.Text == "")
                    {
                        objDestinationBO.DESTINATIONCode = "0";
                    }
                    else
                    {
                        objDestinationBO.DESTINATIONCode = txtDestinationCode.Text;
                    }
                    

                    if (btnSave.Text == "Save")
                    {
                        intValidateNameId = -1;
                    }
                    else if (btnSave.Text == "Update")
                    {
                        intValidateNameId = Convert.ToInt32(lblDestinationId.Text);
                    }
                    objResult = objDestinationBL.Destination_ValidateName(objDestinationBO.DESTINATIONName);
                    if (objResult != null)
                    {
                        if (objResult.ResultDt.Rows.Count > 0)
                        {
                            MetroMessageBox.Show(this, "Destination Name already exist.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (btnSave.Text == "Save")
                            {
                                objDestinationBO.CreatedBy = 1;
                                objDestinationBO.CreatedDate = DateTime.UtcNow.AddHours(5.5).ToString(CultureInfo.GetCultureInfo("en-GB"));
                                objResult = objDestinationBL.Destination_Insert(objDestinationBO);
                                if (objResult.Status == ApplicationResult.CommonStatusType.Success)
                                {
                                    MetroMessageBox.Show(this, "Record Saved Successfully.", "WeighBridge", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                                }
                            }
                            else if (btnSave.Text == "Update")
                            {
                                objDestinationBO.LastModifiedBy = 1;
                                objDestinationBO.LastModifiedDate = DateTime.UtcNow.AddHours(5.5).ToString(CultureInfo.GetCultureInfo("en-GB"));
                                objDestinationBO.DESTINATIONId = Convert.ToInt32(lblDestinationId.Text);
                                objResult = objDestinationBL.Destination_Update(objDestinationBO);
                                if (objResult.Status.ToString() == "Success")
                                {
                                    MetroMessageBox.Show(this, "Record Updated Successfully.", "WeighBridge",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                                }
                                else
                                {
                                    MetroMessageBox.Show(this, "Destination Name Already Exist.", "WeighBridge",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                                }
                            }
                            ClearAll();
                            BindDestination();
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
            finally
            {

            }
        }
        #endregion

        #region Clear Button Click Event
        private void btnClear_Click(object sender, EventArgs e)
        {
            TxtDestinationName.Text = "";
            txtDestinationCode.Text = "";
            ClearAll();
            VisibilityMode(1);
        }
        #endregion

        #region SearchDestination_SelectionChangeCommitted Event
        private void cmbSearchDestination_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbSearchDestination.SelectedValue.ToString() != "0")
                {
                    ApplicationResult objResult = new ApplicationResult();
                    DestinationBL objDestinationBL = new DestinationBL();
                    objResult = objDestinationBL.Destination_Select(Convert.ToInt32(cmbSearchDestination.SelectedValue));
                    if (objResult != null)
                    {
                        if (objResult.ResultDt.Rows.Count > 0)
                        {
                            lblDestinationId.Text = objResult.ResultDt.Rows[0][DestinationBO.DESTINATION_DESTINATIONID].ToString();
                            TxtDestinationName.Text = objResult.ResultDt.Rows[0][DestinationBO.DESTINATION_DESTINATIONNAME].ToString();
                            txtDestinationCode.Text = objResult.ResultDt.Rows[0][DestinationBO.DESTINATION_DESTINATIONCODE].ToString();
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
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region DestinationCode Leave event
        private void txtDestinationCode_Leave(object sender, EventArgs e)
        {
            if (txtDestinationCode.Text != "")
            {
                System.Text.RegularExpressions.Regex.IsMatch(txtDestinationCode.Text, @"^\d$");
                int validNumbers = 0;
                bool isValid = int.TryParse(txtDestinationCode.Text, out validNumbers);
                if (!isValid)
                {
                    MessageBox.Show("Numerics Only!");
                    txtDestinationCode.Text = "";
                }
            }
        }
        #endregion

        #region DestinationName Textbox KeyPress Event
        private void TxtDestinationName_KeyPress(object sender, KeyPressEventArgs e)
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

        #region DestinationCode Textbox KeyPress Event

        private void txtDestinationCode_KeyPress(object sender, KeyPressEventArgs e)
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
