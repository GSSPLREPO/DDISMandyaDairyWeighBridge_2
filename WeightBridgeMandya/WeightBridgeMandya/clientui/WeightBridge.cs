using System;
using System.Data;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using Mandya.BO;
using Mandya.BL;
using Mandya.Common;
using System.Configuration;
using WeightBridgeMandya.Print;
using System.IO.Ports;
using System.Threading;
using System.Text.RegularExpressions;

namespace WeightBridgeMandya.clientui
{
    public partial class WeightBridge : MetroForm
    {
        private static readonly log4net.ILog log =
        log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private string _rxString;
        private string strMode = string.Empty;
        [Obsolete]
        string[] strPortSetup = ConfigurationSettings.AppSettings["Port"].ToString().Split('~');

        #region Declaration
        public int intid;
        public int intactivate = 0;
        public int editMode;
        private DataTable dtWeightBridgeNo = new DataTable();
        private DataTable dtPurpose = new DataTable();
        DateTime dtDateTime;
        #endregion

        #region Initilize Component
        [Obsolete]
        public WeightBridge(int id, int editCode)
        {
            InitializeComponent();
            spWeighBridge.PortName = strPortSetup[0];
            spWeighBridge.BaudRate = Convert.ToInt32(strPortSetup[1]);
            spWeighBridge.DataBits = 8;
            spWeighBridge.StopBits = StopBits.One;
            spWeighBridge.Parity = Parity.None;
            if (id == -1)
            {
                strMode = "New";
                gbNetWeight.Visible = false;
                txtTankerNo.Focus();
            }
            else if (editCode == 1)
            {
                strMode = "Edit";
                intid = id;
                gbNetWeight.Visible = true;
                editMode = 1;
            }
            else if (editCode == 2)
            {
                strMode = "Edit1";
                intid = id;
                editMode = 2;
            }
        }
        #endregion

        #region Form Load Event
        [Obsolete]
        private void WeightBridge_Load(object sender, EventArgs e)
        {
            try
            {
                WeightBridgeBL objWeightBridgeBL = new WeightBridgeBL();

                //ShowWeight();
                DefinePurpose();
                BindPurposeRow();
                BindPurpose();
                //BindSource();
                //BindDestination();
                BindRoute();
                BindProduct();
                DefineWeightBridgeNo();
                BindWeightBridgeNoRow();
                BindWeightBridgeNo();
                BindComponents();
                BindCustomer();
                BindSupplier();

                
                //---------- Below Code for Auto Serach Tanker No ---------------
                var objTankerNo = objWeightBridgeBL.AutoCompliteTankerNo();
                AutoCompleteStringCollection autoCollection = new AutoCompleteStringCollection();
                if (objTankerNo != null)
                {
                    if (objTankerNo.ResultDt.Rows.Count > 0)
                    {
                        for(int i=0;i< objTankerNo.ResultDt.Rows.Count; i++)
                        {
                            autoCollection.Add(objTankerNo.ResultDt.Rows[i]["TankerNo"].ToString());
                        }
                        
                    }
                }
                txtTankerNo.AutoCompleteCustomSource = autoCollection;
                //---------- Below Code for Auto Serach Tanker No ---------------

                if (strMode == "Edit" || strMode == "Edit1")
                {

                    var objResult = objWeightBridgeBL.WeightBridge_Select(intid, editMode);


                    if (objResult != null)
                    {
                        if (objResult.ResultDt.Rows.Count > 0)
                        {
                            txtTankerNo.Text = objResult.ResultDt.Rows[0][WeightBridgeBO.WEIGHTBRIDGE_TANKERNO].ToString();
                            btnFind_Click(sender, e);
                            dtDateTime = Convert.ToDateTime(objResult.ResultDt.Rows[0][WeightBridgeBO.WEIGHTBRIDGE_DATETIME].ToString());
                            txtChallanNo.Text = objResult.ResultDt.Rows[0][WeightBridgeBO.WEIGHTBRIDGE_DISPATCHCHALANNO].ToString();
                            txtRemark.Text = objResult.ResultDt.Rows[0][WeightBridgeBO.WEIGHTBRIDGE_REMARKS].ToString();
                            // cmbSource.SelectedValue = Convert.ToInt32(objResult.ResultDt.Rows[0][WeightBridgeBO.WEIGHTBRIDGE_SOURCEID].ToString());
                            // cmbDestination.SelectedValue = Convert.ToInt32(objResult.ResultDt.Rows[0][WeightBridgeBO.WEIGHTBRIDGE_DESTINATIONID].ToString());
                            cmbCustomer.SelectedValue = objResult.ResultDt.Rows[0][WeightBridgeBO.WEIGHTBRIDGE_CUSTOMERID].ToString();
                            cmbSupplier.SelectedValue = objResult.ResultDt.Rows[0][WeightBridgeBO.WEIGHTBRIDGE_SUPPLIERID].ToString();
                            cmbProductName.SelectedValue = objResult.ResultDt.Rows[0][WeightBridgeBO.WEIGHTBRIDGE_PRODUCTID].ToString();
                            cmbRouteName.SelectedValue = objResult.ResultDt.Rows[0][WeightBridgeBO.WEIGHTBRIDGE_ROUTEID].ToString();
                            txtSealNo1.Text = objResult.ResultDt.Rows[0][WeightBridgeBO.WEIGHTBRIDGE_TANKERSEALNO1].ToString();
                            txtSealNo2.Text = objResult.ResultDt.Rows[0][WeightBridgeBO.WEIGHTBRIDGE_TANKERSEALNO2].ToString();
                            txtSealNo3.Text = objResult.ResultDt.Rows[0][WeightBridgeBO.WEIGHTBRIDGE_TANKERSEALNO3].ToString();
                            txtSealNo4.Text = objResult.ResultDt.Rows[0][WeightBridgeBO.WEIGHTBRIDGE_TANKERSEALNO4].ToString();
                            txtTankerID.Text = objResult.ResultDt.Rows[0]["TankerId"].ToString();
                            txtDriverName.Text = objResult.ResultDt.Rows[0][WeightBridgeBO.WEIGHTBRIDGE_DRIVERNAME].ToString();
                            txtTareWeight.Text = objResult.ResultDt.Rows[0][WeightBridgeBO.WEIGHTBRIDGE_TAREWEIGHT].ToString();
                            lblTareDate.Text = objResult.ResultDt.Rows[0]["TWDate"].ToString();
                            lblTareTime.Text = objResult.ResultDt.Rows[0]["TWTime"].ToString();
                            txtGrossWeight.Text = objResult.ResultDt.Rows[0][WeightBridgeBO.WEIGHTBRIDGE_GROSSWEIGHT].ToString();
                            lblGrossDate.Text = objResult.ResultDt.Rows[0]["GWDate"].ToString();
                            lblGrossTime.Text = objResult.ResultDt.Rows[0]["GWTime"].ToString();
                            txtNetWeight.Text = objResult.ResultDt.Rows[0][WeightBridgeBO.WEIGHTBRIDGE_NETWEIGHT].ToString();
                            txtSuppliedQty.Text = objResult.ResultDt.Rows[0][WeightBridgeBO.WEIGHTBRIDGE_SUPPLIEDQTY].ToString();
                            txtDifferenceQty.Text = objResult.ResultDt.Rows[0][WeightBridgeBO.WEIGHTBRIDGE_DIFFERENCEQTY].ToString();

                            if (Convert.ToInt32(objResult.ResultDt.Rows[0][WeightBridgeBO.WEIGHTBRIDGE_PURPOSE].ToString()) == 1)
                            {
                                cmbPurpose.SelectedIndex = 1;
                                txtSuppliedQty.Enabled = false;
                            }
                            else if (Convert.ToInt32(objResult.ResultDt.Rows[0][WeightBridgeBO.WEIGHTBRIDGE_PURPOSE].ToString()) == 2)
                            {
                                cmbPurpose.SelectedIndex = 2;
                                txtChallanNo.Enabled = true;
                            }
                            else
                            {
                                cmbPurpose.SelectedIndex = 0;
                            }

                          /*  if (Convert.ToInt32(objResult.ResultDt.Rows[0][WeightBridgeBO.WEIGHTBRIDGE_WEIGHTBRIDGENO].ToString()) == 1)
                            {
                                cmbWBNo.SelectedIndex = 1;
                            }
                            else if (Convert.ToInt32(objResult.ResultDt.Rows[0][WeightBridgeBO.WEIGHTBRIDGE_WEIGHTBRIDGENO].ToString()) == 2)
                            {
                                cmbWBNo.SelectedIndex = 2;
                            }
                            else
                            {
                                cmbWBNo.SelectedIndex = 0;
                            }
                          */
                            if (objResult.ResultDt.Rows[0][WeightBridgeBO.WEIGHTBRIDGE_WEIGHTTYPE].ToString() == "Tare")
                            {
                                rbGross.Checked = true;

                                txtTareWeight.Enabled = false;
                                btnTareCapture.Enabled = false;
                                txtGrossWeight.Enabled = false;
                                btnGrossCapture.Enabled = true;

                            }
                            else
                            {
                                rbTare.Checked = true;

                                txtGrossWeight.Enabled = false;
                                btnGrossCapture.Enabled = false;
                                txtTareWeight.Enabled = false;
                                btnTareCapture.Enabled = true;
                            }

                        }
                        var objResultCIPSTS = objWeightBridgeBL.WeightBridge_Select_CIPStatus(txtTankerID.Text.ToString());

                        if (objResultCIPSTS != null)
                        {
                            if (objResultCIPSTS.ResultDt.Rows.Count > 0)
                            {
                                if (Convert.ToInt32(objResultCIPSTS.ResultDt.Rows[0]["CIPStatus"]) == 1)
                                {
                                    rdoOk.Checked = true;
                                }
                                else
                                {
                                    rdoNotOk.Checked = true;
                                }
                            }
                        }

                        if (strMode == "Edit1")
                        {
                            txtTareWeight.Enabled = true;
                            txtGrossWeight.Enabled = true;
                            txtSuppliedQty.Enabled = true;
                            btnGrossCapture.Enabled = false;
                            btnTareCapture.Enabled = false;
                        }

                        btnSave.Visible = true;
                        btnSave.Text = "Update";
                        pnlButton.Visible = true;
                        gbWeight.Visible = true;
                        gbNetWeight.Visible = true;
                        gbGroup.Visible = true;
                        txtTankerNo.Enabled = false;
                        txtTankerID.Enabled = false;
                        cmbPurpose.Enabled = false;
                        txtNetWeight.Enabled = false;
                        txtDifferenceQty.Enabled = false;
                        btnFind.Enabled = false;
                        pnlCIPStatus.Visible = true;
                        pnlSupQty.Visible = true;
                        pnlDifQty.Visible = true;
                        btnDiff.Visible = true;

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

        #region Show Weight
        private void ShowWeight()
        {
            /*try
            {
                if (spWeighBridge.IsOpen)
                {
                    spWeighBridge.Close();
                }
                spWeighBridge.Open();
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "COM-Port for WeighBridge is not available. Check Connection with WeighBridge", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        #endregion

        #region Define WegihtBridgeNo DataTable
        private void DefineWeightBridgeNo()
        {
            dtWeightBridgeNo.Columns.Add("Id", typeof(int));
            dtWeightBridgeNo.Columns.Add("WeightBridgeNo", typeof(string));
        }
        #endregion


        #region Define Purpose DataTable
        private void DefinePurpose()
        {
            dtPurpose.Columns.Add("Id", typeof(int));
            dtPurpose.Columns.Add("Purpose", typeof(string));
        }
        #endregion

        #region Define WegihtBridgeNo Table Row
        public void BindWeightBridgeNoRow()
        {
            dtWeightBridgeNo.Rows.Add(0, "--Select--");
            dtWeightBridgeNo.Rows.Add(1, "WeightBridge - 1");
            dtWeightBridgeNo.Rows.Add(2, "WeightBridge - 2");
        }
        #endregion

        #region Define Purpose Table Row
        public void BindPurposeRow()
        {
            dtPurpose.Rows.Add(0, "--Select--");
            dtPurpose.Rows.Add(1, "Receive");
            dtPurpose.Rows.Add(2, "Dispatch");
        }
        #endregion

        #region Bind WegihtBridgeNo

        public void BindWeightBridgeNo()

        {
            cmbWBNo.DataSource = dtWeightBridgeNo;
            cmbWBNo.ValueMember = dtWeightBridgeNo.Columns["Id"].ToString();
            cmbWBNo.DisplayMember = dtWeightBridgeNo.Columns["WeightBridgeNo"].ToString();

        }
        #endregion

        #region Bind Purpose

        public void BindPurpose()
        {
            cmbPurpose.DataSource = dtPurpose;
            cmbPurpose.ValueMember = dtPurpose.Columns["Id"].ToString();
            cmbPurpose.DisplayMember = dtPurpose.Columns["Purpose"].ToString();

        }
        #endregion

        #region Bind Components
        private void BindComponents()
        {
            btnViewWeight.Visible = false;
            pnlDisable.Visible = false;
            lblWeightType.Visible = false;
            lblTankerID.Visible = false;
            cmbWBNo.SelectedIndex = 2;
            cmbWBNo.Enabled = false;
            pnlCIPStatus.Visible = false;
            gbGroup.Visible = false;
            gbWeight.Visible = false;
            pnlButton.Visible = false;
            lblTankerID.Visible = false;
            lblWeightType.Visible = false;
            gbNetWeight.Visible = false;
            rbAutomatic.Checked = true;
            txtTankerID.Enabled = false;
            txtNetWeight.Enabled = false;
            txtDifferenceQty.Enabled = false;
            cmbPurpose.Enabled = false;
            pnlDifQty.Visible = false;
            pnlSupQty.Visible = false;
            btnDiff.Visible = false;
            txtTankerNo.Focus();
            lblTareDate.Text = DateTime.UtcNow.AddHours(5.5).ToShortDateString();
            lblTareTime.Text = DateTime.UtcNow.AddHours(5.5).ToShortTimeString();
            lblGrossDate.Text = DateTime.UtcNow.AddHours(5.5).ToShortDateString();
            lblGrossTime.Text = DateTime.UtcNow.AddHours(5.5).ToShortTimeString();

            // Condition for Enable Difference Qunatity Calculate Button
            if (txtSuppliedQty.Text == "0" || txtSuppliedQty.Text == "0.00" || txtSuppliedQty.Text == "")
            {
                btnDiff.Enabled = false;
            }
            else
            {
                btnDiff.Enabled = true;
            }


        }
        #endregion

        #region Bind Source ComboBox
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
                        cmbSource.DataSource = objResult.ResultDt;
                        cmbSource.ValueMember = SourceBO.SOURCE_SOURCEID;
                        cmbSource.DisplayMember = SourceBO.SOURCE_SOURCENAME;

                        cmbSource.DropDownStyle = ComboBoxStyle.DropDownList;
                        cmbSource.AutoCompleteSource = AutoCompleteSource.ListItems;
                        cmbSource.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
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

        #region Bind Destination ComboBox
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
                        cmbDestination.DataSource = objResult.ResultDt;
                        cmbDestination.ValueMember = DestinationBO.DESTINATION_DESTINATIONID;
                        cmbDestination.DisplayMember = DestinationBO.DESTINATION_DESTINATIONNAME;

                        cmbDestination.DropDownStyle = ComboBoxStyle.DropDownList;
                        cmbDestination.AutoCompleteSource = AutoCompleteSource.ListItems;
                        cmbDestination.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
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

        #region Bind Product ComboBox
        public void BindProduct()
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

        #region Bind Supplier ComboBox
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
                        cmbSupplier.DataSource = objResult.ResultDt;
                        cmbSupplier.ValueMember = SupplierBO.SUPPLIER_SUPPLIERID;
                        cmbSupplier.DisplayMember = SupplierBO.SUPPLIER_SUPPLIERNAME;

                        cmbSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
                        cmbSupplier.AutoCompleteSource = AutoCompleteSource.ListItems;
                        cmbSupplier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
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

        #region Bind Customer ComboBox
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
                        cmbCustomer.DataSource = objResult.ResultDt;
                        cmbCustomer.ValueMember = CustomerBO.CUSTOMER_CUSTOMERID;
                        cmbCustomer.DisplayMember = CustomerBO.CUSTOMER_CUSTOMERNAME;

                        cmbCustomer.DropDownStyle = ComboBoxStyle.DropDownList;
                        cmbCustomer.AutoCompleteSource = AutoCompleteSource.ListItems;
                        cmbCustomer.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
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

        #region Auto-Generate TankerID
        public void GenerateTankerID()
        {
            try
            {
                ApplicationResult objResult = new ApplicationResult();
                VehicleBL objVehicleBL = new VehicleBL();

                WeightBridgeBL objWeightBridgeBL = new WeightBridgeBL();

                int intPurpose = 0;
                //int intWeighbridge = 2;
                if (cmbPurpose.SelectedIndex == 1)
                {
                    intPurpose = 1;

                }
                else if (cmbPurpose.SelectedIndex == 2)
                {
                    intPurpose = 2;
                }

                objResult = objWeightBridgeBL.Autogernerate_TankerID(intPurpose/*, intWeighbridge*/);

                if (objResult != null)
                {
                    if (objResult.ResultDt.Rows.Count > 0)
                    {
                        txtTankerID.Text = objResult.ResultDt.Rows[0][0].ToString();
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

        #region Tare Weight Textbox Key Press Event
        private void txtTareWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Gross Weight Textbox Key Press Event
        private void txtGrossWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Save Button Click Event
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                int intValidate = 0;
                if (txtTankerID.Text.Trim() == "")
                {
                    MetroMessageBox.Show(this, "Select Purpose for Generate TankerID", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }
                else if (txtChallanNo.Text.Trim() == "" && strMode == "New" && cmbPurpose.SelectedIndex == 1)
                {
                    MetroMessageBox.Show(this, "Enter Challan No", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }

                else if (txtChallanNo.Text.Trim() == "" && strMode == "Edit" && cmbPurpose.SelectedIndex == 2)
                {
                    MetroMessageBox.Show(this, "Enter Challan No", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }

                /*else if (strMode=="New" && cmbPurpose.SelectedIndex==1  && txtSealNo1.Text.Trim() == "")
                {
                    MetroMessageBox.Show(this, "Enter Tanker Seal No in First Box", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }
                else if (strMode == "New" && cmbPurpose.SelectedIndex == 1  && txtSealNo2.Text.Trim() == "")
                {
                    MetroMessageBox.Show(this, "Enter Tanker Seal No in Second Box", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }*/
                else if (strMode == "New" && cmbPurpose.SelectedIndex == 1 && (txtGrossWeight.Text == "" || txtGrossWeight.Text == "0"))
                {
                    MetroMessageBox.Show(this, "Capture Gross Weight", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }

                else if (strMode == "New" && cmbPurpose.SelectedIndex == 2 && (txtTareWeight.Text == "" || txtTareWeight.Text == "0"))
                {
                    MetroMessageBox.Show(this, "Capture Tare Weight", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }
                /* else if(strMode=="New" && cmbPurpose.SelectedIndex==1 && (txtSuppliedQty.Text=="0" || txtSuppliedQty.Text=="0.00" || txtSuppliedQty.Text == ""))
                 {
                     MetroMessageBox.Show(this, "Enter Supplie Quantity", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     intValidate = 1;
                 }*/

                else if (txtTankerNo.Text == "")
                {
                    MetroMessageBox.Show(this, "Enter Tanker No", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }

                /*else if (strMode == "Edit" && cmbPurpose.SelectedIndex == 2 && txtSealNo1.Text.Trim() == "")
                {
                    MetroMessageBox.Show(this, "Enter Tanker Seal No in First Box", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }
                else if (strMode == "Edit" && cmbPurpose.SelectedIndex == 2 && txtSealNo2.Text.Trim() == "")
                {
                    MetroMessageBox.Show(this, "Enter Tanker Seal No in Second Box", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }*/

                else if (strMode == "Edit" && cmbPurpose.SelectedIndex == 1 && (txtTareWeight.Text == "" || txtTareWeight.Text == "0" || txtTareWeight.Text == "0.00"))
                {
                    MetroMessageBox.Show(this, "Capture Tare Weight", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }

                else if (strMode == "Edit" && cmbPurpose.SelectedIndex == 2 && (txtGrossWeight.Text == "" || txtGrossWeight.Text == "0" || txtGrossWeight.Text == "0.00"))
                {
                    MetroMessageBox.Show(this, "Capture Gross Weight", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }

                else if (strMode == "Edit" && (txtNetWeight.Text == "" || txtNetWeight.Text == "0.00" || txtNetWeight.Text == "0"))
                {
                    MetroMessageBox.Show(this, "Calculate NetWeight.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }

                /* else if (strMode == "Edit" && (txtSuppliedQty.Text == "" || txtSuppliedQty.Text == "0.00" || txtSuppliedQty.Text=="0"))
                 {
                     MetroMessageBox.Show(this, "Enter Supplied Quantity", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     intValidate = 1;
                 }

                 else if (strMode == "Edit" && float.Parse(txtSuppliedQty.Text) < float.Parse(txtNetWeight.Text))
                 {
                     MetroMessageBox.Show(this, "Supplied Qty Cannot Be Less Then Net Quantity", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     intValidate = 1;
                 }*/
                else if (strMode == "Edit" && float.Parse(txtTareWeight.Text) > float.Parse(txtGrossWeight.Text))
                {
                    MetroMessageBox.Show(this, "Tare Weight Cannot be Greter then Gross Weight", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }
                /*else if (strMode == "Edit" && cmbPurpose.SelectedIndex == 2 && (txtSuppliedQty.Text == "0" || txtSuppliedQty.Text == "0.00" || txtSuppliedQty.Text == ""))
                {
                    MetroMessageBox.Show(this, "Enter Supplie Quantity", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    intValidate = 1;
                }*/


                if (intValidate == 0)
                {
                    WeightBridgeBO objWeightBridgeBO = new WeightBridgeBO();
                    WeightBridgeBL objWeightBridgeBL = new WeightBridgeBL();
                    ApplicationResult objResult = new ApplicationResult();
                    if (strMode == "New")
                    {
                        dtDateTime = DateTime.UtcNow.AddHours(5.5);
                        objWeightBridgeBO.DateTime = dtDateTime;
                    }
                    else
                    {
                        objWeightBridgeBO.DateTime = dtDateTime;
                    }
                    objWeightBridgeBO.TankerNo = txtTankerNo.Text.Trim();
                    objWeightBridgeBO.Purpose = Convert.ToInt32(cmbPurpose.SelectedValue);
                    objWeightBridgeBO.TankerID = txtTankerID.Text.Trim();
                    objWeightBridgeBO.DispatchChalanNo = txtChallanNo.Text.Trim();
                    objWeightBridgeBO.TankerSealNo1 = txtSealNo1.Text.Trim();
                    objWeightBridgeBO.TankerSealNo2 = txtSealNo2.Text.Trim();
                    objWeightBridgeBO.TankerSealNo3 = txtSealNo3.Text.Trim();
                    objWeightBridgeBO.TankerSealNo4 = txtSealNo4.Text.Trim();
                    objWeightBridgeBO.SupplierID = Convert.ToInt32(cmbSupplier.SelectedValue);
                    objWeightBridgeBO.CustomerID = Convert.ToInt32(cmbCustomer.SelectedValue);
                    //objWeightBridgeBO.SourceID = Convert.ToInt32(cmbSource.SelectedValue);
                    //objWeightBridgeBO.DestinationID = Convert.ToInt32(cmbDestination.SelectedValue);
                    objWeightBridgeBO.SourceID = 0;
                    objWeightBridgeBO.DestinationID = 0;
                    objWeightBridgeBO.ProductID = Convert.ToInt32(cmbProductName.SelectedValue);
                    objWeightBridgeBO.RouteID = Convert.ToInt32(cmbRouteName.SelectedValue);
                    objWeightBridgeBO.WeightBridgeNo = Convert.ToInt32(cmbWBNo.SelectedValue);
                    objWeightBridgeBO.Purpose = Convert.ToInt32(cmbPurpose.SelectedValue);
                    objWeightBridgeBO.DriverName = txtDriverName.Text.Trim();

                    if (rbAutomatic.Checked)
                    {
                        objWeightBridgeBO.EntryType = "Automatic";
                    }
                    else
                    {
                        objWeightBridgeBO.EntryType = "Manual";
                    }

                    if (rbTare.Checked)
                    {
                        objWeightBridgeBO.WeightType = "Tare";
                    }
                    else
                    {
                        objWeightBridgeBO.WeightType = "Gross";

                    }

                    if (txtTareWeight.Text == "" || txtTareWeight.Text == null)
                    {
                        objWeightBridgeBO.TareWeight = 0;
                    }
                    else
                    {
                        objWeightBridgeBO.TareWeight = double.Parse(txtTareWeight.Text.Trim());
                    }
                    if (txtGrossWeight.Text == "" || txtGrossWeight.Text == null)
                    {
                        objWeightBridgeBO.GrossWeight = 0;
                    }
                    else
                    {
                        objWeightBridgeBO.GrossWeight = double.Parse(txtGrossWeight.Text.Trim());
                    }

                    /*if(strMode=="New" && cmbPurpose.SelectedIndex == 1)
                    {
                        objWeightBridgeBO.SuppliedQty = double.Parse(txtSuppliedQty.Text.Trim());
                    }*/

                    if (txtSuppliedQty.Text == "")
                    {
                        objWeightBridgeBO.SuppliedQty = 0;
                    }

                    if (strMode == "New")
                    {
                        objWeightBridgeBO.NetWeight = 0;
                        objWeightBridgeBO.DifferenceQty = 0;
                        objWeightBridgeBO.CIPStatus = "0";
                    }
                    else
                    {
                        objWeightBridgeBO.NetWeight = double.Parse(txtNetWeight.Text.Trim());
                        objWeightBridgeBO.DifferenceQty = double.Parse(txtDifferenceQty.Text.Trim());
                        objWeightBridgeBO.SuppliedQty = double.Parse(txtSuppliedQty.Text.Trim());
                    }

                    if (strMode == "Edit" && rdoOk.Checked == true)
                    {
                        objWeightBridgeBO.CIPStatus = "Ok";
                    }
                    if (strMode == "Edit" && rdoNotOk.Checked == true)
                    {
                        objWeightBridgeBO.CIPStatus = "NotOk";
                    }
                    objWeightBridgeBO.GrossWeightDateTime = Convert.ToDateTime(lblGrossDate.Text + " " + lblGrossTime.Text);
                    objWeightBridgeBO.TareWeightDateTime = Convert.ToDateTime(lblTareDate.Text + " " + lblTareTime.Text);

                    objWeightBridgeBO.Remarks = txtRemark.Text.Trim();
                    objWeightBridgeBO.CreatedByID = Program.intUserId;
                    objWeightBridgeBO.CreatedByDate = DateTime.UtcNow.AddHours(5.5);
                    txtTankerNo.Text.ToUpper();

                    if ((strMode == "Edit" || strMode == "Edit") && rbGross.Checked == true)
                    {
                        objWeightBridgeBO.GrossWeightDateTime = DateTime.UtcNow.AddHours(5.5);
                    }
                    else if ((strMode == "Edit" || strMode == "Edit") && rbTare.Checked == true)
                    {
                        objWeightBridgeBO.TareWeightDateTime = DateTime.UtcNow.AddHours(5.5);
                    }

                    if (strMode == "New")
                    {
                        objResult = objWeightBridgeBL.WeightBridge_Insert(objWeightBridgeBO);
                        if (objResult != null)
                        {
                            if (objResult.Status == ApplicationResult.CommonStatusType.Success)
                            {
                                int WeighBridgeId = 0;
                                WeighBridgeId = Convert.ToInt32(objResult.ResultDt.Rows[0]["WeightBridgeID"].ToString());
                                MetroMessageBox.Show(this, "Record Saved Successfully.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnSave.Visible = false;
                                using (Printing demo = new Printing())
                                {
                                    int a = 0;
                                    a = 1;
                                    Print frmPrint = new Print();
                                    frmPrint.Show();
                                    frmPrint.Run(WeighBridgeId, a);
                                }

                            }
                        }
                    }
                    else
                    {
                        objWeightBridgeBO.WeightBridgeID = intid;
                        objWeightBridgeBO.LastModifiedByID = Program.intUserId;
                        objWeightBridgeBO.LastModifiedByDate = DateTime.UtcNow.AddHours(5.5);
                        objResult = objWeightBridgeBL.WeightBridge_Update(objWeightBridgeBO);
                        if (objResult != null)
                        {
                            if (objResult.Status == ApplicationResult.CommonStatusType.Success)
                            {
                                MetroMessageBox.Show(this, "Record Updated Successfully.", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                btnSave.Visible = false;
                                int WeighBridgeId = 0;
                                WeighBridgeId = intid;

                                if (strMode == "Edit")
                                {
                                    using (Printing demo = new Printing())
                                    {
                                        int a = 0;
                                        a = 2;
                                        Print frmPrint = new Print();
                                        frmPrint.Show();
                                        frmPrint.Run(WeighBridgeId, a);
                                    }
                                }

                            }
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

        #region Tare Radio Button Check Changed Event
        private void rbTare_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbTare.Checked)
                {
                    if (strMode == "New")
                    {
                        gbTare.Visible = true;
                        gbGross.Visible = false;
                        cmbPurpose.SelectedIndex = 2;
                    }
                    else
                    {
                        gbGross.Visible = true;
                        gbTare.Visible = true;

                    }
                    lblWeightType.Text = "1";
                }
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Gross Radio Button Check Changed Event
        private void rbGross_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rbGross.Checked)
                {
                    if (strMode == "New")
                    {
                        gbGross.Visible = true;
                        gbTare.Visible = false;
                        cmbPurpose.SelectedIndex = 1;
                    }
                    else
                    {
                        gbGross.Visible = true;
                        gbTare.Visible = true;
                    }
                    lblWeightType.Text = "2";
                }
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Automatic Radio Button Check Changed Event
        private void rbAutomatic_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAutomatic.Checked)
            {
                if (strMode == "New" && cmbPurpose.SelectedIndex == 1)
                {
                    txtGrossWeight.Enabled = false;
                    txtTareWeight.Enabled = false;
                    btnTareCapture.Enabled = false;
                    btnGrossCapture.Enabled = true;
                }
                else if ((strMode == "Edit" || strMode == "Edit1") && cmbPurpose.SelectedIndex == 1)
                {
                    txtGrossWeight.Enabled = false;
                    txtTareWeight.Enabled = false;
                    btnTareCapture.Enabled = true;
                    btnGrossCapture.Enabled = false;
                }
                else if (strMode == "New" && cmbPurpose.SelectedIndex == 2)
                {
                    txtGrossWeight.Enabled = false;
                    txtTareWeight.Enabled = false;
                    btnTareCapture.Enabled = true;
                    btnGrossCapture.Enabled = false;
                }
                else if ((strMode == "Edit" || strMode == "Edit1") && cmbPurpose.SelectedIndex == 2)
                {
                    txtGrossWeight.Enabled = false;
                    txtTareWeight.Enabled = false;
                    btnTareCapture.Enabled = false;
                    btnGrossCapture.Enabled = true;
                }

            }
        }
        #endregion

        #region Manual Radio Button Check Changed Event
        private void rbManual_CheckedChanged(object sender, EventArgs e)
        {
            if (Program.intRoleId == 1)
            {
                if (rbManual.Checked)
                {
                    if (strMode == "New" && cmbPurpose.SelectedIndex == 1)
                    {
                        txtGrossWeight.Enabled = true;
                        txtTareWeight.Enabled = false;
                        btnTareCapture.Enabled = false;
                        btnGrossCapture.Enabled = false;
                    }
                    else if (strMode == "Edit" && cmbPurpose.SelectedIndex == 1)
                    {
                        txtGrossWeight.Enabled = false;
                        txtTareWeight.Enabled = true;
                        btnTareCapture.Enabled = false;
                        btnGrossCapture.Enabled = false;
                    }
                    else if (strMode == "Edit1" && cmbPurpose.SelectedIndex == 1)
                    {
                        txtGrossWeight.Enabled = true;
                        txtTareWeight.Enabled = true;
                        btnTareCapture.Enabled = false;
                        btnGrossCapture.Enabled = false;
                    }

                    else if (strMode == "New" && cmbPurpose.SelectedIndex == 2)
                    {
                        txtGrossWeight.Enabled = false;
                        txtTareWeight.Enabled = true;
                        btnTareCapture.Enabled = false;
                        btnGrossCapture.Enabled = false;
                    }
                    else if (strMode == "Edit" && cmbPurpose.SelectedIndex == 2)
                    {
                        txtGrossWeight.Enabled = true;
                        txtTareWeight.Enabled = false;
                        btnTareCapture.Enabled = false;
                        btnGrossCapture.Enabled = false;
                    }
                    else if (strMode == "Edit1" && cmbPurpose.SelectedIndex == 2)
                    {
                        txtGrossWeight.Enabled = true;
                        txtTareWeight.Enabled = true;
                        btnTareCapture.Enabled = false;
                        btnGrossCapture.Enabled = false;
                    }
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Access Denied", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                rbAutomatic.Checked = true;
            }
        }
        #endregion

        #region Auto-Generate Dispatch Challan No
        public void GenerateDispatchChallanNo()
        {
            try
            {
                ApplicationResult objResult = new ApplicationResult();
                WeightBridgeBL objWeightBridgeBL = new WeightBridgeBL();

                if (cmbPurpose.SelectedIndex == 2)
                {
                    objResult = objWeightBridgeBL.Autogernerate_DispatchChallanNo();

                    if (objResult != null)
                    {
                        if (objResult.ResultDt.Rows.Count > 0)
                        {
                            txtChallanNo.Enabled = false;
                            txtChallanNo.Text = objResult.ResultDt.Rows[0][0].ToString();
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

        #region Find Button Click Event
        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                int CountText = txtTankerNo.Text.Length;

                if (txtTankerNo.Text != "" && CountText >= 8)
                {
                    VehicleBL objVehicleBL = new VehicleBL();
                    ApplicationResult objResult = new ApplicationResult();
                    if (strMode == "New")
                    {
                        objResult = objVehicleBL.Vehicle_Select_ByVehicleNumber(txtTankerNo.Text.Trim(), 0);   // 0 for add new vehicle
                        if (objResult.ResultDt.Rows.Count == 0)
                        {
                            MetroMessageBox.Show(this, "This Tanker Number Not Found First Registed It then Process", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);

                            Vehicle frmVehical = new Vehicle();
                            frmVehical.ShowDialog();
                            gbGroup.Visible = false;
                            gbWeight.Visible = false;
                            pnlButton.Visible = false;
                            gbNetWeight.Visible = false;
                        }
                        else
                        {
                            objResult = objVehicleBL.Vehicle_Select_ByVehicleNumber(txtTankerNo.Text.Trim(), 2);
                            if (objResult.ResultDt.Rows.Count > 0)
                            {
                                //txtDriverName.Text = objResult.ResultDt.Rows[0][VehicleBO.VEHICLE_DRIVERNAME].ToString();
                                cmbRouteName.SelectedValue = objResult.ResultDt.Rows[0]["RouteID"].ToString();
                                cmbProductName.SelectedValue= objResult.ResultDt.Rows[0]["ProductId"].ToString();
                                gbGroup.Visible = true;
                                gbWeight.Visible = true;
                                pnlButton.Visible = true;
                                gbTare.Visible = false;
                                gbGross.Visible = false;
                                cmbPurpose.Enabled = true;

                            }
                            else
                            {
                                MetroMessageBox.Show(this, "This Tanker already in process.", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                lblTankerID.Text = "0";
                            }
                        }
                    }

                }
                else
                {
                    MetroMessageBox.Show(this, "Enter Valid Tanker No", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtTankerNo.Focus();
                }
            }
            catch (Exception ex)
            {
                log.Error("error", ex);
                MetroMessageBox.Show(this, "Opps! There is some technical issue. Please Contact to your administrator.", "Mandya WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Weight Button Click Event
        private void btnWeight_Click(object sender, EventArgs e)
        {
            if (txtTareWeight.Text == "")
            {
                txtTareWeight.Text = "0";
            }
            if (txtGrossWeight.Text == "")
            {
                txtGrossWeight.Text = "0";
            }
            txtNetWeight.Text = (float.Parse(txtGrossWeight.Text) - float.Parse(txtTareWeight.Text)).ToString();
            if (float.Parse(txtNetWeight.Text) < 0)
            {
                txtNetWeight.Text = "0";
            }
        }
        #endregion

        #region Tanker No Textbox KeyPress Event
        private void txtTankerNo_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8 || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= 'a' && e.KeyChar <= 'z')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;

            }
            txtTankerNo.Text.ToUpper();
        }
        #endregion

        #region Challan No Textbox KeyPress Event

        private void txtChallanNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* txtTankerNo.Text.ToUpper();
             if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == 8 || e.KeyChar == 44)
             {
                 e.Handled = false;
             }
             else
             {
                 e.Handled = true;
             }*/
        }
        #endregion

        #region Purpose ComboBox Selected Index Changed Event
        private void cmbPurpose_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (strMode == "New")
                {
                    GenerateTankerID();
                    if (cmbPurpose.SelectedIndex == 1)
                    {
                        rbGross.Checked = true;
                        rbTare.Checked = false;
                        txtGrossWeight.Enabled = false;
                        btnGrossCapture.Enabled = true;
                        txtChallanNo.Text = "";
                        txtChallanNo.Enabled = true;
                        pnlSealNo.Enabled = true;
                        txtGrossWeight.Text = "";
                        pnlSupQty.Visible = true;
                    }
                    else if (cmbPurpose.SelectedIndex == 2)
                    {
                        rbGross.Checked = false;
                        rbTare.Checked = true;
                        txtTareWeight.Enabled = false;
                        btnTareCapture.Enabled = true;
                        txtChallanNo.Enabled = false;
                        pnlSealNo.Enabled = false;
                        txtTareWeight.Text = "";
                        pnlSupQty.Visible = false;
                        //GenerateDispatchChallanNo();

                    }
                    else
                    {
                        txtTankerID.Text = "";
                        txtChallanNo.Text = "";
                        rbGross.Checked = false;
                        rbTare.Checked = false;
                        txtGrossWeight.Enabled = false;
                        btnGrossCapture.Enabled = false;
                        txtChallanNo.Enabled = false;
                        pnlSealNo.Enabled = false;
                        pnlSupQty.Visible = false;
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

        #region Key Press Event of Textbox
        private void txtSuppliedQty_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDriverName_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar == 8 || e.KeyChar == 32 || e.KeyChar >= 'A' && e.KeyChar <= 'Z')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtSealNo1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar == 8 || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtSealNo2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar == 8 || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtSealNo3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar == 8 || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtSealNo4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z' || e.KeyChar == 8 || e.KeyChar >= 'A' && e.KeyChar <= 'Z' || e.KeyChar >= '0' && e.KeyChar <= '9')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        #endregion

        #region Tare Capture Button Clicke Event
        private void btnTareCapture_Click(object sender, EventArgs e)
        {
            try
            {
                if (spWeighBridge.IsOpen)
                {
                    spWeighBridge.Close();
                }
                spWeighBridge.Open();
                btnTareCapture.Text = "Processing";
                btnTareCapture.Refresh();

                /*Thread.Sleep(500);
                txtTareWeight.Text = btnViewWeight.Text.Trim();*/

            }
            catch (Exception ex)
            {
                if (spWeighBridge.IsOpen)
                {
                    spWeighBridge.Close();
                }
                log.Error("error", ex);
                // MetroMessageBox.Show(this, "COM-Port for WeighBridge is not available. Check Connection with WeighBridge", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Gross Capture Button Click Event
        private void btnGrossCapture_Click(object sender, EventArgs e)
        {
            try
            {
                if (spWeighBridge.IsOpen)
                {
                    spWeighBridge.Close();
                }
                spWeighBridge.Open();
                btnGrossCapture.Text = "Processing";
                btnGrossCapture.Refresh();

                Thread.Sleep(500);
                txtGrossWeight.Text = btnViewWeight.Text.Trim();
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

        #region getString from Com port method
        /*public void getstring(object sender, EventArgs e)
        {
            *//*btnViewWeight.ForeColor = System.Drawing.Color.Green;
            btnViewWeight.Text = _rxString.Substring(_rxString.IndexOf(":") + 3, 10);

            if (!spWeighBridge.IsOpen)
            {
                spWeighBridge.Open();

            }*//*

            string temp = "0";

            if (strMode == "New" && cmbPurpose.SelectedIndex == 1)
            {
                temp = _rxString.Substring(_rxString.IndexOf(":") + 2, 10);
                txtGrossWeight.Text = temp.Trim();
                spWeighBridge.Close();
                btnGrossCapture.Text = "Capture";
                btnGrossCapture.Refresh();

            }
            else if (strMode == "New" && cmbPurpose.SelectedIndex == 2)
            {
                temp = _rxString.Substring(_rxString.IndexOf(":") + 2, 10);
                txtTareWeight.Text = temp.Trim();
                spWeighBridge.Close();
                btnTareCapture.Text = "Capture";
                btnTareCapture.Refresh();
            }

            else if (strMode == "Edit" && cmbPurpose.SelectedIndex == 1)
            {
                temp = _rxString.Substring(_rxString.IndexOf(":") + 2, 10);
                txtTareWeight.Text = temp.Trim();
                spWeighBridge.Close();
                btnTareCapture.Text = "Capture";
                btnTareCapture.Refresh();
            }
            else if (strMode == "Edit" && cmbPurpose.SelectedIndex == 2)
            {
                temp = _rxString.Substring(_rxString.IndexOf(":") + 2, 10);
                txtGrossWeight.Text = temp.Trim();
                spWeighBridge.Close();
                btnGrossCapture.Text = "Capture";
                btnGrossCapture.Refresh();

            }
        }*/

        public void getstring(object sender, EventArgs e)
        {
            //btnViewWeight.ForeColor = System.Drawing.Color.Green;
            //btnViewWeight.Text = _rxString.Substring(_rxString.IndexOf(":") + 3, 10);

            //if (!spWeighBridge.IsOpen)
            //{
            //    spWeighBridge.Open();

            //}



            string temp = "0";

            //if (strMode == "New" && cmbPurpose.SelectedIndex == 1)
            //{
            //    temp = _rxString.Substring(_rxString.IndexOf(":") + 2, 10);
            //    txtGrossWeight.Text = temp.Trim();
            //    spWeighBridge.Close();
            //    btnGrossCapture.Text = "Capture";
            //    btnGrossCapture.Refresh();

            //}
            //else if (strMode == "New" && cmbPurpose.SelectedIndex == 2)
            //{
            //    temp = _rxString.Substring(_rxString.IndexOf(":") + 2, 10);
            //    txtTareWeight.Text = temp.Trim();
            //    spWeighBridge.Close();
            //    btnTareCapture.Text = "Capture";
            //    btnTareCapture.Refresh();
            //}

            //else if (strMode == "Edit" && cmbPurpose.SelectedIndex == 1)
            //{
            //    temp = _rxString.Substring(_rxString.IndexOf(":") + 2, 10);
            //    txtTareWeight.Text = temp.Trim();
            //    spWeighBridge.Close();
            //    btnTareCapture.Text = "Capture";
            //    btnTareCapture.Refresh();
            //}
            //else if (strMode == "Edit" && cmbPurpose.SelectedIndex == 2)
            //{
            //    temp = _rxString.Substring(_rxString.IndexOf(":") + 2, 10);
            //    txtGrossWeight.Text = temp.Trim();
            //    spWeighBridge.Close();
            //    btnGrossCapture.Text = "Capture";
            //    btnGrossCapture.Refresh();

            //}

            try
            {
                // Regular expression pattern to match the last occurrence of numbers between \u0002 and \u0003
                string pattern = @"\u0002 (\d+)\u0003(?:(?!\u0002).)*$";

                // Find the last match in the received string
                Match match = Regex.Match(_rxString, pattern);

                // Extracted number
                if (match.Success)
                {
                    //temp = match.Groups[1].Value;
                    temp = match.Groups[1].Value.TrimStart('0'); // Trim leading zeros
                    if (strMode == "New" && cmbPurpose.SelectedIndex == 1)
                    {
                        txtGrossWeight.Text = temp.Trim();
                        spWeighBridge.Close();
                        btnGrossCapture.Text = "Capture";
                        btnGrossCapture.Refresh();

                    }
                    else if (strMode == "New" && cmbPurpose.SelectedIndex == 2)
                    {
                        txtTareWeight.Text = temp.Trim();
                        spWeighBridge.Close();
                        btnTareCapture.Text = "Capture";
                        btnTareCapture.Refresh();
                    }

                    else if (strMode == "Edit" && cmbPurpose.SelectedIndex == 1)
                    {
                        txtTareWeight.Text = temp.Trim();
                        spWeighBridge.Close();
                        btnTareCapture.Text = "Capture";
                        btnTareCapture.Refresh();
                    }
                    else if (strMode == "Edit" && cmbPurpose.SelectedIndex == 2)
                    {
                        txtGrossWeight.Text = temp.Trim();
                        spWeighBridge.Close();
                        btnGrossCapture.Text = "Capture";
                        btnGrossCapture.Refresh();

                    }
                    // You can perform further processing here, such as converting to int or float.
                }
                else
                {
                    Console.WriteLine("No matching number found.");
                }
            }
            catch (Exception ex)
            {
                log.Error("Error while processing received data", ex);
                // Handle the error as needed
            }

        }
        #endregion

        #region Serial Port DataReceived Event
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
                // MetroMessageBox.Show(this, "COM-Port for WeighBridge is not available. Check Connection with WeighBridge", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Difference Button Click Event
        private void btnDiff_Click(object sender, EventArgs e)
        {
            if (txtNetWeight.Text == "0" || txtNetWeight.Text == "0.00" || txtNetWeight.Text == "")
            {
                MetroMessageBox.Show(this, "First Calculate Net Weight", "WeighBridge", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (txtNetWeight.Text == "")
                {
                    txtNetWeight.Text = "0";
                }
                if (txtSuppliedQty.Text == "")
                {
                    txtSuppliedQty.Text = "0";
                }
                txtDifferenceQty.Text = (float.Parse(txtSuppliedQty.Text) - float.Parse(txtNetWeight.Text)).ToString();

                if (float.Parse(txtDifferenceQty.Text) < 0)
                {
                    txtDifferenceQty.Text = "0";
                }
            }
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

        #region Textbox Supplied Qty Leave Event
        private void txtSuppliedQty_Leave(object sender, EventArgs e)
        {
            if (txtSuppliedQty.Text == "0" || txtSuppliedQty.Text == "0.00" || txtSuppliedQty.Text == "")
            {
                btnDiff.Enabled = false;
            }
            else
            {
                btnDiff.Enabled = true;
            }
        }
        #endregion

        #region Form Closing Event
        private void WeightBridge_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (spWeighBridge.IsOpen)
            {
                spWeighBridge.Close();
            }
        }
        #endregion

    }
}
