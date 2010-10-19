<%@ Control Language="C#" Inherits="System.Web.Mvc.ViewUserControl<Weblitz.Mvc.Forum.Web.ViewModels.TopicInput>" %>

<form>
    <fieldset>
        <label for="topictitle">Title:</label>
        <input type="text" name="Title" id="topictitle" />
        <label for="topicsticky">Sticky?</label>
        <input type="checkbox" name="Sticky" id="topicsticky" />
        <textarea name="Body" id="topicbody" rows="5">
            Enter the topic body here...
        </textarea>
        <ul class="options">
            <li><a>Cancel</a></li>
            <li><input type="submit" value="Save" /></li>
        </ul>
    </fieldset>
</form>        
