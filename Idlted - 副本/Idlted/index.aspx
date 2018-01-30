<%@ Page Title="" Language="C#" MasterPageFile="~/Head.Master" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Idlted.index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div id="carousel-example-generic" class="carousel slide" data-ride="carousel" style="width:100%;height:40%; ">
  <!-- Indicators -->
  <ol class="carousel-indicators">
    <li data-target="#carousel-example-generic" data-slide-to="0" class="active"></li>
    <li data-target="#carousel-example-generic" data-slide-to="1"></li>
    <li data-target="#carousel-example-generic" data-slide-to="2"></li>
  </ol>

  <!-- Wrapper for slides -->
  <div class="carousel-inner" role="listbox">
    <div class="item active">
      <img src="images/shuf1.jpg" alt="..."/>
      <div class="carousel-caption">
      </div>
    </div>
    <div class="item">
      <img src="images/shuf2.jpg" alt="..."/>
      <div class="carousel-caption">
      </div>
    </div>
      <div class="item">
          <img src="images/shuf3.jpg" alt="..."/>
          <div class="carousel-caption">
          </div>
      </div>
  </div>

  <!-- Controls -->
  <a class="left carousel-control" href="#carousel-example-generic" role="button" data-slide="prev">
    <span class="glyphicon glyphicon-chevron-left" aria-hidden="true"></span>
    <span class="sr-only">Previous</span>
  </a>
  <a class="right carousel-control" href="#carousel-example-generic" role="button" data-slide="next">
    <span class="glyphicon glyphicon-chevron-right" aria-hidden="true"></span>
    <span class="sr-only">Next</span>
  </a>
</div>

<div style="width:80%;margin-left:10%;margin-top:20px;">
  <!-- Nav tabs -->
  <ul class="nav nav-tabs" role="tablist">
    <li role="presentation" class="active"><a href="#home" aria-controls="home" role="tab" data-toggle="tab">为您推荐</a></li>
    <li role="presentation"><a href="#profile" aria-controls="profile" role="tab" data-toggle="tab">同城淘</a></li>
    <li role="presentation"><a href="#messages" aria-controls="messages" role="tab" data-toggle="tab">全新废品</a></li>
    <li><a href="Commation.aspx?ID">查看更多</a></li>
  </ul>
  <!-- Tab panes -->
  <div class="tab-content">
    <div role="tabpanel" class="tab-pane active" id="home">
        <div style="margin-top:20px;">
            <div class="media" style="float:left; margin-right:20px; width:240px;">
                <div style="float:left;margin-right:10px;">
                    <a href="#">
                        <img src="images/test/head.jpg" width="84" height="84" alt="..." class="img-thumbnail"/>
                    </a>
                </div>
                <div class="media-body">
                    <h4 class="media-heading">大帅哥</h4>
                    为你推荐你可能喜欢、需要的废品
                </div>
            </div>
            <div style="float:left;margin-right:20px;">
                <asp:HyperLink ID="HyperLink2" NavigateUrl="#" runat="server">
                <asp:Image ID="Image1" ImageUrl="images/img/5__002.jpg" width="171" height="180" ToolTip="123" runat="server" />
                </asp:HyperLink>
                <asp:HyperLink ID="HyperLink1" NavigateUrl="#" runat="server"><h4>h4. Bootstrap heading</h4></asp:HyperLink>
            </div>
        </div>
  </div>
    <div role="tabpanel" class="tab-pane" id="profile">

    </div>
    <div role="tabpanel" class="tab-pane" id="messages">

    </div>
  </div>
    
   <div>
       <hr style="border: 1px solid #e4e0e0;width:100%;"/>
   </div>

</div>

</asp:Content>
