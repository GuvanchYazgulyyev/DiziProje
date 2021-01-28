using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DiziProje.Entity;

namespace DiziProje
{
    public partial class Default : System.Web.UI.Page
    {
        BlogFilimVTEntities1 dr = new BlogFilimVTEntities1();

        protected void Page_Load(object sender, EventArgs e)
        {
            var bloglar = dr.TBLBLOG.ToList();
            Repeater1.DataSource = bloglar;
            Repeater1.DataBind();


            var bloglar2 = dr.TBLKATEGORI.ToList();
            Repeater2.DataSource = bloglar2;
            Repeater2.DataBind();

            var bloglar3 = dr.TBLBLOG.Take(7).ToList();
            Repeater3.DataSource = bloglar3;
            Repeater3.DataBind();


            var yormicrk = dr.TBLYORUM.Take(5).ToList();
            Repeater4.DataSource = yormicrk;
            Repeater4.DataBind();

        }

        protected void BtnAra_Click(object sender, EventArgs e)
        {
            var bloglar = dr.TBLBLOG.Where(f => f.BLOGBASLIK.Contains(TxtSearch.Text)).ToList();
            Repeater1.DataSource = bloglar;
            Repeater1.DataBind();
        }
    }
}