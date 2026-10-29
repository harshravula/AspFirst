<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="doSum.aspx.cs" Inherits="Aspfirst.doSum" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <input type ="text" name="t1" id="t1" /><br />
        <input type ="text" name="t2" id="t2" /><br />
        <input type ="text" name="t3" id="t3" /><br />
        <input type ="submit" />





        <p>
            &nbsp;</p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </p>





    </form>
</body>
</html>
