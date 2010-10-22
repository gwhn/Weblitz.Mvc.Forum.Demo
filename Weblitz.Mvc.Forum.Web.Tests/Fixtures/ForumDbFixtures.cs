using System.Collections.Generic;

namespace Weblitz.Mvc.Forum.Web.Tests.Fixtures
{
    internal static class ForumDbFixtures
    {
        public static string MakeName(int id)
        {
            return string.Format("Test Forum {0}", id);
        }

        public static Db.Forum MakeBase(int id)
        {
            return new Db.Forum
                       {
                           Id = id,
                           Name = MakeName(id)
                       };
        }

        public static Db.Forum ForumWithNoTopics(int id)
        {
            var data = MakeBase(id);
            data.Topics = TopicDbFixtures.ListWithNoTopics();
            return data;
        }

        public static Db.Forum ForumWithOneTopic(int id)
        {
            var data = MakeBase(id);
            data.Topics = TopicDbFixtures.ListWithOneTopic(data);
            return data;
        }

        public static Db.Forum ForumWithMultipleTopics(int id)
        {
            var data = MakeBase(id);
            data.Topics = TopicDbFixtures.ListWithMultipleTopics(data);
            return data;
        }

        public static ICollection<Db.Forum> ListWithNoForums()
        {
            return new List<Db.Forum>();
        }

        public static ICollection<Db.Forum> ListWithOneForum()
        {
            return new List<Db.Forum> {ForumWithNoTopics(1234)};
        }

        public static ICollection<Db.Forum> ListWithMultipleForums()
        {
            return new List<Db.Forum>
                       {
                           ForumWithNoTopics(1234),
                           ForumWithOneTopic(2345),
                           ForumWithMultipleTopics(3456)
                       };
        }
    }
}