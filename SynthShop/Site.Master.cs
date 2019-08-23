using System;
using System.Web;
using System.Web.UI;

namespace SynthShop
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SessionInfoLabel.Text = $"{HttpContext.Current.Session["MachineName"]}, {HttpContext.Current.Session["SessionStartTime"]}";
        }
    }
}