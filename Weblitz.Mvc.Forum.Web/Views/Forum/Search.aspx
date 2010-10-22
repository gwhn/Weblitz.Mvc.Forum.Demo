<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<Weblitz.Mvc.Forum.Web.Models.SearchResult>" MasterPageFile="~/Views/Shared/Site.Master" %>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent"></asp:Content>
<asp:Content runat="server" ID="Main" ContentPlaceHolderID="MainContent">
    <h2>Search Results</h2>
    <div class="searchresults">
        <div class="searchresult">
            <div class="title"><a>Topic title</a></div>
            <div class="extract">This is an extract from the topic with the <em>search query match</em> emphasised</div>
            <div class="meta">
                <div class="forum">Forum containing the topic</div>
                <div class="author">Author's user name</div>
                <div class="date">Date of entry</div>
            </div>
        </div>
    </div>
</asp:Content>
