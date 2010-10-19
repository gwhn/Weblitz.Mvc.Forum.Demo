<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Weblitz.Mvc.Forum.Web.ViewModels.ForumDetail>" %>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent"></asp:Content>
<asp:Content runat="server" ID="Main" ContentPlaceHolderID="MainContent">
    <h2><%: Model.Name %></h2>
    <table>
        <thead>
            <tr>
                <th>Title</th>
                <th>Post Count</th>
                <th>Sticky</th>
            </tr>
        </thead>
        <tbody>
            <% foreach (var topic in Model.Topics) { %>
            <tr>
                <td><%= Html.ActionLink(topic.Title, "Details", "Topic", new {topic.Id}) %><a>This is the topic title link</a></td>
                <td><%: topic.PostCount %></td>
                <td>
                <% if (topic.IsSticky) { %>
                    <img src="/Content/Images/Sticky.jpg" alt="Sticky Topic" width="32" height="30" />
                <% } %>
                </td>
            </tr>  
            <% } %>
        </tbody>
    </table>
    <ul class="options">
        <li><%= Html.ActionLink("Edit", "Edit") %></li>
        <li><%= Html.ActionLink("Delete", "Delete") %></li>
        <li><%= Html.ActionLink("New Topic", "Create", "Topic", new {Model.Id}) %></li>
    </ul>
</asp:Content>
