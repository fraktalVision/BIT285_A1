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
		}
	}
}