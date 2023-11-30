using Grpc.Core;
using DotNetGrpc;

namespace DotNetGrpc.Services;

public class LoginService : Login.LoginBase
{
    private readonly ILogger<LoginService> _logger;
    public LoginService(ILogger<LoginService> logger)
    {
        _logger = logger;
    }

    public override Task<LoginRes> Login(LoginReq request, ServerCallContext context)
    {
        return Task.FromResult(new LoginRes
        {
            // Message = "Hello " + request.Name
        });
    }
}
