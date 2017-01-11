using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Segment;



namespace GoodExample
{
    public partial class Register : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            Analytics.Initialize("ktxXPGmLDGoLTApP5KInz5oQwWvrXhCU");
            
            Analytics.Client.Identify("ianlee0110", new Segment.Model.Traits() {
            { "name", "nisrin0110" },
            { "email", "chinglin0110.li@gmail.com" },
            { "friends", 200 }
});

        }
    }
}