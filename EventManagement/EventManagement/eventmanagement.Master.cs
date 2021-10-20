using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EventManagement
{
    public partial class eventmanagement : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void lbtnprofile_Click(object sender, EventArgs e)
        {
            int user_id = Convert.ToInt32(Request.QueryString["User"]);
            Response.Redirect("ProfilePage.aspx?User=" + user_id);
        }

        protected void lbtnbookingstatus_Click(object sender, EventArgs e)
        {
            int user_id = Convert.ToInt32(Request.QueryString["User"]);
            Response.Redirect("Receipt.aspx?User=" + user_id);
        }
    }
}