﻿namespace Microsoft.ApplicationInsights.Extensibility.Implementation.Metrics
{
    using System;
    using Microsoft.ApplicationInsights.Channel;    

    internal class DependencyMetricIdDimensionExtractor : IDimensionExtractor
    {
        public int MaxValues { get; set; } = 1;

        public string DefaultValue { get; set; } = MetricTerms.Autocollection.Metric.DependencyCallDuration.Id;

        public string Name { get; set; } = MetricDimensionNames.TelemetryContext.Property(MetricTerms.Autocollection.MetricId.Moniker.Key);

        public string ExtractDimension(ITelemetry item)
        {
            return MetricTerms.Autocollection.Metric.DependencyCallDuration.Id;
        }
    }
}
