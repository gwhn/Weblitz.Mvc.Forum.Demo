<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<Weblitz.Mvc.Forum.Web.ViewModels.ForumSummary[]>" MasterPageFile="~/Views/Shared/Site.Master" %>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent"></asp:Content>
<asp:Content runat="server" ID="Main" ContentPlaceHolderID="MainContent">
    <table>
        <thead>
            <tr>
                <th>Forum</th>
                <th>Topic Count</th>
                <th>Post Count</th>
            </tr>
        </thead>
        <tbody>
            <% foreach (var summary in Model) { %>
            <tr>
                <td><%= Html.ActionLink(summary.Name, "Index", "Topic", new {summary.Id}) %></td>
                <td><%: summary.TopicCount %></td>
                <td><%: summary.PostCount %></td>
            </tr>  
            <% } %>
        </tbody>
    </table>
    <ul class="options">
        <li><%= Html.ActionLink("New Forum", "Create") %></li>
    </ul>
</asp:Content>
