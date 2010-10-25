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
        public void ShouldListMultipleForumsOnIndexAction()
        {
            // Arrange
            var repository = MockRepository.GenerateStub<IRepository<Db.Forum>>();
            var forums = ForumDbFixtures.ListWithMultipleForums();
            Assert.That(forums.Count > 1);
            repository.Stub(f => f.GetAll()).Return(forums);

            // Act
            var controller = new ForumController(repository);
            var result = controller.Index();

            // Assert
            Assert.AreEqual(string.Empty, result.ViewName);
            Assert.IsNotNull(result.ViewData.Model);
            Assert.IsInstanceOf<ICollection<Db.Forum>>(result.ViewData.Model);
            var viewForums = result.ViewData.Model as ICollection<Db.Forum>;
            Assert.AreEqual(forums, viewForums);
            Assert.AreEqual(forums.Count, viewForums.Count);
            repository.AssertWasCalled(f => f.GetAll());
        }

        [Test]
        public void ShouldListSingleForumsOnIndexAction()
        {
            // Arrange
            var repository = MockRepository.GenerateStub<IRepository<Db.Forum>>();
            var forums = ForumDbFixtures.ListWithOneForum();
            Assert.That(forums.Count == 1);
            repository.Stub(f => f.GetAll()).Return(forums);

            // Act
            var controller = new ForumController(repository);
            var result = controller.Index();

            // Assert
            Assert.AreEqual(string.Empty, result.ViewName);
            Assert.IsNotNull(result.ViewData.Model);
            Assert.IsInstanceOf<ICollection<Db.Forum>>(result.ViewData.Model);
            var viewForums = result.ViewData.Model as ICollection<Db.Forum>;
            Assert.AreEqual(forums, viewForums);
            Assert.AreEqual(forums.Count, viewForums.Count);
            repository.AssertWasCalled(f => f.GetAll());
        }

        [Test]
        public void ShouldListNoForumsOnIndexAction()
        {
            // Arrange
            var repository = MockRepository.GenerateStub<IRepository<Db.Forum>>();
            var forums = ForumDbFixtures.ListWithNoForums();
            Assert.That(forums.Count == 0);
            repository.Stub(f => f.GetAll()).Return(forums);

            // Act
            var controller = new ForumController(repository);
            var result = controller.Index();

            // Assert
            Assert.AreEqual(string.Empty, result.ViewName);
            Assert.IsNotNull(result.ViewData.Model);
            Assert.IsInstanceOf<ICollection<Db.Forum>>(result.ViewData.Model);
            var viewForums = result.ViewData.Model as ICollection<Db.Forum>;
            Assert.AreEqual(forums, viewForums);
            Assert.AreEqual(forums.Count, viewForums.Count);
            repository.AssertWasCalled(f => f.GetAll());
        }

        [Test]
        public void ShouldShowForumWithNoTopicsOnDetailsAction()
        {
            // Arrange
            var repository = MockRepository.GenerateStub<IRepository<Db.Forum>>();
            var id = 1234;
            var forum = ForumDbFixtures.ForumWithNoTopics(id);
            Assert.That(forum.Id == id);
            repository.Stub(f => f.Single(w => w.Id == id)).Return(forum);

            // Act
            var controller = new ForumController(repository);
            var result = controller.Details(id);

            // Assert
            Assert.AreEqual(string.Empty, result.ViewName);
            Assert.IsNotNull(result.ViewData.Model);
            Assert.IsInstanceOf<Db.Forum>(result.ViewData.Model);
            var viewForum = result.ViewData.Model as Db.Forum;
            Assert.AreEqual(forum, viewForum);
            Assert.That(viewForum.Topics.Count == 0);
            repository.AssertWasCalled(f => f.Single(w => w.Id == id));
        }
    }
}