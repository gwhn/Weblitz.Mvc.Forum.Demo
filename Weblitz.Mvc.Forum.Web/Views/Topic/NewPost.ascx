<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Weblitz.Mvc.Forum.Web.ViewModels.PostInput>" %>

<% using(Html.BeginForm("Create", "Post", new {Model.TopicId})) { %>
    <fieldset>
        <%= Html.LabelFor(m => m.Author) %>
        <%= Html.TextBoxFor(m => m.Author) %>
        <%= Html.LabelFor(m => m.Body) %>
        <%= Html.TextAreaFor(m => m.Body) %>
        <ul class="options">
            <li><input type="submit" value="Post" /></li>
        </ul>
    </fieldset>  
<% } %>
