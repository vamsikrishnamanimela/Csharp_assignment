<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Laptop.aspx.cs" Inherits="CodebasedExam_No4_Q2.Laptop" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:aqua">
     <div style="text-align:center;background-color:red">
         <h2>This Is Code_Based_Exam_No4_Q2</h2>
         </div>
    <form id="form1" runat="server" style="align-content:center">


    <div style="text-align:center">

 &nbsp;SELECT YOUR LAPTOP&nbsp; :&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownList" runat="server" Height="16px" Width="154px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
</asp:DropDownList>
<br/>

<asp:Image ID="Laptops" runat="server" Height="224px" style="margin-left: 0px; margin-top: 40px" Width="365px" ImageUrl="~/images/Hp.jfif" />
<p>
&nbsp;&nbsp;
PRICE OF THE LOPTOP :&nbsp; <asp:Button ID="LoptopPrice" runat="server" OnClick="Button_Click" style="margin-left:40px" Text="Price" Width="161px" Height="25px" />
</p>
        <p>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

<asp:TextBox ID="TextBox" runat="server" OnTextChanged="TextBox_Text" style="margin-top: 10px; margin-left: 124px;" Width="149px" Height="16px"></asp:TextBox>
</p>
    </div>
        </form>
</body>
</html>
