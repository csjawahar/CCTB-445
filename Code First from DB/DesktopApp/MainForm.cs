using DesktopApp.Reoprts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace DesktopApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Close the program/form
        }

        private void regionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Open a form as a dialog box
            ViewRegions frm = new ViewRegions();

            frm.ShowDialog(); // Execution of this method will PAUSE here until the dialog box (ViewRegions) is closed
            // resume after the dialog box is closed

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Set application startup date/time in status bar
            StartTimeStatus.Text = "App started at " + DateTime.Now.ToString();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void shippersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchOrActivate<ViewShippers>();
            /*ViewShippers theform = new ViewShippers();
            theform.MdiParent = this; //tell the new form I am the parent
            theform.WindowState = FormWindowState.Maximized;
            theform.Show(); //no pause here*/
            MessageBox.Show("Here is ViewShipper form!");

        }

        private void customerOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaunchOrActivate<ProductSalesForm>();
            /*ProductSalesForm repoForm = new ProductSalesForm();
            repoForm.MdiParent = this; //tell the new form I am the parent
            repoForm.WindowState = FormWindowState.Maximized; 
            repoForm.Show();*/
        }

        private void aboutThisAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //TODO: About 
            AboutApp theform = new AboutApp();
            theform.Text = "Glad you asked!";
            theform.ShowDialog(); //we pause till the aboutapp form is closed.
            MessageBox.Show("Thanks for asking!");
        }

        #region Support Methods
        private void LaunchOrActivate<T>() where T : Form, new()
        {
            T theForm = GetChildForm<T>();
            if (theForm == null)
            {
                theForm = new T();
                theForm.MdiParent = this;
                theForm.WindowState = FormWindowState.Maximized;
                theForm.Show();
            }
            else
            {
                theForm.WindowState = FormWindowState.Maximized;
                theForm.Focus();
            }
        }

        private T GetChildForm<T>() where T : Form
        {
            foreach (var childform in MdiChildren)
            {
                if (childform is T)
                    return (T)childform;
            }

            return null;
        }
        #endregion
    }

   
}
