<%@ Page Language="C#" AutoEventWireup="true" 
    CodeBehind="Fizzbuzz.aspx.cs" 
    Inherits="practice4.Fizzbuzz" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Fizz Buzz</title>
</head>
<body>
    <div class="text-center">
    <h1>Fizz Buzz</h1>
    </div>
    <form id="form1" runat="server">
        <div style="width: 457px; height: 330px;">
            <asp:Label ID="Label1" runat="server" Text="Enter a Number"></asp:Label><br />
            <asp:TextBox ID="TextBox1" runat="server" ></asp:TextBox>
            
            &nbsp;<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Please enter a Number between 1 and 1000" ForeColor="Red" MaximumValue="1000" MinimumValue="1" SetFocusOnError="True" Type="Integer"></asp:RangeValidator>
            
            <br /><br />
            <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" /><br /><br />
            <asp:Label ID="Label2" runat="server" Text=""></asp:Label><br /><br />
            <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
            <br />
            
            <asp:Table ID="Table1" runat="server">
                <asp:TableRow runat="server">
                </asp:TableRow>
            </asp:Table>
            <asp:Button ID="Button3" runat="server" Text="Next" Visible="False" />
            <asp:Button ID="Button2" runat="server" Text="Prev" Visible="False" />
            <br />
            
            </div>
    </form>
</body>
</html>
