using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.Sql;


namespace WebApplication3
{
    public partial class urun : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection("Data Source=CASPERNIRVANA;Initial Catalog=eticaret;Integrated Security=True");
            baglanti.Open();
            //www.aspnetornekleri.com
            SqlCommand komut = new SqlCommand ("Select * from urunler", baglanti);
            Repeater1.DataSource = komut.ExecuteReader();
            Repeater1.DataBind();
            baglanti.Close();
        }
    }
}