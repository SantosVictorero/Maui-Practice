using CBSI.Shared.v1.ToDoManagement;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using MediatR;

namespace ToDos.Service.Services
{
	public class ToDoGrpcService : ToDoService.ToDoServiceBase 
	{
		readonly IMediator _Mediator;
		readonly ILogger<ToDoGrpcService> _Logger;
		public ToDoGrpcService(IMediator mediator, ILogger<ToDoGrpcService> logger)
		{
			_Mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
			_Logger = logger ?? throw new ArgumentNullException(nameof(logger));
		}

		public override async Task<Empty> Test(Empty request, ServerCallContext context)
		{
			var result = new Empty();
			return await Task.FromResult(result);
		}
	}
}
