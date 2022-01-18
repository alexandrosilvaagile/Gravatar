using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gravatar.Tests
{
    [TestClass]
    public class GravatarExtensionTests
    {
        [TestCategory("Gravatar Tests")]
        [TestMethod("Should Validate Gravatar extension")]
        [DataRow(null,200,false)]
        [DataRow("",200,false)]
        [DataRow(" ",200,false)]
        [DataRow("a@a",200,false)]
        [DataRow("alexandro.silva@outlook.com",200, true)]
        [DataRow("alexandro.silva@outlook.com",200, true)]
        public void ShouldValidateGravatar(string email,int? size,bool status)
        {
            var imageSize =  size.HasValue ? size.Value.ToString():"80";
            var result = $"https://www.gravatar.com/avatar/fe21aac3b8355a9142f0b3d09d3a17b0?s={imageSize}";
            var resultEmail = email.ToGravatar(size ?? 80);

            Assert.AreEqual((resultEmail == result),status);
        }
    }
}
