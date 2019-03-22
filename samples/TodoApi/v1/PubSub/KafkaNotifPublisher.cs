/*using System.Threading;
using MediatR;
using Microsoft.Extensions.Logging;
using NetCoreKit.Infrastructure.Bus;
using NetCoreKit.Infrastructure.Bus.Kafka;
using NetCoreKit.Infrastructure.Mappers;
using NetCoreKit.Samples.TodoAPI.Domain;
using Project.Proto;
using Task = System.Threading.Tasks.Task;

namespace NetCoreKit.Samples.TodoAPI.v1.Services
{
  public class KafkaNotificationPublisher : INotificationHandler<NotificationEnvelope>
  {
    private readonly IDispatchedEventBus _eventBus;
    private readonly ILogger<KafkaNotificationPublisher> _logger;

    public KafkaNotificationPublisher(IDispatchedEventBus eventBus, ILoggerFactory loggerFactory)
    {
      _eventBus = eventBus;
      _logger = loggerFactory.CreateLogger<KafkaNotificationPublisher>();
    }

    public async Task Handle(NotificationEnvelope notify, CancellationToken cancellationToken)
    {
      if (notify.Event is ProjectCreated created)
      {
        _logger.LogInformation("[NCK] Start to publish ProjectCreatedMsg.");
        await _eventBus.Dispatch(created.MapTo<ProjectCreated, ProjectCreatedMsg>(), "project-created");
      }
      else if(notify.Event is TaskCreated taskCreated)
      {
        _logger.LogInformation("[NCK] Start to publish TaskCreatedMsg.");
        await _eventBus.Dispatch(taskCreated.MapTo<TaskCreated, TaskCreatedMsg>(), "task-created");
      }
    }
  }
} */


