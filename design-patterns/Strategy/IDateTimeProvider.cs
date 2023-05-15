namespace design_patterns.Strategy
{
    using System;

    internal interface IDateTimeProvider
    {
        DateTime Now { get; }
    }
}