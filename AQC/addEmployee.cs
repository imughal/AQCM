using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace AQC_Manager
{
    public partial class addEmployee : Form
    {
        public addEmployee()
        {
            InitializeComponent();

        }

        private void employeesInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aQCManagerDataSet);

        }

        private void addEmployee_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'aQCManagerDataSet.EmployeesInfo' table. You can move, or remove it, as needed.
            this.employeesInfoTableAdapter.Fill(this.aQCManagerDataSet.EmployeesInfo);

            this.employeesInfoBindingSource.AddNew();
        }

        private void btnSaveEmp_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesInfoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aQCManagerDataSet);
            try
            {
                // your update code goes here
                DialogResult = DialogResult.OK; // this is the line that tells your other form to refresh
            }
            catch (Exception ex)
            {
                DialogResult = DialogResult.Abort;
                MessageBox.Show(ex.Message);
            }

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void imageBrowserBTN_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDialogBu = new OpenFileDialog();
            if (OpenDialogBu.ShowDialog() == DialogResult.OK)
            {
                string subPath = Path.GetDirectoryName(Application.ExecutablePath)+"images/" + bindingNavigatorPositionItem.Text;

                bool exists = System.IO.Directory.Exists(subPath);
                //MessageBox.Show(subPath);
                if (!exists)
                    System.IO.Directory.CreateDirectory(subPath);
                //string currentPossition = int.Parse(employeesInfoBindingSource.Position) + 1;
                string newDestination = subPath + "/profileImage.jpg";
                System.IO.File.Copy(OpenDialogBu.FileName, newDestination,true);
                imageTextBox.Text = (newDestination);
                employeePic.ImageLocation = imageTextBox.Text;//Do what you want here
               
            } 
        }
    }
}
