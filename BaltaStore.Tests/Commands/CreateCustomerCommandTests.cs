using BaltaStore.Domain.StoreContext.Commands.CustomerCommands.Inputs;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BaltaStore.Tests.Commands
{
    [TestClass]
    public class CreateCustomerCommandTests
    {

        public CreateCustomerCommandTests()
        {
        }

        [TestMethod]
        public void ShouldValidateWhenCommandIsValid()
        {
            var command = new CreateCustomerCommand();
            command.FirstName = "Wellington";
            command.LastName = "Massola";
            command.Document = "12345678911";
            command.Email = "wellingtonmassola@gmail.com";
            command.Phone = "1199999999";

            Assert.AreEqual(true, command.Valid());
        }
    }
}