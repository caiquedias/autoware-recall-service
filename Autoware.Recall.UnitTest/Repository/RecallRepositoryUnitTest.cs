using Autoware.Recall.Api.Application.Services;
using Autoware.Recall.Domain.AggregatesModel.RecallAggregate.Models;
using Autoware.Recall.Infrastructure;
using Autoware.Recall.Infrastructure.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Autoware.Recall.UnitTest.Service
{
    public class RecallRepositoryUnitTest : IClassFixture<DbFixture>
    {
        private ServiceProvider _serviceProvider;
        private IConfiguration _configuration;

        public RecallRepositoryUnitTest(DbFixture recall)
        {
            _serviceProvider = recall.ServiceProvider;
            _configuration = recall.Configuration;
        }

        [Fact]
        public void GetChassiRecall()
        {
            using (var context = _serviceProvider.GetService<RecallContext>())
            {
                // Arrange
                #region Creation of repository's layer dependency injection
                var repository = new ChassiRecallRepository(context!);
                #endregion Creation of service layer's dependency injection

                // Act
                var response = repository.GetChassiRecall().ToList();

                // Assert
                var result = Assert.IsType<List<ChassiRecall>>(response);
                Assert.True(result.Count > 0);
            }
        }

        [Fact]
        public void GetChassiRecallWithValidParam()
        {
            using (var context = _serviceProvider.GetService<RecallContext>())
            {
                // Arrange
                #region Creation of repository's layer dependency injection
                var repository = new ChassiRecallRepository(context!);
                #endregion Creation of service layer's dependency injection

                // Act
                var response = repository.GetChassiRecallByChassi("YV1SZ58D911234567").ToList();

                // Assert
                var result = Assert.IsType<List<ChassiRecall>>(response);
                Assert.True(result.Count > 0);
            }
        }

        [Fact]
        public void GetChassiRecallWithoutValidParam()
        {
            using (var context = _serviceProvider.GetService<RecallContext>())
            {
                // Arrange
                #region Creation of repository's layer dependency injection
                var repository = new ChassiRecallRepository(context!);
                #endregion Creation of service layer's dependency injection

                // Act
                var response = repository.GetChassiRecallByChassi("sdvsdvvvsvevw").ToList();

                // Assert
                var result = Assert.IsType<List<ChassiRecall>>(response);
                Assert.True(result.Count == 0);
            }
        }
    }
}