using System;
using System.Collections.Generic;
using Weblitz.Mvc.Forum.Db;

namespace Weblitz.Mvc.Forum.Web.Tests.Fixtures
{
    internal class PostDbFixtures
    {
        public static string MakeBody(int id)
        {
            return string.Format("Body of Test Post {0}", id);
        }

        public static string MakeAuthor(int id)
        {
            return string.Format("Author of Post {0}", id);
        }

        public static Post MakeBase(int id, Topic topic, Post parent, DateTime date)
        {
            return new Post
                       {
                           Id = id,
                           Topic = topic,
                           TopicId = topic.Id,
                           Parent = parent,
                           ParentId = (parent == null ? default(int?) : parent.Id),
                           Body = MakeBody(id),
                           Author = MakeAuthor(id),
                           PublishedDate = date
                       };
        }

        public static Post PostWithNoChildren(int id, Topic topic, Post parent)
        {
            var data = MakeBase(id, topic, parent, new DateTime(2010, 1, 1));
            data.Children = ListWithNoPosts();
            return data;
        }

        public static Post PostWithOneChild(int id, Topic topic, Post parent)
        {
            var data = MakeBase(id, topic, parent, new DateTime(2010, 2, 2));
            data.Children = ListWithOnePostAndNoSubBranches(topic, parent);
            return data;
        }

        public static Post PostWithMultipleChildrenAsLeaves(int id, Topic topic, Post parent)
        {
            var data = MakeBase(id, topic, parent, new DateTime(2010, 2, 2));
            data.Children = new List<Post>
                                {
                                    PostWithNoChildren(4567, topic, parent),
                                    PostWithNoChildren(5678, topic, parent),
                                    PostWithNoChildren(6789, topic, parent)
                                };
            return data;
        }

        public static ICollection<Post> ListWithNoPosts()
        {
            return new List<Post>();
        }

        public static ICollection<Post> ListWithOnePostAndNoSubBranches(Topic topic, Post parent)
        {
            return new List<Post> {PostWithNoChildren(1234, topic, parent)};
        }

        public static ICollection<Post> ListWithMultiplePostsAndNoSubBranches(Topic topic, Post parent)
        {
            return new List<Post>
                       {
                           PostWithNoChildren(1234, topic, parent),
                           PostWithNoChildren(2345, topic, parent),
                           PostWithNoChildren(3456, topic, parent)
                       };
        }

        public static ICollection<Post> ListWithMultiplePostsAndOneSubBranch(Topic topic, Post parent)
        {
            return new List<Post>
                       {
                           PostWithOneChild(1234, topic, parent),
                           PostWithOneChild(2345, topic, parent),
                           PostWithOneChild(3456, topic, parent),
                       };
        }

        public static ICollection<Post> ListWithMultiplePostsAndMultipleSubBranchesAsLeaves(Topic topic, Post parent)
        {
            return new List<Post>
                       {
                           PostWithMultipleChildrenAsLeaves(1234, topic, parent),
                           PostWithMultipleChildrenAsLeaves(2345, topic, parent),
                           PostWithMultipleChildrenAsLeaves(3456, topic, parent)
                       };
        }
    }
}