<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<Weblitz.Mvc.Forum.Web.Models.ForumSummary>>" MasterPageFile="~/Views/Shared/Site.Master" %>
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
        <%
            foreach (var forum in Model)
            {%>
            <tr>
                <td><%=Html.ActionLink(forum.Name, "Details", new {forum.Id})%></td>
                <td><%:forum.TopicCount%></td>
                <td><%:forum.PostCount%></td>
            </tr>
        <%
            }%>
        </tbody>
    </table>
    <ul class="options">
        <li><%=Html.ActionLink("New Forum", "Create")%></li>
    </ul>
</asp:Content>
