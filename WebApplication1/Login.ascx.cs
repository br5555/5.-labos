using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class WebUserControl1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool CheckUsernameAndPassword()
        {
            XElement korisnici = XElement.Load(@"./App_Data/korisnici.xml");
            var users = korisnici.Elements().Select(el => new
                { username = (string)el.Element("korisnickoIme"), password = (string)el.Element("lozinka") });

            if (!users.Any(user => user.username.Equals(this.username.Text)))
                return false;

            return users.Where(user => string.Compare(user.username, this.username.Text, true) == 0 && string.Compare(user.password, this.password.Text, true) == 0).Any();
        }

        private void DisplayBooks()
        {
            using (DataSet ds = new DataSet())
            {
                ds.ReadXml(@"./App_Data/popisKnjiga.xml")
            }

        }

        protected void Login_Click(object sender, EventArgs e)
        {
            if (CheckUsernameAndPassword())
            {
                this.PanelDisplay.Visible = true;
            }
            else
            {
                this.PanelLogin.Visible = false;
                this.PanelError.Visible = true;
                DisplayBooks();
            }

        }
    }
}