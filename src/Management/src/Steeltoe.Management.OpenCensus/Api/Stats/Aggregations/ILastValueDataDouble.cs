﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Steeltoe.Management.Census.Stats.Aggregations
{
    [Obsolete("Use OpenCensus project packages")]
    public interface ILastValueDataDouble : IAggregationData
    {
        double LastValue { get; }
    }
}
