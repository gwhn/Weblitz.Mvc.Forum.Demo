using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Rhino.Mocks;
using Weblitz.Mvc.Forum.Infrastructure.Services;
using Weblitz.Mvc.Forum.Web.Controllers;

namespace Weblitz.Mvc.Forum.Web.Tests.Controllers
{
    [TestFixture]
    public class ForumControllerTest
    {
        private MockRepository _repository;

        [SetUp]
        public void SetUp()
        {
            _repository = new MockRepository();
        }

        [Test]
        public void ShouldListForumsOnIndexAction()
        {
            var controller = new ForumController();
//            var service = _repository.DynamicMock<IForumRepository>();
//            var forums = new[]
//                             {
//                                 new Core.Forum
//                             };
//            With.Mocks(_repository).
//                ExpectingInSameOrder(() =>
//                                         {
//                                             Expect.Call(service.GetForums).Return(false);
//                                             Expect.Call(() => view.PROPERTY = data);
//                                             Expect.Call(view.DataBind);
//                                             SetupResult.For(view.PROPERTY).Return(data);
//                                         }).
//                Verify(() =>
//                           {
//                               new PRESENTER(view, provider);
//                               loader.Raise(null, new EventArgs());
//                               Assert.Fail("Nothing asserted yet.");
//                           });
        }

    }
}
