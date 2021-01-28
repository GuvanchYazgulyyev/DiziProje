using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziProje.Entity;

namespace DiziProje.AdminSayfalar
{
    public partial class YorumGuncelle : System.Web.UI.Page
    {
        BlogFilimVTEntities1 dr
            = new BlogFilimVTEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int y = Convert.ToInt32(Request.QueryString["YORUMID"]);
            if (Page.IsPostBack == false)
            {
                var yrmgoster = dr.TBLYORUM.Find(y);
                TextBox1.Text = yrmgoster.YORUMID.ToString();
                TextBox2.Text = yrmgoster.KULLANICIAD;
                TextBox3.Text = yrmgoster.YORUMICERIK;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int y = int.Parse(Request.QueryString["YORUMID"]);
            var yrguncelle = dr.TBLYORUM.Find(y);
            yrguncelle.YORUMID = int.Parse( TextBox1.Text);
            yrguncelle.KULLANICIAD =TextBox2.Text;
            yrguncelle.YORUMICERIK = TextBox3.Text;
            dr.SaveChanges();
            Response.Redirect("AdminYorum.aspx");
        }
    }
}