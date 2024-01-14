using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HDFC_Loans
{
    public partial class RemoveApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Web With ASP.Net By PJT\\Project1\\HDFC_Loans\\App_Data\\HDFC-Loans.mdf\";Integrated Security=True";
            SqlConnection cn = new SqlConnection(connectionstring);

            cn.Open();

            if (!string.IsNullOrEmpty(TextBox9.Text))
            {
                string deleteQuery = "DELETE FROM [Loan] WHERE LoanNo=@LoanNo";
                SqlCommand deleteCmd = new SqlCommand(deleteQuery, cn);
                deleteCmd.Parameters.AddWithValue("@LoanNo", TextBox9.Text);
                deleteCmd.ExecuteNonQuery();

                Label10.Text = "Loan application removed successfully!";

                TextBox1.Text = "";
                TextBox2.Text = "";
                DropDownList1.SelectedIndex = 0;
                DropDownList2.SelectedIndex = 0;
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
                TextBox9.Text = ""; 
            }
            else
            {
                Label10.Text = "Please enter a valid Loan No.";
            }

            cn.Close();
        }



        protected void Button3_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Web With ASP.Net By PJT\\Project1\\HDFC_Loans\\App_Data\\HDFC-Loans.mdf\";Integrated Security=True";
            SqlConnection cn = new SqlConnection(connectionstring);

            cn.Open();

            string query = "SELECT * FROM [Loan] WHERE LoanNo = @LoanNo";
            SqlCommand cmd = new SqlCommand(query, cn);
            cmd.Parameters.AddWithValue("@LoanNo", TextBox9.Text);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            if (ds.Tables[0].Rows.Count > 0)
            {
                DataRow row = ds.Tables[0].Rows[0];
                TextBox1.Text = row["AccountNo"].ToString();
                TextBox2.Text = row["HolderName"].ToString();
                DropDownList1.SelectedValue = row["LoanCategory"].ToString();
                DropDownList2.SelectedValue = row["LoanType"].ToString();
                TextBox5.Text = row["IssueDate"].ToString();
                TextBox6.Text = row["Amount"].ToString();
                TextBox7.Text = row["CurrentAddress"].ToString();
                TextBox8.Text = row["LoanRemarks"].ToString();
            }
            else
            {

                Label10.Text = "Loan not found.";
                TextBox1.Text = "";
                TextBox2.Text = "";
                DropDownList1.SelectedIndex = 0;
                DropDownList2.SelectedIndex = 0;
                TextBox5.Text = "";
                TextBox6.Text = "";
                TextBox7.Text = "";
                TextBox8.Text = "";
            }

            cn.Close();
        }
    }
}