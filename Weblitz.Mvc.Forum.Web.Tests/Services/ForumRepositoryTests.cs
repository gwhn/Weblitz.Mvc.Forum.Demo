using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Weblitz.Mvc.Forum.Web.Tests.Services
{
    [TestFixture]
    class ForumRepositoryTests
    {
        [Test]
        public void ShouldGetAllForums()
        {
            // Arrange
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
            

            // Act

            // Assert
            Assert.Fail("Nothing to assert");
        }
    }
}
