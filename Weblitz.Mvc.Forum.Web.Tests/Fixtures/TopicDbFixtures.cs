using System;
using System.Collections.Generic;
using Weblitz.Mvc.Forum.Db;

namespace Weblitz.Mvc.Forum.Web.Tests.Fixtures
{
    internal static class TopicDbFixtures
    {
        public static string MakeTitle(int id)
        {
            return string.Format("Test Topic {0}", id);
        }

        public static string MakeBody(int id)
        {
            return string.Format("Body of Test Topic {0}", id);
        }

        public static string MakeAuthor(int id)
        {
            return string.Format("Author of Topic {0}", id);
        }

        public static Topic MakeBase(int id, Db.Forum forum, DateTime date, bool sticky)
        {
            return new Topic
                       {
                           Id = id,
                           Forum = forum,
                           ForumId = forum.Id,
                           Title = MakeTitle(id),
                           Body = MakeBody(id),
                           Author = MakeAuthor(id),
                           PublishedDate = date,
                           Sticky = sticky,
                       };
        }

        public static Topic TopicWithNoPosts(int id, Db.Forum forum)
        {
            var data = MakeBase(id, forum, new DateTime(2010, 1, 1), false);
            data.Posts = PostDbFixtures.ListWithNoPosts();
            return data;
        }

        public static Topic TopicWithOnePost(int id, Db.Forum forum)
        {
            var data = MakeBase(id, forum, new DateTime(2010, 2, 2), false);
            data.Posts = PostDbFixtures.ListWithOnePostAndNoSubBranches(data, null);
            return data;
        }

        public static Topic TopicWithMultiplePostsAndNoSubBranches(int id, Db.Forum forum)
        {
            var data = MakeBase(id, forum, new DateTime(2010, 3, 3), true);
            data.Posts = PostDbFixtures.ListWithMultiplePostsAndNoSubBranches(data, null);
            return data;
        }

        public static Topic TopicWithMultiplePostsAndOneSubBranch(int id, Db.Forum forum)
        {
            var data = MakeBase(id, forum, new DateTime(2010, 4, 4), true);
            data.Posts = PostDbFixtures.ListWithMultiplePostsAndOneSubBranch(data, null);
            return data;
        }

        public static Topic TopicWithMultiplePostsAndMultipleSubBranches(int id, Db.Forum forum)
        {
            var data = MakeBase(id, forum, new DateTime(2010, 5, 5), false);
            data.Posts = PostDbFixtures.ListWithMultiplePostsAndMultipleSubBranchesAsLeaves(data, null);
            return data;
        }

        public static ICollection<Topic> ListWithNoTopics()
        {
            return new List<Topic>();
        }

        public static ICollection<Topic> ListWithOneTopic(Db.Forum forum)
        {
            return new List<Topic> {TopicWithNoPosts(1234, forum)};
        }

        public static ICollection<Topic> ListWithMultipleTopics(Db.Forum forum)
        {
            return new List<Topic>
                       {
                           TopicWithNoPosts(1234, forum),
                           TopicWithOnePost(2345, forum),
                           TopicWithMultiplePostsAndNoSubBranches(3456, forum),
                           TopicWithMultiplePostsAndOneSubBranch(4567, forum),
                           TopicWithMultiplePostsAndMultipleSubBranches(5678, forum)
                       };
        }
    }
}