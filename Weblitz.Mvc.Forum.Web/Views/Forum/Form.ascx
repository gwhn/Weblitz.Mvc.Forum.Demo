<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Weblitz.Mvc.Forum.Web.ViewModels.ForumInput>" %>

<%
    Html.EnableClientValidation();%>
<%
    using (Html.BeginForm())
    {%>
    <fieldset>
        <%=Html.EditorForModel()%>
        <ul class="options">
            <li><%=Html.ActionLink("Cancel", "Index")%></li>
            <li><input type="submit" value="Save" /></li>
        </ul>
    </fieldset>
<%
    }%>
