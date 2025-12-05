using BillFlow.Domain.Abstractions;
using PlanFlow.Domain.Catalog.Enums;
using PlanFlow.Domain.Catalog.ValueObjects;

namespace PlanFlow.Domain.Catalog.Entities;

public class SubscriptionPlan : Entity
{
    public SubscriptionPlan(Guid id)
        : base(id)
    {

    }

    public Name Name { get; private set; }
    public Description Description { get; private set; }

    public PlanStatus PlanStatus { get; private set; }
    public BillingPeriod BillingPeriod { get; private set; }
    public TrialPeriod TrialPeriod { get; private set; }
    public PlanCode PlanCode { get; private set; }

    public bool IsPublic { get; private set; }
    public bool IsFeatured { get; private set; }
     
    public DateTime CreatedAt { get; private set; }
    public DateTime? UpdatedAt { get; private set; }
}
