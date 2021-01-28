using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziProje.Entity;

namespace DiziProje
{
    public partial class Hakkimda : System.Web.UI.Page
    {
        BlogFilimVTEntities1 dr =
            new BlogFilimVTEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = dr.TBLHAKKIMIZDA.ToList();
            Repeater1.DataBind();
        }
    }
}