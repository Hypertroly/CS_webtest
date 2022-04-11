using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;



namespace CS_webtest
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-Q9LNK8Q;Initial Catalog=gbrowsergames;Integrated Security=True");
                Console.WriteLine("funciona carai");
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into game values(@nome, @url, @urlvideo, @descricao, @categoria)", con);
                    cmd.Parameters.AddWithValue("nome", TextBox1.Text);
                    cmd.Parameters.AddWithValue("url", TextBox2.Text);
                    cmd.Parameters.AddWithValue("urlvideo", TextBox3.Text);
                    cmd.Parameters.AddWithValue("descricao", TextBox4.Text);
                    cmd.Parameters.AddWithValue("categoria", TextBox5.Text);
                    cmd.ExecuteNonQuery();

                    TextBox1.Text = "";
                    TextBox2.Text = "";
                    TextBox3.Text = "";
                    TextBox4.Text = "";
                    TextBox5.Text = "";

                    cmd.Dispose();
                    con.Close();
                }
            }
            catch (SqlException exc)
            {
                Console.WriteLine("deu ruim", exc);
            }
        }
        }
    }
