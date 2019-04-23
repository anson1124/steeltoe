﻿
using System;

namespace Steeltoe.Management.Census.Trace.Config
{
    [Obsolete("Use OpenCensus project packages")]
    public interface ITraceParams
    {
        ISampler Sampler { get; }
        int MaxNumberOfAttributes { get; }
        int MaxNumberOfAnnotations { get; }
        int MaxNumberOfMessageEvents { get; }
        int MaxNumberOfLinks { get; }
        TraceParamsBuilder ToBuilder();
    }
}
