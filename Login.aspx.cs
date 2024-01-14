using System;
using System.Configuration;
using System.Data.SqlClient;

namespace HDFC_Loans
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Username = TextBox1.Text.Trim();
            string Password = TextBox2.Text.Trim();

            if (ValidateCredentials(Username, Password))
            {
                Session["LoggedInUsername"] = Username;

                Response.Redirect("WebForm1.aspx");
            }
            else
            {
                Label3.Text = "Invalid username or password.";
            }
        }


        private bool ValidateCredentials(string username, string password)
        {
            string connectionstring = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Web With ASP.Net By PJT\\Project1\\HDFC_Loans\\App_Data\\HDFC-Loans.mdf\";Integrated Security=True";
            string cn = connectionstring;
            using (SqlConnection connection = new SqlConnection(cn))
            {
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    return count > 0;
                }
            }
        }
    }
}
