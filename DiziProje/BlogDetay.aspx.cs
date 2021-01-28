using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziProje.Entity;

namespace DiziProje
{
    public partial class BlogDetay : System.Web.UI.Page
    {
        BlogFilimVTEntities1 dr =
            new BlogFilimVTEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Request.QueryString["BLOGID"]);
            var blgdetay = dr.TBLBLOG.Where(x => x.BLOGID == a).ToList();
            Repeater1.DataSource = blgdetay;
            Repeater1.DataBind();

            var yorumlar = dr.TBLYORUM.Where(c => c.YORUMBLOG == a).ToList();
            Repeater2.DataSource = yorumlar;
            Repeater2.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(Request.QueryString["BLOGID"]);
            TBLYORUM t = new TBLYORUM();
            t.KULLANICIAD = TextBox1.Text;
            t.MAIL = TextBox2.Text;
            t.YORUMICERIK = TextBox3.Text;
            t.YORUMBLOG = a;
            dr.TBLYORUM.Add(t);
            dr.SaveChanges();
            Response.Redirect("BlogDetay.aspx?BLOGID=" + a);
        }
    }
}