using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using Mandya.BO;
using Mandya.BL;
using Mandya.Common;
using System.Globalization;

namespace WeightBridgeMandya.clientui
{
    public partial class Source : MetroForm
    {
        private static readonly log4net.ILog log =
        log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #region Initialize Component
        public Source()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Load Event
        private void Source_Load(object sender, EventArgs e)
        {
            try
            {
                BindSource();
                VisibilityMode(1);
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Bind Source Method
        public void BindSource()
        {
            try
            {
                ApplicationResult objResult = new ApplicationResult();
                SourceBL objSourceBL = new SourceBL();
                objResult = objSourceBL.Source_SelectAll();
                if (objResult != null)
                {
                    if (objResult.ResultDt.Rows.Count > 0)
                    {
                        cmbSearchSource.DataSource = objResult.ResultDt;
                        cmbSearchSource.ValueMember = SourceBO.SOURCE_SOURCEID;
                        cmbSearchSource.DisplayMember = SourceBO.SOURCE_SOURCENAME;

                        cmbSearchSource.DropDownStyle = ComboBoxStyle.DropDownList;
                        cmbSearchSource.AutoCompleteSource = AutoCompleteSource.ListItems;
                        cmbSearchSource.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
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
            cmbSearchSource.SelectedValue = "0";
            TxtSourceName.Text = "";
            //txtRemarks.Text = "";
            txtSourceCode.Text = "";
        }
        #endregion

        #region Save Button Click Event
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int intValidate = 0;
                if (TxtSourceName.Text.Trim() == "")
                {
                    MetroMessageBox.Show(this, "Enter Source Name.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }
                /*else if (txtSourceCode.Text.Trim() == "")
                {
                    MetroMessageBox.Show(this, "Enter Source Code", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }*/
                if (intValidate == 0)
                {
                    ApplicationResult objResult = new ApplicationResult();
                    SourceBO objSourceBO = new SourceBO();
                    SourceBL objSourceBL = new SourceBL();

                    int intValidateNameId = 0;
                    objSourceBO.SourceName = TxtSourceName.Text.Trim();
                    if (txtSourceCode.Text == "")
                    {
                        objSourceBO.SourceCode = "0";
                    }
                    else
                    {
                        objSourceBO.SourceCode = txtSourceCode.Text.Trim();
                    }
                    

                    if (btnSave.Text == "Save")
                    {
                        intValidateNameId = -1;
                    }
                    else if (btnSave.Text == "Update")
                    {
                        intValidateNameId = Convert.ToInt32(lblSourceId.Text);
                    }
                    objResult = objSourceBL.Source_ValidateName(objSourceBO.SourceName);
                    if (objResult != null)
                    {
                        if (objResult.ResultDt.Rows.Count > 0)
                        {
                           MetroMessageBox.Show(this, "Source Name already exist.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           
                        }
                        else
                        {
                            if (btnSave.Text == "Save")
                            {
                                objSourceBO.CreatedBy = 1;
                                objSourceBO.CreatedDate = DateTime.UtcNow.AddHours(5.5).ToString(CultureInfo.GetCultureInfo("en-GB"));
                                objResult = objSourceBL.Source_Insert(objSourceBO);
                                if (objResult.Status == ApplicationResult.CommonStatusType.Success)
                                {
                                    MetroMessageBox.Show(this, "Record Saved Successfully.", "WeighBridge", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                                }
                            }
                            else if (btnSave.Text == "Update")
                            {
                                objSourceBO.LastModifiedBy = 1;
                                objSourceBO.LastModifiedDate = DateTime.UtcNow.AddHours(5.5).ToString(CultureInfo.GetCultureInfo("en-GB"));
                                objSourceBO.SourceId = Convert.ToInt32(lblSourceId.Text);
                                objResult = objSourceBL.Source_Update(objSourceBO);
                                if (objResult.Status.ToString() == "Success")
                                {
                                    MetroMessageBox.Show(this, "Record Updated Successfully.", "WeighBridge",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MetroMessageBox.Show(this, "Source Name Already Exist.", "WeighBridge",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                                }
                            }
                            ClearAll();
                            BindSource();
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

        #region Close Button Click Event
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Clear Button Click Event
        private void btnClear_Click(object sender, EventArgs e)
        {
            TxtSourceName.Text = "";
            txtSourceCode.Text = "";
            ClearAll();
            VisibilityMode(1);
        }
        #endregion

        #region Source Code Leave event
        private void txtSourceCode_Leave(object sender, EventArgs e)
        {
            if (txtSourceCode.Text != "")
            {
                System.Text.RegularExpressions.Regex.IsMatch(txtSourceCode.Text, @"^\d$");
                int validNumbers = 0;
                bool isValid = int.TryParse(txtSourceCode.Text, out validNumbers);
                if (!isValid)
                {
                    MessageBox.Show("Numerics Only!");
                    txtSourceCode.Text = "";
                }
            }
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
                if (cmbSearchSource.SelectedValue.ToString() != "0")
                {
                    VisibilityMode(3);
                }
                else
                {
                    MetroMessageBox.Show(this, "Select Source Code.", "Schneider_WeighBridge", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "Schneider_WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (cmbSearchSource.SelectedValue.ToString() != "0")
                {
                    DialogResult result = MetroMessageBox.Show(this, "Do you really want to delete this record?", "Mandya WeighBridge", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        ApplicationResult objResult = new ApplicationResult();
                        SourceBL objSourceBL = new SourceBL();
                        objResult = objSourceBL.Source_Delete(Convert.ToInt32(cmbSearchSource.SelectedValue), 1, DateTime.UtcNow.AddHours(5.5).ToString(CultureInfo.GetCultureInfo("en-GB")));
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
                        BindSource();
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

        #region SearchSource_SelectionChangeCommitted Event
        private void cmbSearchSource_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbSearchSource.SelectedValue.ToString() != "0")
                {
                    ApplicationResult objResult = new ApplicationResult();
                    SourceBL objSourceBL = new SourceBL();
                    objResult = objSourceBL.Source_Select(Convert.ToInt32(cmbSearchSource.SelectedValue));
                    if (objResult != null)
                    {
                        if (objResult.ResultDt.Rows.Count > 0)
                        {
                            lblSourceId.Text = objResult.ResultDt.Rows[0][SourceBO.SOURCE_SOURCEID].ToString();
                            TxtSourceName.Text = objResult.ResultDt.Rows[0][SourceBO.SOURCE_SOURCENAME].ToString();
                            txtSourceCode.Text = objResult.ResultDt.Rows[0][SourceBO.SOURCE_SOURCECODE].ToString();
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
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "Schneider_WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region SourceName Textbox KeyPress Event
        private void TxtSourceName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8 || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar ==32)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
        }
        #endregion

        #region SourceName Textbox KeyPress Event
        private void txtSourceCode_KeyPress(object sender, KeyPressEventArgs e)
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
