using Cenit.Admon.Domain.Entities.Customers;
using Cenit.Admon.Infraestructure.DataBase;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace Cenit.Admon.Test.Infraestructure;

[TestFixture]
public class DatabaseServiceTests
{
    private DatabaseService _databaseService;

    [SetUp]
    public void Setup()
    {
        var options = new DbContextOptionsBuilder<DatabaseService>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

        _databaseService = new DatabaseService(options);
    }

    [Test]
    public async Task SaveAsync_ReturnsTrue_WhenChangesAreMade()
    {
        // Arrange
        var customer = new CustomersEntity { /* Initialize properties */ };
        _databaseService.CampanasEntity.Add(customer);

        // Act
        var result = await _databaseService.SaveAsync();

        // Assert
        Assert.IsTrue(result);
    }

    [Test]
    public void OnModelCreating_AppliesConfiguration()
    {
        // Arrange & Act
        var entityType = _databaseService.Model.FindEntityType(typeof(CustomersEntity));

        // Assert
        Assert.IsNotNull(entityType.FindPrimaryKey());
        // Add more assertions as needed to verify the configuration
    }
}