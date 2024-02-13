using Moq;
using NUnit.Framework;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Cenit.Admon.Api.Controllers;
using Microsoft.AspNetCore.Mvc;
using Cenit.Admon.Application.Customers.Commands;
using Cenit.Admon.Application.DTO;
using Microsoft.AspNetCore.Http;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;


namespace Cenit.Admon.Test;

[TestFixture]
public class CustomerControllerTests
{
    private Mock<IMediator> _mediatorMock;
    private CustomerController _controller;
    
    [SetUp]
    public void Setup()
    {
        _mediatorMock = new Mock<IMediator>();
        _controller = new CustomerController(_mediatorMock.Object);
    }
    [Test]
    public async Task CreateCustomer_ShouldReturnCreatedResult_WhenCalled()
    {
        // Arrange
        var customerDto = new CustomerDto { /* set properties */ };
        _mediatorMock.Setup(m => m.Send(It.IsAny<CreateCustomerCommand>(), It.IsAny<CancellationToken>()))
            .ReturnsAsync(true);

        // Act
        var result = await _controller.CreateCustomer(customerDto);

        // Assert
        var objectResult = result.Result as ObjectResult;
        Assert.IsNotNull(objectResult);
        Assert.AreEqual(StatusCodes.Status201Created, objectResult.StatusCode);
    }
}