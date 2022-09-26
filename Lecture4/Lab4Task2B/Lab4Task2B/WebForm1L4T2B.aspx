<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1L4T2B.aspx.cs" Inherits="Lab4Task2B.WebForm1L4T2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title> Shyed Shahriar Housaini MCE 07905536 Lab4Task4</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h4> Option: 1- Addition and 2- Subtraction:</h4>
             <table class="auto-style1">  
                <tr>  
                    <td class="auto-style3">  
                        <asp:Label ID="Label1" runat="server" Text="Number1:"></asp:Label></td>  
                    <td>  
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style2"></asp:TextBox></td>  
                </tr>  
                <tr>  
                    <td class="auto-style3">  
                        <asp:Label ID="Label2" runat="server" Text="Number2:"></asp:Label></td>  
                    <td>  
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style2"></asp:TextBox></td>  
                </tr> 

                 <tr>  
                    <td class="auto-style3">  
                        <asp:Label ID="Label3" runat="server" Text="Option:"></asp:Label></td>  
                    <td>  
                       <asp:CheckBox ID="CheckBox1" runat="server" Text="Add" />  
                       <asp:CheckBox ID="CheckBox2" runat="server" Text="Sub" />  
                    </td>   
                </tr> 
                <tr>  
                    <td> </td>
                    <td class="auto-style3">  
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /> </td>   
                    
                </tr> 
                 <tr>  
                    <td class="auto-style3">  
                        <asp:Label ID="Label4" runat="server" Text="result:"></asp:Label></td>  
                    <td>  
                        <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style2"></asp:TextBox></td>
                    
                </tr> 

            </table>          
        </div>
    </form>
</body>
</html>
