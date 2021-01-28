using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziProje.Entity;

namespace DiziProje.AdminSayfalar
{
    public partial class BlogSil : System.Web.UI.Page
    {
        BlogFilimVTEntities1 dr
            = new BlogFilimVTEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(Request.QueryString["BLOGID"]);
            var blog = dr.TBLBLOG.Find(i);
            dr.TBLBLOG.Remove(blog);
            dr.SaveChanges();
            Response.Redirect("AdminBlog.aspx");
        }
    }
}