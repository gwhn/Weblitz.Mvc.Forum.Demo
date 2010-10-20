<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Weblitz.Mvc.Forum.Web.ViewModels.TopicInput>" %>
<h3><%:Model.ForumName%></h3>
<%
    Html.EnableClientValidation();%>
<%
    using (Html.BeginForm(new {Model.ForumId}))
    {%>
    <fieldset>
        <%=Html.EditorForModel()%>
        <ul class="options">
            <li><%=Html.ActionLink("Cancel", "Details", "Forum", new {Model.ForumId})%></li>
            <li><input type="submit" value="Save" /></li>
        </ul>
    </fieldset>  
<%
    }%>
