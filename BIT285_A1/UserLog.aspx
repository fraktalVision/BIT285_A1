<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserLog.aspx.cs" Inherits="BIT285_A1.welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script language="javascript" type="text/javascript">
        // provides a constantly updating clock for the page
        function UpdateTime()
        {
            var today = new Date();
            var day = today.getDay(); // int for now
            var month = today.getMonth(); // int for now
            var date = today.getDate();
            var year = today.getYear();
            var hours = today.getHours();
            var minutes = today.getMinutes();
            var seconds = today.getSeconds();

            // adds a 0 to keep the formatting of the clock
            if (seconds <= 9)
                seconds = "0" + seconds;

            // give the day a string name instead of an int
            switch (day) 
            {
                case 0:
                    day = "Sun";
                    break;
                case 1:
                    day = "Mon";
                    break;
                case 2:
                    day = "Tues";
                    break;
                case 3:
                    day = "Wed";
                    break;
                case 4:
                    day = "Thurs";
                    break;
                case 5:
                    day = "Fri";
                    break;
                case 6:
                    day = "Sat";
                    break;
                default :
                    day = "Day"; // error
            }

            // give the month a string name
            switch (month)
            {
                case 0:
                    month = "Jan";
                    break;
                case 1:
                    month = "Feb";
                    break;
                case 2:
                    month = "Mar";
                    break;
                case 3:
                    month = "Apr";
                    break;
                case 4:
                    month = "May";
                    break;
                case 5:
                    month = "Jun";
                    break;
                case 6:
                    month = "Jul";
                    break;
                case 7:
                    month = "Aug";
                    break;
                case 8:
                    month = "Sep";
                    break;
                case 9:
                    month = "Oct";
                    break;
                case 10:
                    month = "Nov";
                    break;
                case 11:
                    month = "Dec";
                    break;
                default:
                    month = "Month"; // error
            }

            // combine all of the data together
            var total = day + " " + month + " " + date +
                " " + hours + ":" + minutes + ":" + seconds +
                " PST " + year;

            // fill span with total
            time.innerHTML = total;

            //set timeout to increment every second
            setTimeout("UpdateTime();", 1000);
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <p id="time"></p>
        <h1>Hello, <asp:Label runat="server" ID="username"/>. Thank you for logging in.</h1>
        
        <h3>Other active users in the application are shown below.</h3>
        <asp:GridView runat="server" ID="table"></asp:GridView>
        
        <asp:Button runat="server" ID="refresh" Text="Refresh Table" OnClick="refresh_Click"/>
        <asp:Button runat="server" ID="logout" Text="Log Out" OnClick="logout_Click"/><br/>

        <asp:HyperLink runat="server" ID="returnLogin" 
            Text="You have successfully logged out. Click here to return to the login page."
            NavigateUrl="~/login.aspx" Visible ="False"/>
    </div>
    </form>
</body>
</html>
