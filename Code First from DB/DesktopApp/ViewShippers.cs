using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NorthwindSystem.BLL;
using NorthwindSystem.Entities;

namespace DesktopApp
{
    public partial class ViewShippers : Form
    {
        public ViewShippers()
        {
            InitializeComponent();
        }

      
        private void btnLookupShippers_Click(object sender, EventArgs e)
        {

            try
            {
                if (cboShippers.SelectedIndex <= 0)
                    MessageBox.Show("Please select a shipper before clicking [Lookup]");
                else
                {
                    int shipperId = Convert.ToInt32(cboShippers.SelectedValue);
                    NorthwindManager nwm = new NorthwindManager();
                    Shipper shipr = nwm.GetShipper(shipperId);

                    ShipperID.Text = shipr.ShipperID.ToString();
                    txtCompanyName.Text = shipr.CompanyName;
                    txtPhone.Text = shipr.Phone;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void btnAdShipper_Click(object sender, EventArgs e)
        {
            try
            {
                Shipper elem = new Shipper()
                {
                    CompanyName = txtCompanyName.Text,
                    Phone = txtPhone.Text
                };

                var mgr = new NorthwindManager();
                elem.ShipperID = mgr.AddShipper(elem);

                //give feed back to user
                // updater shipper combobox and select right shipper
                //display id of added shipper
                PopulateShippersComboBox();
                cboShippers.SelectedValue = elem.ShipperID;
                ShipperID.Text = elem.ShipperID.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void btnUpdateShipper_Click(object sender, EventArgs e)
        {
            try
            {
                int shipperId;
                if (int.TryParse(ShipperID.Text, out shipperId))
                {
                    var info = new Shipper()
                    {
                        ShipperID = shipperId,
                        CompanyName = txtCompanyName.Text,
                        Phone = txtPhone.Text
                    };
                    var mgr = new NorthwindManager();
                    mgr.UpdateShipper(info);
                    PopulateShippersComboBox();
                    cboShippers.SelectedValue = info.ShipperID;
                }
                else
                {
                    MessageBox.Show("Please look up a shipper before trying update.");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

        }

        private void btnDeleteShipper_Click(object sender, EventArgs e)
        {
            try
            {
                int temp;
                if (int.TryParse(ShipperID.Text, out temp))
                {
                    var elem = new Shipper() { ShipperID = temp };
                    var mgr = new NorthwindManager();
                    mgr.DeleteShipper(elem);
                    PopulateShippersComboBox();
                    ShipperID.Text = "";
                    txtCompanyName.Text = "";
                    txtPhone.Text = "";
                }
                else
                {
                    MessageBox.Show("Please look up a shipper before trying delete.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnClearForm_Click(object sender, EventArgs e)
        {
            PopulateShippersComboBox();
            ShipperID.Text = "";
            txtCompanyName.Text = "";
            txtPhone.Text = "";
        }

        private void ViewShippers_Load(object sender, EventArgs e)
        {
            //Populate combo box
            try 
            {
                PopulateShippersComboBox();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error loading form", MessageBoxButtons.OK);
                //throw ex;
                //TODO: Log exception
            }          
        }

        private void PopulateShippersComboBox()
        {
            NorthwindManager nwm = new NorthwindManager();
            var data = nwm.ListShippers();
            data.Insert(0, new Shipper() { ShipperID = -1, CompanyName = "[select a shipper]" });
            cboShippers.DataSource = data;
            cboShippers.DisplayMember = "CompanyName";
            cboShippers.ValueMember = "ShipperID";
            //cboShippers.Items.Insert(0, "[select a shipper]");
            cboShippers.SelectedIndex = 0; //the first in the  cbo list
        }
    }
}
