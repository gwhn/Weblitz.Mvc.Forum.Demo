<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Weblitz.Mvc.Forum.Web.ViewModels.TopicInput>" %>

<% using(Html.BeginForm(Model.Action, "Topic", new {Model.Id})) { %>
<fieldset>
    <%= Html.LabelFor(m => m.Title) %>
    <%= Html.TextBoxFor(m => m.Title) %>
    <%= Html.LabelFor(m => m.IsSticky) %>
    <%= Html.CheckBoxFor(m => m.IsSticky) %>
    <%= Html.LabelFor(m => m.Body) %>
    <%= Html.TextAreaFor(m => m.Body) %>
    <ul class="options">
        <li><%= Html.ActionLink("Cancel", "Details", "Forum", new {Model.ForumId}) %></li>
        <li><input type="submit" value="Save" /></li>
    </ul>
</fieldset>  
<% } %>
