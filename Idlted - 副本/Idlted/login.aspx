<%@ Page Title="" Language="C#" MasterPageFile="~/Head.Master" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Idlted.login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
<link href="css/signin.css" rel="stylesheet"/>
    <div class="signin">
	<div class="signin-head"><img style="width:120px;height:120px;" src="images/test/head.jpg" alt="" class="img-circle"/></div>
	<form class="form-signin" runat="server"  role="form">
        <asp:TextBox ID="ACC" class="form-control"  placeholder="用户名" required="required" autofocus="autofocus" runat="server"></asp:TextBox>
        <asp:TextBox ID="password" class="form-control" placeholder="密码" required="required"  runat="server" TextMode="Password"></asp:TextBox>
        <asp:Button ID="btulogin" class="btn btn-lg btn-warning btn-block" runat="server" Text="登录" OnClick="btulogin_Click" />
        <asp:Label ID="tip" ForeColor="Red" runat="server" Text=""></asp:Label>
	</form>
</div>

<div style="text-align:center;margin:50px 0; font:normal 14px/24px 'MicroSoft YaHei';"> 
</div>

</asp:Content>
