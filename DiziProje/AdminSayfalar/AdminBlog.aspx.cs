using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziProje.Entity;

namespace DiziProje.AdminSayfalar
{
    public partial class AdminBlog : System.Web.UI.Page
    {
        BlogFilimVTEntities1 dr
            = new BlogFilimVTEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {

            //Response.Write(Session["KULLANICI"].ToString());

            if (Session["KULLANICI"] == null)
            {
                Response.Redirect("~/Login.aspx");
            }
            else
            {
                Response.Write("Hoşgeldiniz...." + Session["KULLANICI"].ToString());
            }

            //var blog = (from x in dr.TBLBLOG
            //            select new
            //            {
            //                x.BLOGID,
            //                x.BLOGBASLIK,
            //                x.BLOGTARIH,
            //                x.TBLTUR.TURAD,
            //                x.TBLKATEGORI.KATEGORIAD

            //            }).ToList();
            //Repeater1.DataSource = blog;
            //Repeater1.DataBind();
            Repeater1.DataSource = dr.TBLBLOG.ToList();
            Repeater1.DataBind();
        }
    }
}