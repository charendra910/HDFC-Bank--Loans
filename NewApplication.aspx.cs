using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace HDFC_Loans
{
    public partial class NewApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Web With ASP.Net By PJT\\Project1\\HDFC_Loans\\App_Data\\HDFC-Loans.mdf\";Integrated Security=True";
            SqlConnection cn = new SqlConnection(connectionstring);

            cn.Open();

            string query = "insert into [Loan](AccountNo,HolderName,LoanCategory,LoanType,IssueDate,Amount,CurrentAddress,LoanRemarks) values(@AccountNo,@HolderName,@LoanCategory,@LoanType,@IssueDate,@Amount,@CurrentAddress,@LoanRemarks)";
            SqlCommand cmd = new SqlCommand(query, cn);

            cmd.Parameters.AddWithValue("@AccountNo", TextBox1.Text);
            cmd.Parameters.AddWithValue("@HolderName", TextBox2.Text);
            cmd.Parameters.AddWithValue("@LoanCategory", DropDownList1.Text);
            cmd.Parameters.AddWithValue("@LoanType", DropDownList2.Text);
            cmd.Parameters.AddWithValue("@IssueDate", TextBox5.Text);
            cmd.Parameters.AddWithValue("@Amount", TextBox6.Text);
            cmd.Parameters.AddWithValue("@CurrentAddress", TextBox7.Text);
            cmd.Parameters.AddWithValue("@LoanRemarks", TextBox8.Text);

            cmd.ExecuteNonQuery();

            cn.Close();

            Label10.Text = "Loan application submitted successfully!";

        }
    }
}