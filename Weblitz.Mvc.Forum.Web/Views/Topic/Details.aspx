<%@ Page Title="" Language="C#" Inherits="System.Web.Mvc.ViewPage<Weblitz.Mvc.Forum.Web.ViewModels.TopicDetail>" MasterPageFile="~/Views/Shared/Site.Master" %>
<asp:Content runat="server" ID="Title" ContentPlaceHolderID="TitleContent"></asp:Content>
<asp:Content runat="server" ID="Main" ContentPlaceHolderID="MainContent">
    <h2>Topic title</h2>
    <div class="body">
        This is the topic body and could be very long...
    </div>
    <div class="meta">
        <div class="forum">Forum containing the topic</div>
        <div class="author">Author's user name</div>
        <div class="date">Date of entry</div>
    </div>
    <ul class="options">
        <li><a>Edit</a></li>
        <li><a>Delete</a></li>
    </ul>
    <h3>Posts</h3>
    <div class="postslist">
        <div class="post">
            <div class="body">
                This is the post body and could be very long...
            </div>
            <div class="meta">
                <div class="author">Author's user name</div>
                <div class="date">Date of entry</div>
            </div>
            <ul class="options">
                <li><a>Edit</a></li>
                <li><a>Delete</a></li>
                <li><a>Flag</a></li>
            </ul>
        </div>
    </div>
    <div class="newpost">
        <form>
            <fieldset>
                <label for="postername">Name:</label>
                <input type="text" name="Name" id="postername" />
                <label for="posteremail">Email:</label>
                <input type="text" name="Email" id="posteremail" />
                <textarea name="Body" id="postbody" rows="5">
                    Enter your comments here...
                </textarea>
                <ul class="options">
                    <li><input type="submit" value="Post" /></li>
                </ul>
            </fieldset>
        </form>        
    </div>
</asp:Content>
