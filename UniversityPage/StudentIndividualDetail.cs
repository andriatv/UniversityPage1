using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UniversityPage
{
    public partial class StudentIndividualDetail : Form
    {
        public StudentIndividualDetail()
        {
            InitializeComponent();
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-PO3M6CR9\\DATACAMP_SQL; database = University; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewAddmission where NAID = "+textBox1.Text+"";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {

                labelFullName.Text = ds.Tables[0].Rows[0][1].ToString();
                labelLastName.Text = ds.Tables[0].Rows[0][2].ToString();
                labelGender.Text = ds.Tables[0].Rows[0][3].ToString();
                labelDOB.Text = ds.Tables[0].Rows[0][4].ToString();
                labelMobile.Text = ds.Tables[0].Rows[0][5].ToString();
                labelemail.Text = ds.Tables[0].Rows[0][6].ToString();
                labelStandart.Text = ds.Tables[0].Rows[0][7].ToString();
                labelMedium.Text = ds.Tables[0].Rows[0][8].ToString();
                labelSchoolName.Text = ds.Tables[0].Rows[0][9].ToString();
                labelYear.Text = ds.Tables[0].Rows[0][10].ToString();
                labelAddress.Text = ds.Tables[0].Rows[0][11].ToString();

            }
            else {
                MessageBox.Show("No Recrd found", "No match", MessageBoxButtons.OK, MessageBoxIcon.Error);
                labelFullName.Text = "______";
                labelLastName.Text = "______";
                labelGender.Text = "______";
                labelDOB.Text = "______";
                labelMobile.Text = "______";
                labelemail.Text = "______";
                labelStandart.Text = "______";
                labelMedium.Text = "______";
                labelSchoolName.Text = "______";
                labelYear.Text = "______";
                labelAddress.Text = "______";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            labelFullName.Text = "______";
            labelLastName.Text = "______";
            labelGender.Text = "______";
            labelDOB.Text = "______";
            labelMobile.Text = "______";
            labelemail.Text = "______";
            labelStandart.Text = "______";
            labelMedium.Text = "______";
            labelSchoolName.Text = "______";
            labelYear.Text = "______";
            labelAddress.Text = "______";

        }
    }
}
