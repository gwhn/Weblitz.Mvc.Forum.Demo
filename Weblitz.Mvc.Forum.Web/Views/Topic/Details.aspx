<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<Weblitz.Mvc.Forum.Web.ViewModels.TopicDetail>" MasterPageFile="~/Views/Shared/Site.Master" %>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent"></asp:Content>
<asp:Content runat="server" ID="Main" ContentPlaceHolderID="MainContent">
    <div class="topic">
        <h2><%:Model.Title%></h2>
        <div class="body"><%:Model.Body%></div>
        <div class="meta">
            <div class="forum"><%:Model.Forum%></div>
            <div class="author"><%:Model.Author%></div>
            <div class="date"><%:Model.PublishedDate%></div>
        </div>
        <ul class="options">
            <li><%=Html.ActionLink("Edit", "Edit", new {Model.Id})%></li>
            <li><%=Html.ActionLink("Delete", "Delete", new {Model.Id})%></li>
        </ul>
    </div>
    <div class="postslist">
        <h3>Posts</h3>
        <%
            foreach (var post in Model.Posts)
            {%>
        <div class="post">
            <div class="body"><%:Model.Body%></div>
            <div class="meta">
                <div class="author"><%:post.Author%></div>
                <div class="date"><%:post.PublishedDate%></div>
            </div>
            <ul class="options">
                <li><%=Html.ActionLink("Edit", "Edit", "Post", new {post.Id})%></li>
                <li><%=Html.ActionLink("Delete", "Delete", "Post", new {post.Id})%></li>
                <li><%=Html.ActionLink("Flag", "Flag", "Post", new {post.Id})%></li>
            </ul>
        </div>  
        <%
            }%>
    </div>
    <div class="newpost">
        <%
            Html.EnableClientValidation();%>
        <%
            using (Html.BeginForm("Create", "Post"))
            {%>
        <fieldset>
            <%=Html.HiddenFor(m => m.Id) %>
            <%=Html.LabelFor(m => m.NewPost.Author)%>
            <%=Html.TextBoxFor(m => m.NewPost.Author)%>
            <%=Html.ValidationMessageFor(m => m.NewPost.Author)%>
            <%=Html.LabelFor(m => m.NewPost.Body)%>
            <%=Html.TextAreaFor(m => m.NewPost.Body)%>
            <%=Html.ValidationMessageFor(m => m.NewPost.Body)%>
            <ul class="options">
                <li><input type="submit" value="Post" /></li>
            </ul>
        </fieldset>  
        <%
            }%>
    </div>
</asp:Content>
