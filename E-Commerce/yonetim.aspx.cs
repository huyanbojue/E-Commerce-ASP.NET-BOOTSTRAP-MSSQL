using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;
namespace WebApplication3
{
    public partial class yonetim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //if (FileUpload1.HasFile)
            //    try
            //    {
            //        SqlConnection baglanti = new SqlConnection("Data Source=CASPERNIRVANA;Initial Catalog=eticaret;Integrated Security=True");
            //        baglanti.Open();
                   
                   
            //        FileUpload1.SaveAs(Request.PhysicalApplicationPath + "resimler//" + FileUpload1.FileName);
            //        Label1.Text = "Dosya Adı: " +
                        
            //            FileUpload1.PostedFile.ContentLength +
            //            "<br />Dosya Türü: " +
            //            FileUpload1.PostedFile.ContentType;
            //        baglanti.Open();
            //        SqlCommand komut = new SqlCommand("Insert INTO urunler ( urun_img,urunad ) Values( '" + FileUpload1.FileName.ToString() + "','" + TextBox1.Text + "')",baglanti);
            //        komut.ExecuteNonQuery();
            //        baglanti.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        Label1.Text = "Hata Oluştu: " + ex.Message.ToString();
            //    }
            //else
            //{
            //    Label1.Text = "Dosya Seçin ve Yükleyin";
            //}
        }
    }
}