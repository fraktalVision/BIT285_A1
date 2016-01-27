/**
* Fred Jaworski
* Assignment 1
* 1/26/2016
* 
* Displays a customized welcome message based on username
* displays a table of all currently logged in users
* provides log out and refresh buttons
*/
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BIT285_A1
{
	public partial class welcome : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			username.Text = (string) Session["userName"];
			table.DataSource = (DataTable) Application["visitorTable"];
			table.DataBind();
		}

		protected void refresh_Click(object sender, EventArgs e)
		{
			// rebind table to refresh
			table.DataBind();
		}

		protected void logout_Click(object sender, EventArgs e)
		{
			// get reference to data table
			DataTable dt = (DataTable) Application["visitorTable"];

			// delete any rows with the current client's username
			foreach (DataRow row in dt.Rows)
			{
				if (row["Username"].ToString() == ((string) Session["userName"]))
					row.Delete();
			}
			dt.AcceptChanges();

			// refresh the table
			refresh_Click(sender, e);

			returnLogin.Visible = true;
		}
	}
}