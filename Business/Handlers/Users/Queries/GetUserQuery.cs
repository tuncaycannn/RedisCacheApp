using Core.Aspects.Autofac.Caching;
using MediatR;

namespace Business.Handlers.Users.Queries
{
    public class GetUserQuery : IRequest<object>
    {
        public int UserId { get; set; }

        public class GetUserQueryHandler : IRequestHandler<GetUserQuery, object>
        {
            public GetUserQueryHandler()
            {
            }

            [CacheAspect(10)]
            public async Task<object> Handle(GetUserQuery request, CancellationToken cancellationToken)
            {
                //user listing operation...

                Console.WriteLine("Users listed!");
                return new object();
            }
        }
    }
}
