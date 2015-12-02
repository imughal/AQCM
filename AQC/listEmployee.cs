using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace AQC_Manager
{
    public partial class listEmployee : Form
    {
        OleDbConnection con = new OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0; Data Source=aqcDataBase.mdb");
        OleDbDataAdapter ad = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        public listEmployee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * TODO: SAVING DATA
             * 
             * 
             */


            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void employeesInfoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {


        }

        private void newEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aQCManagerDataSet.EmployeesInfo' table. You can move, or remove it, as needed.

        }
    }
}
