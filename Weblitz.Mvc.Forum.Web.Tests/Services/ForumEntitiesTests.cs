using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Diagnostics;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Weblitz.Mvc.Forum.Db;

namespace Weblitz.Mvc.Forum.Web.Tests.Services
{
    [TestFixture]
    class ForumEntitiesTests
    {
        [Test]
        public void ShouldGetAllForumsWithTheirTopicsAndEachTopicsPostsAndTheirChildrenRecursively()
        {
            using (var context = new ForumEntities())
            {
                var forums = context.Forums;
                foreach (var forum in forums)
                {
                    if (!forum.Topics.IsLoaded)
                    {
                        forum.Topics.Load();
                    }
                    foreach (var topic in forum.Topics)
                    {
                        if (!topic.Posts.IsLoaded)
                        {
                            topic.Posts.Load();                            
                        }
                        foreach (var post in topic.Posts)
                        {
                            LoadChildren(post);
                        }
                    }
                }
                foreach (var forum in forums)
                {
                    Debug.WriteLine("Id:{0},Name:{1},Topic Count:{2}", forum.Id, forum.Name, forum.Topics.Count);
                    foreach (var topic in forum.Topics)
                    {
                        Debug.WriteLine("Id:{0},Title:{1},Post Count:{2}", topic.Id, topic.Title, topic.Posts.Count);
                        foreach (var post in topic.Posts)
                        {
                            DebugChildren(post, 0);
                        }
                    }
                }
            }
        }

        private static void DebugChildren(Post post, int indent)
        {
            Debug.WriteLine("{0}Id:{1},Body:{2}", string.Empty.PadRight(indent * 5), post.Id, post.Body);
            foreach (var child in post.Children)
            {
                DebugChildren(child, ++indent);
            }
        }

        private static void LoadChildren(Post post)
        {
            if (!post.Children.IsLoaded)
            {
                post.Children.Load();                
            }
            foreach (var child in post.Children)
            {
                LoadChildren(child);
            }
        }
    }
}
