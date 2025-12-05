using PlanFlow.Domain.Catalog.Enums;

namespace PlanFlow.Domain.Catalog.ValueObjects;

public record BillingPeriod(
    int Interval,
    BillingPeriodUnit Unit);