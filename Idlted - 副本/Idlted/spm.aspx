<%@ Page Title="" Language="C#" MasterPageFile="~/Head.Master" AutoEventWireup="true" CodeBehind="spm.aspx.cs" Inherits="Idlted.spm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width:80%;height:900px;margin-left:10%;">
            <asp:Repeater ID="Respm" runat="server">
                <ItemTemplate>
                <div style="width:100%;height:61px;border-top:2px solid gray;border-left:1px solid gray;border-right:1px solid gray;border-bottom:1px solid gray; ">
                    <div style="float:left;margin-right:10px;">
                    <a href="#">
                        <img src="images/test/head.jpg" width="60" height="60" alt="..." class="img-thumbnail"/>
                    </a>
                </div>
                <div class="media-body">
                    <h4 class="media-heading"><%# Eval("Name") %></h4>
                </div>
                </div>
                <div style="margin-top:10px;">
                <div style="width:730px;height:490px;float:left;margin-right:10px;">
                    <asp:Image ID="Image1" Width="730" Height="490" ImageUrl='<%# "images/img/"+Eval("Imageurl")+".jpg" %>' runat="server" />
                </div>
                <div style="margin-left:10px;">
                    <table>
                        <tr>
                            <td colspan="2">
                                <h3><%# Eval("Commodityname") %></h3>
                            </td>
                        </tr>
                        <tr>
                            <td>
                                <h3>转卖价：￥</h3>
                            </td>
                            <td>
                                <h3 style="color:red;"><%# Eval("transferprice") %></h3>
                            </td>
                        </tr>

                    </table>
                </div>
                </div>
                </ItemTemplate>
            </asp:Repeater>
            
        </div>
</asp:Content>
