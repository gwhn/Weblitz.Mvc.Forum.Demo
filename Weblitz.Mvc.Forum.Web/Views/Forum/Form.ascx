<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Weblitz.Mvc.Forum.Web.ViewModels.ForumInput>" %>

<%
    Html.EnableClientValidation();%>
<%
    using (Html.BeginForm(Model.Action, "Forum", new {Model.Id}))
    {%>
    <fieldset>
        <%=Html.LabelFor(m => m.Name)%>
        <%=Html.TextBoxFor(m => m.Name)%>
        <%=Html.ValidationMessageFor(m => m.Name)%>
        <ul class="options">
            <li><%=Html.ActionLink("Cancel", "Index")%></li>
            <li><input type="submit" value="Save" /></li>
        </ul>
    </fieldset>
<%
    }%>
