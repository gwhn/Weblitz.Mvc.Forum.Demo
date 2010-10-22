<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<Weblitz.Mvc.Forum.Web.Models.TopicInput>" MasterPageFile="~/Views/Shared/Site.Master" %>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent"></asp:Content>
<asp:Content runat="server" ID="Main" ContentPlaceHolderID="MainContent">
    <h2>Edit <%:Model.Title%></h2>
    <%
        Html.RenderPartial("Form");%>
</asp:Content>
