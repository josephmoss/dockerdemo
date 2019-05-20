using DockerDemo.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;

namespace DockerDemoTests
{
    public class UnitTests
    {
        [Fact]
        public void Index_ReturnsAViewResult_WithAHelloWorldMessage()
        {
            // Arrange
            var controller = new HomeController();

            // Act
            var result = controller.Index();

            // Assert
            var viewResult = Assert.IsType<ViewResult>(result);
            var viewBagMessage = Assert.IsAssignableFrom<string>(viewResult.ViewData["Message"]);

            Assert.Equal("Hello world! 5/20/2019", viewBagMessage);
        }
    }
}
