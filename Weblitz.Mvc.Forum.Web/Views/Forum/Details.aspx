<%@ Page Title="" Language="C#" MasterPageFile="~/Views/Shared/Site.Master" Inherits="System.Web.Mvc.ViewPage<Weblitz.Mvc.Forum.Web.Models.ForumDetail>" %>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent"></asp:Content>
<asp:Content runat="server" ID="Main" ContentPlaceHolderID="MainContent">
    <h2><%:Model.Name%></h2>
    <table>
        <thead>
            <tr>
                <th>Title</th>
                <th>Post Count</th>
                <th>Sticky</th>
            </tr>
        </thead>
        <tbody>
        <%
            foreach (var topic in Model.Topics)
            {%>
            <tr>
                <td><%=Html.ActionLink(topic.Title, "Details", "Topic", new {topic.Id}, null)%></td>
                <td><%:topic.PostCount%></td>
                <td>
                <%
                    if (topic.IsSticky)
                    {%>
                    <img src="/Content/Images/Sticky.jpg" alt="Sticky Topic" width="32" height="30" />
                <%
                    }%>
                </td>
            </tr>  
        <%
            }%>
        </tbody>
    </table>
    <ul class="options">
        <li><%=Html.ActionLink("Edit", "Edit", new { Model.Id }, null)%></li>
        <li><%=Html.ActionLink("Delete", "Delete", new { Model.Id }, null)%></li>
        <li><%=Html.ActionLink("New Topic", "Create", "Topic", new {ForumId = Model.Id}, null)%></li>
    </ul>
</asp:Content>
