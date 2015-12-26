<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="urun.aspx.cs" Inherits="WebApplication3.urun" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="Repeater1" runat="server">
        <ItemTemplate> <!-- okunan bilgilerden hangileri nerde gösterilecek  -->

            <div class="col-lg-3">
         <br />
        <img src="<%#DataBinder.Eval(Container.DataItem, "urun_img")%>" width="350" height="350" alt="..." class="img-thumbnail">
        <h3> <%#DataBinder.Eval(Container.DataItem,"urunad") %></h3>
        <p> <%#DataBinder.Eval(Container.DataItem, "urun_aciklama")%></p>
         <a href="#" class="btn btn-default">Sepete Ekle</a>
    </div


           <%--     <tr>
                    <td>
                    <%#DataBinder.Eval(Container.DataItem,"urunad") %>
                        
                    </td>
                    <td>
                        <%#DataBinder.Eval(Container.DataItem, "urun_aciklama")%>
                    </td>
                    <td>
                        <%#DataBinder.Eval(Container.DataItem, "fiyat")%>
                    </td>
                    <td>
                        <%#DataBinder.Eval(Container.DataItem, "urun_img")%>
                    </td>--%>
            </ItemTemplate>

    </asp:Repeater>
<%--     <div class="col-lg-3">
         <br />
        <img src="<%#DataBinder.Eval(Container.DataItem, "urun_img")%>" alt="..." class="img-thumbnail">
        <h3> <%#DataBinder.Eval(Container.DataItem,"urunad") %></h3>
        <p> <%#DataBinder.Eval(Container.DataItem, "urun_aciklama")%></p>
         <a href="#" class="btn btn-default">Sepete Ekle</a>
    </div>--%>

</asp:Content>
