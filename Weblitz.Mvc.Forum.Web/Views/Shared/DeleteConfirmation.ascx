<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Weblitz.Mvc.Forum.Web.ViewModels.DeleteItem>" %>

<h2>Delete <%:ViewData["CancelController"]%></h2>
<%
    using (Html.BeginForm())
    {%>
    <fieldset>
        <p>Are you sure you want to delete <em><%:Model.Description%></em>?</p>
        <ul class="options">
            <li><%=Html.ActionLink("Cancel", ViewData["CancelAction"].ToString(),
                                          ViewData["CancelController"].ToString(),
                                          new {Id = ViewData["CancelId"].ToString()}, null)%></li>
            <li><input type="submit" value="Delete" /></li>
        </ul>
    </fieldset>  
<%
    }%>
