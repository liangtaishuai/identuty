<%@ Page Title="" Language="C#" MasterPageFile="~/Head.Master" AutoEventWireup="true" CodeBehind="Commation.aspx.cs" Inherits="Idlted.Commation" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:76%;height:900px;margin-left:13%;">
    <div style="width:100%;height:900px;" class="row">
    <asp:Repeater ID="dgdShowData" runat="server">
        <ItemTemplate>
          <div class="col-sm-6 col-md-4" style="float:left; margin-top:20px; width:250px;height:412px;">
    <div class="thumbnail">
        <asp:HyperLink ID="HyperLink1" NavigateUrl='<%# "~/spm.aspx?ID="+Eval("ID") %>' Target="_blank" runat="server">
      <img src='<%# "images/img/"+Eval("Imageurl")+".jpg" %>' width="231" title='<%# Eval("Commodityname") %>' height="471" alt="..."/>
        </asp:HyperLink>
        <h5 style="float:left;color:red;">￥ <%# Eval("transferprice") %></h5>
        <h5 style="float:right;"><%# Eval("Adress") %></h5><br />
      <div class="caption">
        <h3><%# Eval("Commodityname") %></h3>
      </div>
    </div>
  </div>
      </ItemTemplate>
    </asp:Repeater>
    </div>
        <div style="width:100%;margin-bottom:10px;text-align:center;">
        <form runat="server">
        <asp:Button ID="btnProv" runat="server" Text="上一页" OnClick="btnProv_Click" />
            第<asp:Label ID="lblPageIndex" runat="server" Text=""></asp:Label>页
            <asp:Button ID="btnNext" runat="server" Text="下一页" OnClick="btnNext_Click" />
        </form>
        </div>
    </div>
</asp:Content>
