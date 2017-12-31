<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="CalculatorWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
    <div>
        
        <table style="width: 25%;">
            <tr>
                <td class="auto-style1"><b>First Number</b></td>
                <td>
                    <asp:TextBox ID="txtFirstNumber" runat="server"></asp:TextBox></td>
                
            </tr>
            <tr>
                <td class="auto-style1"><b>Second Number</b></td>
                <td><asp:TextBox ID="txtSecondNumber" runat="server"></asp:TextBox></td>
              
            </tr>
            <tr>
                 <td class="auto-style1" ><b>Result</b></td>
                <td><asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label></td>
                
            </tr>
            <tr>
                <td></td>
                 <td class="auto-style1">
                    <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click1"  />

                 </td>
                
            </tr>

              <tr>
                 <td class="2">
                     <asp:GridView ID="gvCalculations" runat="server"></asp:GridView>
                 </td>
                
                
            </tr>
        </table>

    </div>
    </form>
</body>
</html>
