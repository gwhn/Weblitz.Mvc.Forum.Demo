using AutoMapper;
using NUnit.Framework;
using Weblitz.Mvc.Forum.Web.Bootstrappers;

namespace Weblitz.Mvc.Forum.Web.Tests.Mappings
{
    [TestFixture]
    public class AutoMapperConfigurationTests
    {
        [Test]
        public void ShouldCheckForumProfileConfigurationIsValid()
        {
            // Arrange

            // Act
            AutoMapperConfig.Initialize();

            // Assert
            Mapper.AssertConfigurationIsValid("ForumProfile");
        }
    }
}