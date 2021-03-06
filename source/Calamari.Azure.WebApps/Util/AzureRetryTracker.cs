﻿using System;
using Calamari.Integration.Retry;

namespace Calamari.Azure.WebApps.Util
{
    public static class AzureRetryTracker
    {
        /// <summary>
        /// For azure operations, try again after 1s then 2s, 4s etc...
        /// </summary>
        private static readonly LimitedExponentialRetryInterval RetryIntervalForAzureOperations = new LimitedExponentialRetryInterval(1000, 30000, 2);

        public static RetryTracker GetDefaultRetryTracker()
        {
            return new RetryTracker(maxRetries: 3,
                timeLimit: TimeSpan.MaxValue,
                retryInterval: RetryIntervalForAzureOperations);
        }
    }
}
