using System;
using System.ComponentModel.DataAnnotations;

namespace GsmWebApi.Models
{
    public abstract class WebTest
    {
        [Required]
        public string Id { get; set; }
        public Guid InstrumentationKey { get; set; }
        public Guid SubscriptionId { get; set; }
        public string ApplicationId { get; set; }
        public int TestIntervalInSeconds { get; set; }
        public string Name { get; set; }
    }
}