<%@ Page Title="" Language="C#" MasterPageFile="~/Head.Master" AutoEventWireup="true" CodeBehind="information.aspx.cs" Inherits="Idlted.information" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div style="width:80%; margin-left:10%;">
        <ul class="nav nav-tabs">
        <li role="presentation" class="active"><a href="#">个人信息</a></li>
        <li role="presentation"><a href="#">我的订单</a></li>
        <li role="presentation"><a href="#">我的出售</a></li>
        </ul>
         </div>
        <form runat="server">
        <div style="width:80%;margin-left:10%;margin-top:20px;">
            <div style="width:140px;height:600px;margin-right:20px;float:left;">
                <img src="images/test/head.jpg" title="点击修改图片" onclick="javascript:fileSelect()" style="float:left;" width="140" height="140" alt="..." class="img-rounded"/>
            </div>
                <div>
                <asp:Label ID="Label1" runat="server" Text="账号："></asp:Label><asp:TextBox ID="Account" class="form-control" Width="332" readonly="true" runat="server"></asp:TextBox><br />
            <asp:Label ID="label" runat="server" Text="昵称:"></asp:Label><asp:TextBox ID="tetName" Width="332" class="form-control" placeholder="Text input" runat="server"></asp:TextBox><br />
                <input type="hidden" style="width:160px;" /><asp:Label ID="Label2" runat="server" Text="电话"></asp:Label><asp:TextBox ID="txtPhone" Width="332" class="form-control" placeholder="Text input" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label3" runat="server" Text="邮箱"></asp:Label><asp:TextBox ID="txtEmail" Width="332" class="form-control" placeholder="Text input" runat="server"></asp:TextBox><br />
                <asp:Label ID="Label4" runat="server" Text="籍贯:"></asp:Label><asp:TextBox ID="txtAdress" Width="332" class="form-control" runat="server"></asp:TextBox>
                <asp:Button ID="btusave" class="btn btn-default" runat="server" Text="保存" OnClick="btusave_Click" />
             </div>
        </div>
         </form>
    </div>
</asp:Content>
