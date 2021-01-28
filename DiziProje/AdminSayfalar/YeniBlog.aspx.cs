using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziProje.Entity;

namespace DiziProje.AdminSayfalar
{
    public partial class YeniBlog : System.Web.UI.Page
    {
        BlogFilimVTEntities1 dr
            = new BlogFilimVTEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
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
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            TBLBLOG t = new TBLBLOG();
            t.BLOGBASLIK = TextBox1.Text;
            t.BLOGGORSEL = TextBox3.Text;
            t.BLOGICERIK = TextBox4.Text;
            t.BLOGTARIH = DateTime.Parse(TextBox2.Text);
            t.BLOGTUR = byte.Parse(DropDownList1.SelectedValue);
            t.BLOGKATEGORI = byte.Parse(DropDownList2.SelectedValue);
            dr.TBLBLOG.Add(t);
            dr.SaveChanges();
            Response.Redirect("AdminBlog.aspx");
        }
    }
}