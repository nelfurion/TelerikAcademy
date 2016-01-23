using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;

namespace Hello
{
    public partial class Hello : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HtmlGenericControl newLi = new HtmlGenericControl("li");
            newLi.InnerText = "Page_Load()";
            this.eventsList.Controls.Add(newLi);
        }

        protected override void OnInitComplete(EventArgs e)
        {
            HtmlGenericControl newLi = new HtmlGenericControl("li");
            newLi.InnerText = "OnInitComplete()";
            this.eventsList.Controls.Add(newLi);
            base.OnInitComplete(e);
        }

        protected override void OnPreRenderComplete(EventArgs e)
        {
            HtmlGenericControl newLi = new HtmlGenericControl("li");
            newLi.InnerText = "OnPreRenderComplete()";
            this.eventsList.Controls.Add(newLi);
            base.OnPreRenderComplete(e);
        }

        protected override void OnLoadComplete(EventArgs e)
        {
            HtmlGenericControl newLi = new HtmlGenericControl("li");
            newLi.InnerText = "OnLoadComplete()";
            this.eventsList.Controls.Add(newLi);
            base.OnLoadComplete(e);
        }

        protected override void OnPreInit(EventArgs e)
        {
            HtmlGenericControl newLi = new HtmlGenericControl("li");
            newLi.InnerText = "OnPreInit()";
            this.eventsList.Controls.Add(newLi);
            base.OnPreInit(e);
        }

        protected override void OnPreLoad(EventArgs e)
        {
            HtmlGenericControl newLi = new HtmlGenericControl("li");
            newLi.InnerText = "OnPreLoad()";
            this.eventsList.Controls.Add(newLi);
            base.OnPreLoad(e);
        }

        protected override void OnError(EventArgs e)
        {
            HtmlGenericControl newLi = new HtmlGenericControl("li");
            newLi.InnerText = "OnError()";
            this.eventsList.Controls.Add(newLi);
            base.OnError(e);
        }

        protected override void OnSaveStateComplete(EventArgs e)
        {
            HtmlGenericControl newLi = new HtmlGenericControl("li");
            newLi.InnerText = "OnSaveStateComplete()";
            this.eventsList.Controls.Add(newLi);
            base.OnSaveStateComplete(e);
        }

        protected void Greet(object sender, EventArgs e)
        {
            this.greetLabel.Text = "Hello " + this.nameTextBox.Text;
        }
    }
}