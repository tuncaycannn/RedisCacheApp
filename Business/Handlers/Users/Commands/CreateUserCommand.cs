using Core.Aspects.Autofac.Caching;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Business.Handlers.Users.Commands
{
    public class CreateUserCommand : IRequest<object>
    {
        public int UserId { get; set; }
        public long CitizenId { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string MobilePhones { get; set; }
        public bool Status { get; set; }
        public DateTime BirthDate { get; set; }
        public int Gender { get; set; }
        public DateTime RecordDate { get; set; }
        public string Address { get; set; }
        public string Notes { get; set; }
        public DateTime UpdateContactDate { get; set; }
        public string Password { get; set; }


        public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, object>
        {

            public CreateUserCommandHandler()
            {
            }

            [CacheRemoveAspect("Get")]
            public async Task<object> Handle(CreateUserCommand request, CancellationToken cancellationToken)
            {
                //user added operation...

                Console.WriteLine("User Added.");

                return new object();
            }
        }
    }
}
