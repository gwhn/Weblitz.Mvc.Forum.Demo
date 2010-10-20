<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Weblitz.Mvc.Forum.Web.ViewModels.PostInput>" %>

<div class="newpost">
    <%
        Html.EnableClientValidation();%>
    <%
        using (Html.BeginForm("Create", "Post"))
        {%>
    <fieldset>
        <%=Html.HiddenFor(m => m.TopicId) %>
        <%=Html.LabelFor(m => m.Author)%>
        <%=Html.TextBoxFor(m => m.Author)%>
        <%=Html.ValidationMessageFor(m => m.Author)%>
        <%=Html.LabelFor(m => m.Body)%>
        <%=Html.TextAreaFor(m => m.Body)%>
        <%=Html.ValidationMessageFor(m => m.Body)%>
        <ul class="options">
            <li><input type="submit" value="Post" /></li>
        </ul>
    </fieldset>  
    <%
        }%>
</div>
