using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Threading;
using System.IO;



namespace AQC_Manager
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            Thread t = new Thread(new ThreadStart(splasStart));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();
        }

        public void splasStart()
        {
            Application.Run(new splash());
        }
        private void mainWindow_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aQCManagerDataSet.EmployeesInfo' table. You can move, or remove it, as needed.

        }

        private void btnEmloyees_Click(object sender, EventArgs e)
        {
            //mainTabCtrl.SelectedIndex = 1;
            mainTabCtrl.SelectedTab = emloyees;

        }

        private void btnWPS_Click(object sender, EventArgs e)
        {
           // mainTabCtrl.SelectedIndex = 2;
            mainTabCtrl.SelectedTab = wps;
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            mainTabCtrl.SelectedTab = compainy;
        }

        private void btnExpiry_Click(object sender, EventArgs e)
        {
            mainTabCtrl.SelectedTab = expiries;
        }

        private void btnEmpAddNew_Click(object sender, EventArgs e)
        {
            //addEmployee EmployeeFormA = new addEmployee();
            //EmployeeFormA.Show();
            DialogResult openForm = new addEmployee().ShowDialog();
            if (openForm == DialogResult.OK)
            {
                try
                {
                   // MessageBox.Show("UPDATED");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void testing_Click(object sender, EventArgs e)
        {
            //splash SplashScreen = new splash();
            //SplashScreen.Show();
            MessageBox.Show(Path.GetDirectoryName(Application.ExecutablePath));
        }





        private void button1_Click(object sender, EventArgs e)
        {
            employeesInfoBindingSource.MovePrevious();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            employeesInfoBindingSource.MoveNext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listEmployee EmployeeFormL = new listEmployee();
            EmployeeFormL.Show();
        }

        private void iDTextBox_Enter(object sender, EventArgs e)
        {
            //employeesInfoBindingSource.Position = Convert.ToInt16(iDTextBox.Text);
            testingLabel.Text = iDTextBox.Text;
        }

        private void iDTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {

                // testingLabel.Text = iDTextBox.Text;
            if(employeesInfoBindingSource.Count >= int.Parse(iDTextBox.Text)){

                employeesInfoBindingSource.Position = int.Parse(iDTextBox.Text) - 1;
                testingLabel.Text = Convert.ToString(employeesInfoBindingSource.Count);
            }
            else
            {
                MessageBox.Show("Errorr");
                iDTextBox.Text = bindingNavigatorPositionItem.Text;
            }
            
            }
        }
        
        
        
        //Image Loading on Startup
        private void employeesInfoBindingNavigator_RefreshItems(object sender, EventArgs e)
        {
            employeePic.ImageLocation = imageTextBox.Text;
           // employeesInfoBindingSource.
           
        }

        private void iDTextBox_KeyDown(object sender, EventArgs e)
        {
                // testingLabel.Text = iDTextBox.Text;
            if(employeesInfoBindingSource.Count >= int.Parse(iDTextBox.Text)){

                employeesInfoBindingSource.Position = int.Parse(iDTextBox.Text) - 1;
                testingLabel.Text = Convert.ToString(employeesInfoBindingSource.Count);
            }
            else
            {
                MessageBox.Show("Error");
                iDTextBox.Text = bindingNavigatorPositionItem.Text;
            }
            }

        private void empEditSave_Click(object sender, EventArgs e)
        {

            if (empEditSave.Text == "Edit")
            {
                firstNameTextBox.ReadOnly = false;
                lastNameTextBox.ReadOnly = false;
                fatherNameTextBox.ReadOnly = false;
                dOBTextBox.ReadOnly = false;
                countryTextBox.ReadOnly = false;
                cityTextBox.ReadOnly = false;
                imageBrowserBTN.Visible = true;
                empEditSave.Text = "Save";


            }
            else if (empEditSave.Text == "Save")
            {
                this.Validate();
                this.employeesInfoBindingSource.EndEdit();
       

                firstNameTextBox.ReadOnly = true;
                lastNameTextBox.ReadOnly = true;
                fatherNameTextBox.ReadOnly = true;
                dOBTextBox.ReadOnly = true;
                countryTextBox.ReadOnly = true;
                cityTextBox.ReadOnly = true;
                imageBrowserBTN.Visible = false;
                empEditSave.Text = "Edit";


                
            }

        }

        private void imagesBrowserBTN_Click(object sender, EventArgs e)
        {

            OpenFileDialog OpenDialogBu = new OpenFileDialog();
            if (OpenDialogBu.ShowDialog() == DialogResult.OK)
            {
                /*string subPath = Path.GetDirectoryName(Application.ExecutablePath) + "images/" + bindingNavigatorPositionItem.Text;

                bool exists = System.IO.Directory.Exists(subPath);
                //MessageBox.Show(subPath);
                if (!exists)
                    System.IO.Directory.CreateDirectory(subPath);
                //string currentPossition = int.Parse(employeesInfoBindingSource.Position) + 1;
                string newDestination = subPath + "/profileImage.jpg";
                System.IO.File.Copy(OpenDialogBu.FileName, newDestination, true);
                imageTextBox.Text = (newDestination);
                employeePic.ImageLocation = imageTextBox.Text;//Do what you want here
              */ 
            } 
        }

        private void btnRemoveEmp_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure?", "Deleting Current Employee", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                //do something

            }

            
        }

        private void aboutSbtn_Click(object sender, EventArgs e)
        {
            using (AboutSoftware box = new AboutSoftware())
            {
                box.ShowDialog(this);
            }
        }



    }
}
