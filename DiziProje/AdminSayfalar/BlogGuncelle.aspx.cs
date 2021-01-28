using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziProje.Entity;

namespace DiziProje.AdminSayfalar
{
    public partial class BlogGuncelle : System.Web.UI.Page
    {
        BlogFilimVTEntities1 dr = new BlogFilimVTEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(Request.QueryString["BLOGID"]);
            if (Page.IsPostBack == false)
            {
                var turler = (from x in dr.TBLTUR
                              select new
                              {
                                  x.TURAD,
                                  x.TURID
                              }).ToList();
                DropDownList1.DataSource = turler;
                DropDownList1.DataBind();


                var kategori = (from c in dr.TBLKATEGORI
                                select new
                                {
                                    c.KATEGORIAD,
                                    c.KATEGORIID
                                }).ToList();
                DropDownList2.DataSource = kategori;
                DropDownList2.DataBind();

                var deger = dr.TBLBLOG.Find(y);
                TextBox1.Text = deger.BLOGBASLIK;
                TextBox2.Text = deger.BLOGTARIH.ToString();
                TextBox3.Text = deger.BLOGGORSEL;
                TextBox4.Text = deger.BLOGICERIK;
                DropDownList1.SelectedValue = deger.BLOGTUR.ToString();
                DropDownList2.SelectedValue = deger.BLOGKATEGORI.ToString();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["BLOGID"]);
            var blguncelle = dr.TBLBLOG.Find(y);
            blguncelle.BLOGBASLIK = TextBox1.Text;
            blguncelle.BLOGTARIH = DateTime.Parse(TextBox2.Text);
            blguncelle.BLOGGORSEL = TextBox3.Text;
            blguncelle.BLOGICERIK = TextBox4.Text;
            blguncelle.BLOGTUR = byte.Parse(DropDownList1.SelectedValue);
            blguncelle.BLOGKATEGORI = byte.Parse(DropDownList2.SelectedValue);
            dr.SaveChanges();
            Response.Redirect("AdminBlog.aspx");
        }
    }
}