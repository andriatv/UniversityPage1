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
    public partial class SearchStudent : Form
    {
        public SearchStudent()
        {
            InitializeComponent();
        }

        private void SearchStudent_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-PO3M6CR9\\DATACAMP_SQL; database = University; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandText = "select NAID as Student_ID, firstName as First_Name, lastName as Last_Name,gender as Gender,dob as Date_Of_Birth,mobile as Mobile,email as Email_ID,semester as Semester,program as Programming_Language,schoolName as School_Name,duration as Course_Duration,address as Address from NewAddmission";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source = LAPTOP-PO3M6CR9\\DATACAMP_SQL; database = University; integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

          cmd.CommandText = "select * from NewAddmission where NAID = "+textBox1.Text+"";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }
    }
       

}


   

