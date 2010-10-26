<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Weblitz.Mvc.Forum.Web.Models.TopicInput>" %>
<h3><%:ViewData["Forum"]%></h3>

<%
    Html.EnableClientValidation();%>
<%
    using (Html.BeginForm())
    {%>
    <fieldset>
        <div class="editor-label">
            <%=Html.LabelFor(m => m.ForumId)%>
        </div>
        <div class="editor-field">
            <%=Html.DropDownListFor(m => m.ForumId, Model.Forums)%>
            <%=Html.ValidationMessageFor(m => m.ForumId)%>
        </div>
        <%=Html.EditorForModel()%>
        <ul class="options">
            <li><%=Html.ActionLink("Cancel", "Details", "Forum", new {Model.ForumId})%></li>
            <li><input type="submit" value="Save" /></li>
        </ul>
    </fieldset>  
<%
    }%>
