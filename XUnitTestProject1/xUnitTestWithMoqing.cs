using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryCore;
using Xunit;
using Moq;

namespace XUnitTestProject
{
    public class xUnitTestWithMoqing
    {
        [Fact]
        public void MoqValidatePlayerW()
        {
            var mockValidator = new Mock<IPlayerValidator>();
            //mockValidator.Setup(x => x.IsValid("McKayla")).Returns(true);  // we need to set up each method we use for test!!!
            mockValidator.Setup(x => x.IsValid(It.IsAny<string>())).Returns(true);  // we need to set up each method we use for test!!!

            var player = new Player(mockValidator.Object);
            player.Name = "McKayla";
            var validateResult = player.Validate();
            Assert.True(validateResult);
        }

        [Fact]
        public void MoqStrickt()
        {
            var mockValidator = new Mock<IPlayerValidator>(MockBehavior.Strict);

            // explicit setup below required with Strickt model
            mockValidator.Setup(x => x.IsValid(It.IsAny<string>())).Returns(true);  


            var player = new Player(mockValidator.Object);
            player.Name = "McKayla";
            var validateResult = player.Validate();
            Assert.True(validateResult);
        }
    }
}
