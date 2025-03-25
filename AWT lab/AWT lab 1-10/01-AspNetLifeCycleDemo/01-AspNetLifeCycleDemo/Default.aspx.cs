using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Practical_1
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            Label1.Text += "<br/>PreInit";
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            Label1.Text += "<br/>Init";
        }

        protected void Page_InitComplete(object sender, EventArgs e)
        {
            Label1.Text += "<br/>InitComplete";
        }

        protected override void OnPreLoad(EventArgs e)
        {
            base.OnPreLoad(e);
            Label1.Text += "<br/>PreLoad";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text += "<br/>Load";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Label1.Text += "<br/>Button Clicked";
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Label1.Text += "<br/>LoadComplete";
        }

        protected override void OnPreRender(EventArgs e)
        {
            base.OnPreRender(e);
            Label1.Text += "<br/>PreRender";
        }

        protected override void OnSaveStateComplete(EventArgs e)
        {
            base.OnSaveStateComplete(e);
            Label1.Text += "<br/>SaveStateComplete";
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            // Note: You won't see this output as the page is already unloaded
        }
    }
}
