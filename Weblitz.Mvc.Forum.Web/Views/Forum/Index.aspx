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
            <tr>
                <td>Interesting forum name</td>
                <td>123</td>
                <td>542</td>
            </tr>
        </tbody>
    </table>
    <ul class="options">
        <li><a>New Forum</a></li>
    </ul>
</asp:Content>
