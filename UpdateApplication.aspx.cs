using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HDFC_Loans
{
    public partial class UpdateApplication : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Web With ASP.Net By PJT\\Project1\\HDFC_Loans\\App_Data\\HDFC-Loans.mdf\";Integrated Security=True";
            SqlConnection cn = new SqlConnection(connectionstring);

            cn.Open();

            string query = "UPDATE [Loan] SET AccountNo=@AccountNo, HolderName=@HolderName, LoanCategory=@LoanCategory, LoanType=@LoanType, IssueDate=@IssueDate, Amount=@Amount, CurrentAddress=@CurrentAddress, LoanRemarks=@LoanRemarks WHERE LoanNo=@LoanNo";
            SqlCommand cmd = new SqlCommand(query, cn);

            cmd.Parameters.AddWithValue("@AccountNo", TextBox1.Text);
            cmd.Parameters.AddWithValue("@HolderName", TextBox2.Text);
            cmd.Parameters.AddWithValue("@LoanCategory", DropDownList1.Text);
            cmd.Parameters.AddWithValue("@LoanType", DropDownList2.Text);
            cmd.Parameters.AddWithValue("@IssueDate", TextBox5.Text);
            cmd.Parameters.AddWithValue("@Amount", TextBox6.Text);
            cmd.Parameters.AddWithValue("@CurrentAddress", TextBox7.Text);
            cmd.Parameters.AddWithValue("@LoanRemarks", TextBox8.Text);
            cmd.Parameters.AddWithValue("@LoanNo", TextBox9.Text);

            cmd.ExecuteNonQuery();

            cn.Close();

            Label10.Text = "Loan application updated successfully!";
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

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