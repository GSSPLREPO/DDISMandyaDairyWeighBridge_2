﻿using System;
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
    public partial class Route : MetroForm
    {
        private static readonly log4net.ILog log =
        log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        #region Initialize Component
        public Route()
        {
            InitializeComponent();
        }
        #endregion

        #region Form Load Event
        private void Route_Load(object sender, EventArgs e)
        {
            try
            {
                BindRoute();
                VisibilityMode(1);
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Bind Route Method
        public void BindRoute()
        {
            try
            {
                ApplicationResult objResult = new ApplicationResult();
                RouteBL objRouteBL = new RouteBL();
                objResult = objRouteBL.Route_SelectAll();
                if (objResult != null)
                {
                    if (objResult.ResultDt.Rows.Count > 0)
                    {
                        cmbSearchRoute.DataSource = objResult.ResultDt;
                        cmbSearchRoute.ValueMember = RouteBO.ROUTE_ROUTEID;
                        cmbSearchRoute.DisplayMember = RouteBO.ROUTE_ROUTENAME;

                        cmbSearchRoute.DropDownStyle = ComboBoxStyle.DropDownList;
                        cmbSearchRoute.AutoCompleteSource = AutoCompleteSource.ListItems;
                        cmbSearchRoute.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
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
            cmbSearchRoute.SelectedValue = "0";
            txtRouteName.Text = "";
            txtRouteCode.Text = "";
        }
        #endregion

        #region Save Button Click Event
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int intValidate = 0;
                if (txtRouteName.Text.Trim() == "")
                {
                    MetroMessageBox.Show(this, "Enter Route Name.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }
                /*else if (txtRouteCode.Text.Trim() == "")
                {
                    MetroMessageBox.Show(this, "Enter Route Code.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }*/
                if (intValidate == 0)
                {
                    ApplicationResult objResult = new ApplicationResult();
                    RouteBO objRouteBO = new RouteBO();
                    RouteBL objRouteBL = new RouteBL();

                    int intValidateNameId = 0;
                    objRouteBO.RouteName = txtRouteName.Text.Trim();
                    if (txtRouteCode.Text == "")
                    {
                        objRouteBO.RouteCode = "0";
                    }
                    else
                    {
                        objRouteBO.RouteCode = txtRouteCode.Text.Trim();
                    }
                    

                    if (btnSave.Text == "Save")
                    {
                        intValidateNameId = -1;
                    }
                    else if (btnSave.Text == "Update")
                    {
                        intValidateNameId = Convert.ToInt32(lblRouteID.Text);
                    }
                    objResult = objRouteBL.Route_ValidateName(objRouteBO.RouteName);
                    if (objResult != null)
                    {
                        if (objResult.ResultDt.Rows.Count > 0)
                        {
                            MetroMessageBox.Show(this, "Route Name already exist.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                           
                        }
                        else
                        {
                            if (btnSave.Text == "Save")
                            {
                                objRouteBO.CreatedBy = 1;
                                objRouteBO.CreatedDate = DateTime.UtcNow.AddHours(5.5);
                                objResult = objRouteBL.Route_Insert(objRouteBO);
                                if (objResult.Status == ApplicationResult.CommonStatusType.Success)
                                {
                                    MetroMessageBox.Show(this, "Record Saved Successfully.", "WeighBridge", MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                                }
                            }
                            else if (btnSave.Text == "Update")
                            {
                                objRouteBO.LastModifiedBy = 1;
                                objRouteBO.LastModifiedDate = DateTime.UtcNow.AddHours(5.5);
                                objRouteBO.RouteID = Convert.ToInt32(lblRouteID.Text);
                                objResult = objRouteBL.Route_Update(objRouteBO);
                                if (objResult.Status.ToString() == "Success")
                                {
                                    MetroMessageBox.Show(this, "Record Updated Successfully.", "WeighBridge",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);

                                }
                                else
                                {
                                    MetroMessageBox.Show(this, "Route Name Already Exist.", "WeighBridge",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                                }
                            }
                            ClearAll();
                            BindRoute();
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

        #region Close Button Click Event
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Clear Button Click Event
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearAll();
            VisibilityMode(1);
            cmbSearchRoute.SelectedIndex = 0;
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
                if (cmbSearchRoute.SelectedValue.ToString() != "0")
                {
                    VisibilityMode(3);
                    
                }
                else
                {
                    MetroMessageBox.Show(this, "Select Destination Code.", "Mandya WeighBridge", MessageBoxButtons.OK,
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
                if (cmbSearchRoute.SelectedValue.ToString() != "0")
                {
                    DialogResult result = MetroMessageBox.Show(this, "Do you really want to delete this record?", "Mandya WeighBridge", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        ApplicationResult objResult = new ApplicationResult();
                        RouteBL objRouteBL = new RouteBL();
                        objResult = objRouteBL.Route_Delete(Convert.ToInt32(cmbSearchRoute.SelectedValue), 1, DateTime.UtcNow.AddHours(5.5));
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
                        BindRoute();
                        VisibilityMode(1);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Select Route Name", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region SearchRoute_SelectionChangeCommitted Event
        private void cmbSearchRoute_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbSearchRoute.SelectedValue.ToString() != "0")
                {
                    ApplicationResult objResult = new ApplicationResult();
                    RouteBL objRouteBL = new RouteBL();
                    objResult = objRouteBL.Route_Select(Convert.ToInt32(cmbSearchRoute.SelectedValue));
                    if (objResult != null)
                    {
                        if (objResult.ResultDt.Rows.Count > 0)
                        {
                            lblRouteID.Text = objResult.ResultDt.Rows[0][RouteBO.ROUTE_ROUTEID].ToString();
                            txtRouteName.Text = objResult.ResultDt.Rows[0][RouteBO.ROUTE_ROUTENAME].ToString();
                            txtRouteCode.Text = objResult.ResultDt.Rows[0][RouteBO.ROUTE_ROUTECODE].ToString();
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

        #region Route Code Textbox Leave Event
        private void txtRouteCode_Leave(object sender, EventArgs e)
        {
            if (txtRouteCode.Text != "")
            {
                System.Text.RegularExpressions.Regex.IsMatch(txtRouteCode.Text, @"^\d$");
                int validNumbers = 0;
                bool isValid = int.TryParse(txtRouteCode.Text, out validNumbers);
                if (!isValid)
                {
                    MessageBox.Show("Numerics Only!");
                    txtRouteCode.Text = "";
                }
            }
        }
        #endregion

        #region RouteName Textbox KeyPress Event
        private void txtRouteName_KeyPress(object sender, KeyPressEventArgs e)
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

        #region RouteCode Textbox KeyPress Event
        private void txtRouteCode_KeyPress(object sender, KeyPressEventArgs e)
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
