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
using Mandya.Common;
using Mandya.BL;
using Mandya.BO;
using System.Threading;
using System.Configuration;
using System.IO.Ports;
using System.Globalization;
using MetroFramework.Controls;

namespace WeightBridgeMandya.clientui
{
    public partial class Vehicle : MetroForm
    {

        private static readonly log4net.ILog log =
        log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private string _rxString;
        private string strMode = string.Empty;
        string[] strPortSetup = ConfigurationSettings.AppSettings["Port"].ToString().Split('~');

        #region Initialize Component
        public Vehicle()
        {
            InitializeComponent();
            spWeighBridge.PortName = strPortSetup[0];
            spWeighBridge.BaudRate = Convert.ToInt32(strPortSetup[1]);
            spWeighBridge.DataBits = 8;
            spWeighBridge.StopBits = StopBits.One;
            spWeighBridge.Parity = Parity.None;
        }
        #endregion

        #region Declaration
        private DataTable dtVehicleType = new DataTable();
        private DataTable dtCompartment = new DataTable();
        #endregion

        #region Serial port DataReceived event
        private void spWeighBridge_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                if (!spWeighBridge.IsOpen)
                {
                    spWeighBridge.Open();
                }
                Thread.Sleep(500);
                _rxString = "";
                _rxString = spWeighBridge.ReadExisting();
                BeginInvoke(new EventHandler(getstring));
            }
            catch (Exception ex)
            {
                if (spWeighBridge.IsOpen)
                {
                    spWeighBridge.Close();
                }
                log.Error("error", ex);
                // MetroMessageBox.Show(this, "COM-Port for WeighBridge is not available. Check Connection with WeighBridge", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Form Load Event
        private void Vehicle_Load(object sender, EventArgs e)
        {
            try
            {
                DefineVehicleType();
                BindVehicleTypeRow();
                DefineCompartment();
                BindCompartmentRow();
                BindRoute();
                BindVehicleNumber();
                BindVehicleType();
                BindCompartment();
                VisibilityMode(1);
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Bind Vehicle Method
        public void BindVehicleNumber()
        {
            try
            {
                ApplicationResult objResult = new ApplicationResult();
                VehicleBL objVehicleBL = new VehicleBL();
                objResult = objVehicleBL.Vehicle_SelectAll();
                if (objResult != null)
                {
                    if (objResult.ResultDt.Rows.Count > 0)
                    {
                        cmbSearchTanker.DataSource = objResult.ResultDt;
                        cmbSearchTanker.ValueMember = VehicleBO.VEHICLE_VEHICLEID;
                        cmbSearchTanker.DisplayMember = VehicleBO.VEHICLE_VEHICLENUMBER;

                        cmbSearchTanker.DropDownStyle = ComboBoxStyle.DropDownList;
                        cmbSearchTanker.AutoCompleteSource = AutoCompleteSource.ListItems;
                        cmbSearchTanker.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
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

        #region getString from Com port method
        public void getstring(object sender, EventArgs e)
        {
            string strTare = _rxString.Substring(_rxString.IndexOf(":") + 2, 10);
            txtTareWeight.Text = strTare.Trim();
            spWeighBridge.Close();
            btnCapture.Text = "Capture";
            btnCapture.Refresh();
        }
        #endregion

        #region Define Vehicle Type DataTable
        private void DefineVehicleType()
        {
            dtVehicleType.Columns.Add("Id", typeof(int));
            dtVehicleType.Columns.Add("VehicleType", typeof(string));
        }
        #endregion

        #region Define Vehicle Type Table Row
        public void BindVehicleTypeRow()
        {
            dtVehicleType.Rows.Add(0, "--Select--");
            dtVehicleType.Rows.Add(1, "Tanker");
            dtVehicleType.Rows.Add(2, "Trailor");
            dtVehicleType.Rows.Add(3, "Truck");

        }

        #endregion

        #region Define Compartments DataTable
        private void DefineCompartment()
        {
            dtCompartment.Columns.Add("Id", typeof(int));
            dtCompartment.Columns.Add("Compartment", typeof(string));
        }
        #endregion

        #region Define Compartmets Table Row
        public void BindCompartmentRow()
        {
            dtCompartment.Rows.Add(0, "--Select--");
            dtCompartment.Rows.Add(1, "1");
            dtCompartment.Rows.Add(2, "2");
            dtCompartment.Rows.Add(3, "3");
        }
        #endregion

        #region Bind Vehicle Type

        public void BindVehicleType()
        {
            cmbVehicleType.DataSource = dtVehicleType;
            cmbVehicleType.ValueMember = dtVehicleType.Columns["Id"].ToString();
            cmbVehicleType.DisplayMember = dtVehicleType.Columns["VehicleType"].ToString();

        }

        #endregion

        #region Bind Compartment

        public void BindCompartment()
        {
            cmbCompartments.DataSource = dtCompartment;
            cmbCompartments.ValueMember = dtCompartment.Columns["Id"].ToString();
            cmbCompartments.DisplayMember = dtCompartment.Columns["Compartment"].ToString();

        }

        #endregion

        #region Bind Route ComboBox
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
                        cmbRouteName.DataSource = objResult.ResultDt;
                        cmbRouteName.ValueMember = RouteBO.ROUTE_ROUTEID;
                        cmbRouteName.DisplayMember = RouteBO.ROUTE_ROUTENAME;

                        cmbRouteName.DropDownStyle = ComboBoxStyle.DropDownList;
                        cmbRouteName.AutoCompleteSource = AutoCompleteSource.ListItems;
                        cmbRouteName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
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
                btnDelete.Visible = false;
                pnlButton.Visible = false;
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
                btnEdit.Visible = true;
                btnDelete.Visible = true;
                btnAddnew.Visible = false;

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
            txtDriverName.Text = "";
            txtCapacity.Text = "";
            txtRemarks.Text = "";
            txtTareWeight.Text = "";
            txtVehicleNumber.Text = "";
        }
        #endregion

        #region Validation of Numeric Value
        private void txtCapacity_Leave(object sender, EventArgs e)
        {
            if (txtCapacity.Text != "")
            {
                System.Text.RegularExpressions.Regex.IsMatch(txtCapacity.Text, @"\d+");
                int validNumbers = 0;
                bool isValid = int.TryParse(txtCapacity.Text, out validNumbers);
                if (!isValid)
                {
                    MessageBox.Show("Numerics Only");
                    txtCapacity.Text = "";
                }
            }
        }

        private void txtTareWeight_Leave(object sender, EventArgs e)
        {
            if (txtTareWeight.Text != "")
            {
                System.Text.RegularExpressions.Regex.IsMatch(txtTareWeight.Text, @"\d+");
                int validNumbers = 0;
                bool isValid = int.TryParse(txtTareWeight.Text, out validNumbers);
                if (!isValid)
                {
                    MessageBox.Show("Numerics Only");
                    txtTareWeight.Text = "";
                }
            }
        }
        #endregion

        #region Combobox Search Tanker Selection Change  Committed Event
        private void cmbSearchTanker_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                if (cmbSearchTanker.SelectedValue.ToString() != "0")
                {
                    ApplicationResult objResult = new ApplicationResult();
                    VehicleBL objVehicleBL = new VehicleBL();
                    objResult = objVehicleBL.Vehicle_Select(Convert.ToInt32(cmbSearchTanker.SelectedValue));
                    if (objResult != null)
                    {
                        if (objResult.ResultDt.Rows.Count > 0)
                        {

                            lblVehicleId.Text = objResult.ResultDt.Rows[0][VehicleBO.VEHICLE_VEHICLEID].ToString();
                            txtVehicleNumber.Text = objResult.ResultDt.Rows[0][VehicleBO.VEHICLE_VEHICLENUMBER].ToString();
                            txtCapacity.Text = objResult.ResultDt.Rows[0][VehicleBO.VEHICLE_CAPACITY].ToString();
                            txtDriverName.Text = objResult.ResultDt.Rows[0][VehicleBO.VEHICLE_DRIVERNAME].ToString();
                            txtTareWeight.Text = objResult.ResultDt.Rows[0][VehicleBO.VEHICLE_TAREWEIGHT].ToString();
                            txtRemarks.Text = objResult.ResultDt.Rows[0][VehicleBO.VEHICLE_REMARKS].ToString();
                            cmbCompartments.SelectedValue = Convert.ToInt32(objResult.ResultDt.Rows[0][VehicleBO.VEHICLE_COMPARTMENTS].ToString());
                            cmbVehicleType.SelectedValue = objResult.ResultDt.Rows[0][VehicleBO.VEHICLE_VEHICLETYPE].ToString();
                            cmbRouteName.SelectedValue = Convert.ToInt32(objResult.ResultDt.Rows[0][VehicleBO.VEHICLE_RouteID].ToString());
                            VisibilityMode(2);
                            btnAddnew.Visible = false;
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

        #region Save Button Click Event
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int intValidate = 0;
                int length = Convert.ToInt32(txtVehicleNumber.Text.Length);
                if (txtVehicleNumber.Text.Trim() == "")
                {
                    MetroMessageBox.Show(this, "Enter Tanker No.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }
                else if (length < 8)
                {
                    MetroMessageBox.Show(this, "Enter Valid Tanker No.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }
                /*else if (cmbCompartments.SelectedValue.ToString() == "0")
                {
                    MetroMessageBox.Show(this, "Select Compartment", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }
                else if (cmbVehicleType.SelectedValue.ToString() == "0")
                {
                    MetroMessageBox.Show(this, "Select VehicleType", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }
                else if (cmbRouteName.SelectedValue.ToString() == "0")
                {
                    MetroMessageBox.Show(this, "Enter Route Name", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }
                else if (txtTareWeight.Text.Trim() == "")
                {
                    MetroMessageBox.Show(this, "Press Capture Button for Tare Weight", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }
                else if (txtDriverName.Text.Trim() == "")
                {
                    MetroMessageBox.Show(this, "Enter Driver Name", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }*/
                if (intValidate == 0)
                {
                    ApplicationResult objResult = new ApplicationResult();
                    VehicleBO objVehicleBO = new VehicleBO();
                    VehicleBL objVehicleBL = new VehicleBL();
                    int intValidateNameId = 0;
                    objVehicleBO.VehicleNumber = txtVehicleNumber.Text.Trim();
                    if (txtCapacity.Text == "")
                    {
                        objVehicleBO.Capacity = 0;
                    }
                    else
                    {
                        objVehicleBO.Capacity = Convert.ToInt32(txtCapacity.Text.Trim());
                    }

                    if (txtTareWeight.Text == "")
                    {
                        objVehicleBO.TareWeight = 0;
                    }
                    else
                    {
                        objVehicleBO.TareWeight = Convert.ToDouble(txtTareWeight.Text.Trim());
                    }
                    objVehicleBO.Compartments = Convert.ToInt32(cmbCompartments.SelectedValue);
                    objVehicleBO.Compartments = Convert.ToInt32(cmbCompartments.SelectedValue);
                    objVehicleBO.VehicleType = Convert.ToInt32(cmbVehicleType.SelectedValue);
                    objVehicleBO.DriverName = txtDriverName.Text;
                    objVehicleBO.RouteID = Convert.ToInt32(cmbRouteName.SelectedValue);
                    objVehicleBO.Remarks = txtRemarks.Text;
                    objVehicleBO.IsActive = 0;
                    txtVehicleNumber.Text.ToUpper();

                    if (btnSave.Text == "Save")
                    {
                        intValidateNameId = -1;
                    }
                    else if (btnSave.Text == "Update")
                    {
                        intValidateNameId = Convert.ToInt32(lblVehicleId.Text);
                    }


                    if (btnSave.Text == "Save")
                    {
                        objResult = objVehicleBL.Vehicle_ValidateName(objVehicleBO.VehicleNumber);

                        if (objResult.ResultDt.Rows.Count > 0)
                        {
                            if (objResult.ResultDt.Rows[0]["VehicleNumber"].ToString() == objVehicleBO.VehicleNumber.ToString())
                            {
                                MetroMessageBox.Show(this, "Tanker No already exist.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        else
                        {
                            objVehicleBO.CreatedBy = 1;
                            //Program.intUserId;
                            objVehicleBO.CreatedDate = DateTime.UtcNow.AddHours(5.5).ToString(CultureInfo.GetCultureInfo("en-GB"));
                            objResult = objVehicleBL.Vehicle_Insert(objVehicleBO);
                            if (objResult.Status == ApplicationResult.CommonStatusType.Success)
                            {
                                MetroMessageBox.Show(this, "Record Saved Successfully.", "WeighBridge", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                        }
                        
                    }
                    else if (btnSave.Text == "Update")
                    {
                        objVehicleBO.LastModifiedBy = 1;
                        objVehicleBO.LastModifiedDate = DateTime.UtcNow.AddHours(5.5).ToString(CultureInfo.GetCultureInfo("en-GB"));
                        objVehicleBO.VehicleId = Convert.ToInt32(lblVehicleId.Text);
                        objResult = objVehicleBL.Vehicle_Update(objVehicleBO);
                        if (objResult.Status == ApplicationResult.CommonStatusType.Success)
                        {
                            MetroMessageBox.Show(this, "Record Updated Successfully.", "WeighBridge", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information);

                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Tanker No Already Exist.", "WeighBridge", MessageBoxButtons.OK,
                                   MessageBoxIcon.Warning);
                        }
                    }
                    ClearAll();
                    BindVehicleNumber();
                    VisibilityMode(1);
                    txtVehicleNumber.Enabled = true;

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
            ClearAll();
            VisibilityMode(1);
            cmbSearchTanker.SelectedValue = "0";
        }
        #endregion

        #region Close Button Click Event
        private void btnClose_Click(object sender, EventArgs e)
        {
            if (spWeighBridge.IsOpen)
            {
                spWeighBridge.Close();
            }
            this.Close();
        }
        #endregion

        #region Capture Button Click Event
        private void btnCapture_Click(object sender, EventArgs e)
        {
            try
            {
                if (spWeighBridge.IsOpen)
                {
                    spWeighBridge.Close();
                }
                spWeighBridge.Open();
                btnCapture.Text = "Processing";
                btnCapture.Refresh();
            }
            catch (Exception ex)
            {
                if (spWeighBridge.IsOpen)
                {
                    spWeighBridge.Close();
                }
                log.Error("error", ex);
                //MetroMessageBox.Show(this, "COM-Port for WeighBridge is not available. Check Connection with WeighBridge", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (cmbSearchTanker.SelectedValue.ToString() != "0")
                {
                    VisibilityMode(3);

                    txtVehicleNumber.Enabled = false;
                }
                else
                {
                    MetroMessageBox.Show(this, "Select Tanker Number.", "Mandya WeighBridge", MessageBoxButtons.OK,
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
                if (cmbSearchTanker.SelectedValue.ToString() != "0")
                {
                    DialogResult result = MetroMessageBox.Show(this, "Do you really want to delete this record?", "Mandya WeighBridge", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        ApplicationResult objResult = new ApplicationResult();
                        VehicleBL objVehicleBL = new VehicleBL();
                        objResult = objVehicleBL.Vehicle_Delete(Convert.ToInt32(cmbSearchTanker.SelectedValue), 1, DateTime.UtcNow.AddHours(5.5).ToString(CultureInfo.GetCultureInfo("en-GB")));
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
                        BindVehicleNumber();
                        VisibilityMode(1);
                    }
                }
                else
                {
                    MetroMessageBox.Show(this, "Select Tanker", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region TextBox KeyPress Event 2
        private void txt_KeyPress2(object sender, KeyPressEventArgs e)
        {
            MetroTextBox txt = (MetroTextBox)sender;
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8 || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Tanker No Textbox KeyPress Event
        private void txtVehicleNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8 || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
            txtVehicleNumber.Text.ToUpper();
        }
        #endregion

        #region Capacity Textbox KeyPress Event
        private void txtCapacity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion

        #region DriverName Textbox Keypress Event
        private void txtDriverName_KeyPress(object sender, KeyPressEventArgs e)
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

        #region Form Close Event
        private void Vehicle_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (spWeighBridge.IsOpen)
            {
                spWeighBridge.Close();
            }
        }
        #endregion
    }
}
