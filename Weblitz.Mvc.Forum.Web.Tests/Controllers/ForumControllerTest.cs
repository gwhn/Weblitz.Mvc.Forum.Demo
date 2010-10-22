using System;
using System.Collections.Generic;
using System.Web.Mvc;
using NUnit.Framework;
using Rhino.Mocks;
using Weblitz.Mvc.Forum.Core.Interfaces;
using Weblitz.Mvc.Forum.Web.Controllers;
using Weblitz.Mvc.Forum.Web.Tests.Fixtures;

namespace Weblitz.Mvc.Forum.Web.Tests.Controllers
{
    [TestFixture]
    public class ForumControllerTest
    {
        #region Setup/Teardown

        [SetUp]
        public void SetUp()
        {
            _mock = new MockRepository();
        }

        #endregion

        private MockRepository _mock;

        [Test]
        public void ShouldListForumsOnIndexAction()
        {
            // Arrange
            var repository = MockRepository.GenerateStub<IRepository<Db.Forum>>();
            var forums = ForumDbFixtures.ListWithMultipleForums();
            repository.Stub(f => f.GetAll()).Return(forums);

            // Act
            var controller = new ForumController(repository);
            var result = controller.Index();

            // Assert
            Assert.AreEqual(string.Empty, result.ViewName);
            Assert.AreEqual(forums, result.ViewData.Model);
            repository.AssertWasCalled(f => f.GetAll());

//            using (var work = ObjectFactory.GetInstance<UnitOfWork>())
//            {
//                var service = ObjectFactory.GetInstance<Repository<Db.Forum>>();
//                var forums = service.GetAll();
//                foreach (var forum in forums)
//                {                
//                    Debug.WriteLine("Id={0};Name={1}", forum.Id, forum.Name);
//                }
//                work.Commit();
//            }

//            using (var adapter = new ObjectContextAdapter(new ForumEntities()))
//            using (var work = new UnitOfWork(adapter))
//            {
//                var service = new Repository<Db.Forum>(adapter);
//                var forums = service.GetAll();
//                foreach (var forum in forums)
//                {                
//                    Debug.WriteLine("Id={0};Name={1}", forum.Id, forum.Name);
//                }
//                work.Commit();
//            }
        }

        [Test]
        public void ShouldShowForumOnDetailsAction()
        {
            // Arrange
            var repository = MockRepository.GenerateStub<IRepository<Db.Forum>>();
            var forum = new Db.Forum
                            {
                                Id = 1234,
                                Name = "Selected Forum",
                                Topics = new List<Db.Topic>
                                             {
                                                 new Db.Topic
                                                     {
                                                         Id = 4321,
                                                         Author = "Test User",
                                                         Body = "Body of Topic 1",
                                                         PublishedDate = new DateTime(2010, 1, 1),
                                                         Sticky = false
                                                     },
                                                 new Db.Topic
                                                     {
                                                         Id = 5432,
                                                         Author = "Another Test User",
                                                         Body = "Body of Sticky Topic 2",
                                                         PublishedDate = new DateTime(2010, 2, 1),
                                                         Sticky = true
                                                     }
                                             }
                            };


            // Act

            // Assert
            Assert.Fail("Nothing to assert");
        }
    }
}