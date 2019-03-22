using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;
using System;

namespace NETCoreWebJobs
{
    public class TimerTrigger
    {
        public static void ProcessQueueMessage([QueueTrigger("kenely")] string message, ILogger logger)
        {
            Console.WriteLine($"message {message}");

            logger.LogInformation(message);
        }
    }
}
