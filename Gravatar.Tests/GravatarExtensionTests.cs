using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gravatar.Tests
{
    [TestClass]
    public class GravatarExtensionTests
    {
        [TestCategory("Gravatar Tests")]
        [TestMethod("Should Validate Gravatar extension")]
        [DataRow(null,false)]
        [DataRow("",false)]
        [DataRow(" ",false)]
        [DataRow("a@a",false)]
        [DataRow("alexandro.silva@outlook.com", true)]
        public void ShouldValidateGravatar(string email,bool status)
        {
            var result = "https://www.gravatar.com/avatar/fe21aac3b8355a9142f0b3d09d3a17b0";

            Assert.AreEqual((email.ToGravatar()==result),status);
        }
    }
}
