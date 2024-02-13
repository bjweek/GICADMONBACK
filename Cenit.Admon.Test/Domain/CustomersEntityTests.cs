using Cenit.Admon.Domain.Entities.Customers;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Cenit.Admon.Test;

[TestFixture]

public class CustomersEntityTests
{
    [Test]
    public void CreateCustomersEntity_AssignsPropertiesCorrectly()
    {
        // Arrange
        var id = Guid.NewGuid();
        var nombre = "Admin";

        // Act
        var customer = new CustomersEntity
        {
            IdCustomer = id,
            Nombre = nombre
        };

        // Assert
        Assert.AreEqual(id, customer.IdCustomer);
        Assert.AreEqual(nombre, customer.Nombre);
    }
}