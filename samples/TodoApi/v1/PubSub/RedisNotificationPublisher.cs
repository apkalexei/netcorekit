using System.Threading;
using MediatR;
using Microsoft.Extensions.Logging;
using NetCoreKit.Infrastructure.Bus;
using NetCoreKit.Infrastructure.Mappers;
using NetCoreKit.Samples.TodoAPI.Domain;
using Project.Proto;
using Task = System.Threading.Tasks.Task;

namespace NetCoreKit.Samples.TodoApi.v1.PubSub
{
    public class RedisNotificationPublisher : INotificationHandler<NotificationEnvelope>
    {
        private readonly IDispatchedEventBus _dispatchedEventBus;
        private readonly ILogger<RedisNotificationPublisher> _logger;

        public RedisNotificationPublisher(IDispatchedEventBus dispatchedEventBus, ILoggerFactory loggerFactory)
        {
            _dispatchedEventBus = dispatchedEventBus;
            _logger = loggerFactory.CreateLogger<RedisNotificationPublisher>();
        }

        public async Task Handle(NotificationEnvelope notify, CancellationToken cancellationToken)
        {
            switch (notify.Event)
            {
                case ProjectCreated projectCreated:
                    _logger.LogInformation("[NCK] Start to publish ProjectCreatedMsg.");
                    await _dispatchedEventBus.PublishAsync(
                        projectCreated.MapTo<ProjectCreated, ProjectCreatedMsg>(),
                        "project-created");
                    break;
                case TaskCreated taskCreated:
                    _logger.LogInformation("[NCK] Start to publish TaskCreatedMsg.");
                    await _dispatchedEventBus.PublishAsync(
                        taskCreated.MapTo<TaskCreated, TaskCreatedMsg>(),
                        "task-created");
                    break;
            }
        }
    }
}
