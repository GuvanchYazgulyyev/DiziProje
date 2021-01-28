using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziProje.Entity;

namespace DiziProje
{
    public partial class Login : System.Web.UI.Page
    {
        BlogFilimVTEntities1 dr
            = new BlogFilimVTEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var giris = from x in dr.TBLADMIN
                        where x.KULLANICI == TextBox1.Text
  && x.SIFRE == TextBox2.Text
                        select x;
            if (giris.Any())
            {
                Session.Add("KULLANICI", TextBox1.Text);
                Response.Redirect("/AdminSayfalar/AdminBlog.aspx/");
            }
            else
            {
                Response.Write("Hatalı Giriş!!!");
            }
        }
    }
}