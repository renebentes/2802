using Balta.SharedContext;

namespace Balta.SubscriptionContext;

public class User : Entity
{
    public string Username { get; set; }

    public string Password { get; set; }
}
