using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziProje.Entity;

namespace DiziProje.AdminSayfalar
{
    public partial class YorumSil : System.Web.UI.Page
    {
        BlogFilimVTEntities1 dr
            = new BlogFilimVTEntities1();

        protected void Page_Load(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(Request.QueryString["YORUMID"]);
            var yorumsil = dr.TBLYORUM.Find(x);
            dr.TBLYORUM.Remove(yorumsil);
            dr.SaveChanges();
            Response.Redirect("AdminYorum.aspx");
        }
    }
}