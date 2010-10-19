<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<Weblitz.Mvc.Forum.Web.ViewModels.TopicSummary>" MasterPageFile="~/Views/Shared/Site.Master" %>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent"></asp:Content>
<asp:Content runat="server" ID="Main" ContentPlaceHolderID="MainContent">
    <h2>Interesting forum</h2>
    <table>
        <thead>
            <tr>
                <th>Title</th>
                <th>Posts</th>
                <th>Sticky</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td><a>This is the topic title link</a></td>
                <td>413</td>
                <td><img title="sticky icon" /></td>
            </tr>
        </tbody>
    </table>
    <ul class="options">
        <li><a>Edit</a></li>
        <li><a>Delete</a></li>
        <li><a>New Topic</a></li>
    </ul>
</asp:Content>
