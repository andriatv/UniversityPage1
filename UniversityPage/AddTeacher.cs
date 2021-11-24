using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityPage
{
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String gender = "";
            bool isChecked = radioMale.Checked;
            if (isChecked)
            {
                gender = radioMale.Text;
            }
            else
            {
                gender = radioFemale.Text;
            }
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source=LAPTOP-PO3M6CR9\\DATACAMP_SQL; database=University; integrated security =True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into teacher (fullName,gender,dob,mobile,email,semester,program,duration, address) values ('"+txtFullName.Text+"','"+gender+ "', '" + dateTimePickerDOB.Text+ "'," + txtMobile.Text + ", '" + txtEmail.Text + "', '" + txtSemester.Text + "','" + txtProgram.Text + "', '" + txtDuration.Text + "','" + txtAddress.Text + "')" ;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
