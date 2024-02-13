using Cenit.Admon.Domain.Services.Interfaces;
using Moq;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Cenit.Admon.Test.Domain;

[TestFixture]
public class CustomerServiceTests
{
    private Mock<ICustomerService> _customerServiceMock;

    [SetUp]
    public void Setup()
    {
        _customerServiceMock = new Mock<ICustomerService>();
    }

    [Test]
    public void Save_ReturnsTrue_WhenCalledWithValidId()
    {
        // Arrange
        var id = Guid.NewGuid().ToString();
        _customerServiceMock.Setup(service => service.Save(id)).Returns(true);

        // Act
        var result = _customerServiceMock.Object.Save(id);

        // Assert
        Assert.IsTrue(result);
    }
}