<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Weblitz.Mvc.Forum.Web.ViewModels.DeleteItem>" %>

<p>Are you sure you want to delete <em><%: Model.Description %></em>?</p>
<ul class="options">
    <li><%= Html.ActionLink("Yes", Model.YesAction, new {Model.Id}) %></li>
    <li><%= Html.ActionLink("No", Model.NoAction, new {Model.Id}) %></li>
</ul>
