using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace innr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            string Connection = "Data Source=DESKTOP-OT87DKU\\SQLEXPRESS;Initial Catalog=emp;Integrated Security=True";

            SqlConnection con = new SqlConnection(Connection);
            con.Open();
            string q = "select studentt.name,studentt.fathername,studentt.depatment,sub.sub1,sub.sub2,sub.sub3 from studentt inner join sub on studentt.rollno=sub.Roll where studentt.rollno='"+textBox1.Text+"'";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.ExecuteNonQuery();
            DataTable data = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(data);
            dataGridView1.DataSource = data;
            con.Close();

        }
    }
}
