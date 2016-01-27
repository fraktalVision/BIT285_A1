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
			dt.Columns.Add(new DataColumn("Session ID",
				System.Type.GetType("System.String")));
			dt.Columns.Add(new DataColumn("Username",
				System.Type.GetType("System.String")));
			dt.Columns.Add(new DataColumn("Login Time",
				System.Type.GetType("System.DateTime")));
			dt.Columns.Add(new DataColumn("IP Address",
				System.Type.GetType("System.String")));
			// store the DataTable as an Application variable
			Application["visitorTable"] = dt;

			// track the number of visitors logged on to the application
			Application["count"] = 0;
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