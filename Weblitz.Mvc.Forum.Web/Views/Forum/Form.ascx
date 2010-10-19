<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Weblitz.Mvc.Forum.Web.ViewModels.ForumInput>" %>

<form>
    <fieldset>
        <label for="forumname">Name:</label>
        <input type="text" name="Name" id="forumname" />
        <ul class="options">
            <li><a>Cancel</a></li>
            <li><input type="submit" value="Save" /></li>
        </ul>
    </fieldset>
</form>
