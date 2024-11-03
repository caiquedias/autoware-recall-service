using Autoware.Recall.Api.Application.Services;
using Autoware.Recall.Api.Controllers;
using Autoware.Recall.Domain.AggregatesModel.RecallAggregate.Models;
using Autoware.Recall.Infrastructure;
using Autoware.Recall.Infrastructure.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Autoware.Recall.UnitTest.Service
{
    public class RecallApplicationUnitTest : IClassFixture<DbFixture>
    {
        private ServiceProvider _serviceProvider;
        private IConfiguration _configuration;

        public RecallApplicationUnitTest(DbFixture recall)
        {
            _serviceProvider = recall.ServiceProvider;
            _configuration = recall.Configuration;
        }
        [Fact]
        public void GetAll()
        {
            using (var context = _serviceProvider.GetService<RecallContext>())
            {
                // Arrange
                #region Creation of presentantion's layer dependency injection
                var repository = new ChassiRecallRepository(context!);
                var service = new ChassiRecallApplicationService(repository, _configuration);
                var controller = new RecallController(service);
                #endregion Creation of service layer's dependency injection

                // Act
                var response = controller.GetAll();

                // Assert
                var result = Assert.IsType<OkObjectResult>(response);
                Assert.NotNull(result.Value);
            }
        }

        [Fact]
        public void GetAllByChassiWithValidParam()
        {
            using (var context = _serviceProvider.GetService<RecallContext>())
            {
                // Arrange
                #region Creation of presentantion's layer dependency injection
                var repository = new ChassiRecallRepository(context!);
                var service = new ChassiRecallApplicationService(repository, _configuration);
                var controller = new RecallController(service);
                #endregion Creation of service layer's dependency injection

                // Act
                var response = controller.GetAllByChassi("YV1SZ58D911234567");

                // Assert
                var result = Assert.IsType<OkObjectResult>(response);
                Assert.NotNull(result.Value);
            }
        }

        [Fact]
        public void GetAllByChassiWithoutValidParam()
        {
            using (var context = _serviceProvider.GetService<RecallContext>())
            {
                // Arrange
                #region Creation of presentantion's layer dependency injection
                var repository = new ChassiRecallRepository(context!);
                var service = new ChassiRecallApplicationService(repository, _configuration);
                var controller = new RecallController(service);
                #endregion Creation of service layer's dependency injection

                // Act
                var response = controller.GetAllByChassi("adfbvadfbvaab");

                // Assert
                var result = Assert.IsType<OkObjectResult>(response);
                Assert.NotNull(result.Value);
            }
        }
    }
}