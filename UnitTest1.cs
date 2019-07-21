using asobiguaIntegrationTests.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace asobiguaIntegrationTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public async System.Threading.Tasks.Task TestMethod1Async()
        {
            UserService userService = new UserService();

            var user = await userService.LoginAsync("trainer1", "asdf1234");
            
            Assert.AreEqual(user.Id, -1001);
            Assert.AreEqual(user.Name, "Trainer1Name");
            Assert.AreEqual(user.Lastname, "Trainer1Lastname");
            Assert.AreEqual(user.Username, "trainer1");
            Assert.AreEqual(user.Email, "trainer1@mail.com");
            Assert.AreEqual(user.UserType, "Trainer");
        }
    }
}
