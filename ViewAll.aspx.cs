using System;
using System.Web.UI.WebControls;

namespace HDFC_Loans
{
    public partial class ViewAll : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGridView();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            BindGridView();
        }

        private void BindGridView()
        {
            try
            {
                SqlDataSource3.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"E:\\Web With ASP.Net By PJT\\Project1\\HDFC_Loans\\App_Data\\HDFC-Loans.mdf\";Integrated Security=True";

                GridView1.DataBind();

                Label1.Text = " " + GridView1.Rows.Count;
            }
            catch (Exception ex)
            {
                Label1.Text = "Error: " + ex.Message;
            }
        }
    }
}
