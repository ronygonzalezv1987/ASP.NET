<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplicationServidor.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" lang ="javascript" >
        function GetEmployeeById()
        {
            var id = document.getElementById("txtID").value;
            WebApplicationServidor.EmployeesService.GetEmployeeById(id, GetEmployeeByIdSuccessCallback, GetEmployeeByIdFailedCallback);
        }

        function GetEmployeeByIdSuccessCallback(Results)
        {
            document.getElementById("txtID").value = Results["ID"];
            document.getElementById("txtFirstName").value = Results["FirstName"];
            document.getElementById("txtLastName").value = Results["LastName"];
            document.getElementById("txtMail").value = Results["Mail"];
            document.getElementById("txtPhone").value = Results["Phone"];
            document.getElementById("txtSalary").value = Results["Salary"];
        }

        function GetEmployeeByIdFailedCallback(errors)
        {
            alert(errors.get_message());
        }
    </script>


    <style type="text/css">
        .auto-style1 {
            width: 275px;
        }
        .auto-style2 {
            width: 414px;
        }
        #btnGetEmployee {
            height: 25px;
            width: 124px;
            margin-left: 29px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            <Services>
                <asp:ServiceReference Path="~/EmployeesService.asmx"/>
            </Services>
        </asp:ScriptManager>
        
    <div>
    <table style="width: 30%;">
            <tr>
                <td class="auto-style1"><b>ID</b></td>
                <td class="auto-style2">
                    <asp:TextBox ID="txtID" runat="server" Width="84px"></asp:TextBox>
                    <input id ="btnGetEmployee" type="button"  value="Get Employee"  onclick="GetEmployeeById()"  />

                 </td>
                
            </tr>
            <tr>
                <td class="auto-style1"><b>First Name</b></td>
                <td class="auto-style2"><asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox></td>
              
            </tr>
            <tr>
                 <td class="auto-style1"><b>Last Name</b></td>
                <td class="auto-style2"><asp:TextBox ID="txtLastName" runat="server"></asp:TextBox></td>
                
            </tr>

            <tr>
                <td class="auto-style1"><b>Mail</b></td>
                <td class="auto-style2"><asp:TextBox ID="txtMail" runat="server" Width="179px"></asp:TextBox></td>
                
            </tr>

            <tr>
                <td class="auto-style1"><b>Phone</b></td>
                <td class="auto-style2"><asp:TextBox ID="txtPhone" runat="server"></asp:TextBox></td>
                
            </tr>
          <tr>
                <td class="auto-style1"><b>Salary</b></td>
                <td class="auto-style2"><asp:TextBox ID="txtSalary" runat="server"></asp:TextBox></td>
                
            </tr>

          
        </table>




    </div>
    </form>
</body>
</html>
