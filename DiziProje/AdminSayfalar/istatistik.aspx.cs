using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziProje.Entity;

namespace DiziProje.AdminSayfalar
{
    public partial class istatistik : System.Web.UI.Page
    {
        BlogFilimVTEntities1 dr
            = new BlogFilimVTEntities1();
        protected void Page_Load(object sender, EventArgs e)
        {
            Lable1.Text = dr.TBLBLOG.Count().ToString();
            Lable2.Text = dr.TBLYORUM.Count().ToString();
            Label3.Text = dr.TBLBLOG.Where(x => x.BLOGTUR == 1).Count().ToString();
            Label4.Text = dr.TBLBLOG.Where(x => x.BLOGTUR == 2).Count().ToString();
            Label5.Text = dr.TBLBLOG.Where(x => x.BLOGTUR == 4).Count().ToString();
            Label7.Text = dr.TBLBLOG.Where(x => x.BLOGTUR == 3).Count().ToString();
            //Label8.Text = dr.TBLTUR.Where(x => x.TURID == 5).Count().ToString();
            Label8.Text = dr.TBLBLOG.Where(x => x.BLOGTUR == 5).Count().ToString();
            Label6.Text = dr.TBLBLOG.Where(y => y.BLOGID == (dr.TBLYORUM.GroupBy(x => x.YORUMBLOG)
            .OrderByDescending(x => x.Count())
              .Select(c => c.Key).FirstOrDefault())).Select(f => f.BLOGBASLIK).FirstOrDefault();
        }
    }
}