<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<Weblitz.Mvc.Forum.Web.Models.DeleteItem>" MasterPageFile="~/Views/Shared/Site.Master" %>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent"></asp:Content>
<asp:Content runat="server" ID="Main" ContentPlaceHolderID="MainContent">
    <% Html.RenderPartial("DeleteConfirmation"); %>
</asp:Content>
