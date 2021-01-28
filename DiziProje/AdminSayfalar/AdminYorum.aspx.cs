using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziProje.Entity;
namespace DiziProje.AdminSayfalar
{
    public partial class AdminYorum : System.Web.UI.Page
    {
        BlogFilimVTEntities1 dr =
              new BlogFilimVTEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            var yorumlar = (from x in dr.TBLYORUM
                            select new
                            {
                                x.YORUMID,
                                x.KULLANICIAD,
                                x.TBLBLOG.BLOGBASLIK
                            }).ToList();
            Repeater1.DataSource = yorumlar;
            Repeater1.DataBind();
        }
    }
}