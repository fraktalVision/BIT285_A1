using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;
using System.Data;

namespace BIT285_A1
{
	public class Global : System.Web.HttpApplication
	{

		/**
		* Initialize a new DataTable variable for the application,
		* define the data types in its columns
		*/
		void Application_Start(object sender, EventArgs e)
		{
			DataTable dt = new DataTable();
			dt.Columns.Add(new DataColumn("session_id",
				System.Type.GetType("System.String")));
			dt.Columns.Add(new DataColumn("username",
				System.Type.GetType("System.String")));
			dt.Columns.Add(new DataColumn("login_time",
				System.Type.GetType("System.DateTime")));
			dt.Columns.Add(new DataColumn("ip_address",
				System.Type.GetType("System.String")));
			// store the DataTable as an Application variable
			Application["visitorTable"] = dt;
		}

		protected void Session_Start(object sender, EventArgs e)
		{
			// Setup Session variables with default values
			Session["userName"] = "Guest";
			Session["password"] = "!!Pass!!";
			Session["firstName"] = "Guest";
			Session["lastName"] = "Guest";
			Session["email"] = "guest@guest.com";
			Session["program"] = "Degree";
			Session["birthYear"] = "2016";
			Session["favColor"] = "null";
		}

		protected void Application_BeginRequest(object sender, EventArgs e)
		{

		}

		protected void Application_AuthenticateRequest(object sender, EventArgs e)
		{

		}

		protected void Application_Error(object sender, EventArgs e)
		{

		}

		protected void Session_End(object sender, EventArgs e)
		{

		}

		protected void Application_End(object sender, EventArgs e)
		{

		}
	}
}