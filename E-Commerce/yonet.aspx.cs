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
    public partial class yonet : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click1(object sender, EventArgs e)
        {

            if (FileUpload1.HasFile)
                try
                {
                    SqlConnection baglanti = new SqlConnection("Data Source=CASPERNIRVANA;Initial Catalog=eticaret;Integrated Security=True");
                    baglanti.Open();

                   


                    FileUpload1.SaveAs(Request.PhysicalApplicationPath + "resimler//" + FileUpload1.FileName);
                    Label1.Text = "Dosya Adı: " +

                        FileUpload1.PostedFile.ContentLength +
                        "<br />Dosya Türü: " +
                        FileUpload1.PostedFile.ContentType;

                    SqlCommand komut = new SqlCommand("Insert INTO urunler ( urun_img ,urunad,urun_aciklama) Values( 'resimler/" + FileUpload1.FileName.ToString() + "','" + TextBox1.Text + "','" + TextBox2.Text + "')", baglanti);
                    komut.ExecuteNonQuery();
                    baglanti.Close();



                    
                   



                }
                catch (Exception ex)
                {
                    Label1.Text = "Hata Oluştu: " + ex.Message.ToString();
                }
            else
            {
                Label1.Text = "Dosya Seçin ve Yükleyin";
            }

        }

    

       
    }
}