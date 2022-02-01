using Balta.SharedContext;

using System;

namespace Balta.SubscriptionContext;

public class Subscription : Entity
{
    public Plan Plan { get; set; }

    public DateTime? EndDate { get; set; }

    public bool IsInactive => EndDate <= DateTime.Now;
}
