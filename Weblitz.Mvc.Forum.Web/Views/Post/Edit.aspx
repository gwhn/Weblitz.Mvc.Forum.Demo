<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<Weblitz.Mvc.Forum.Web.ViewModels.PostInput>" MasterPageFile="~/Views/Shared/Site.Master" %>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent"></asp:Content>
<asp:Content runat="server" ID="Main" ContentPlaceHolderID="MainContent">
<h2>Edit Post</h2>
<h3><%:ViewData["Topic"]%></h3>
<%
    Html.EnableClientValidation();%>
<%
    using (Html.BeginForm(new {Model.TopicId}))
    {%>
    <fieldset>
        <%=Html.EditorForModel()%>
        <ul class="options">
            <li><%=Html.ActionLink("Cancel", "Details", "Topic", new {Model.TopicId}, null)%></li>
            <li><input type="submit" value="Save" /></li>
        </ul>
    </fieldset>  
<%
    }%>
</asp:Content>
