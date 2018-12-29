using System.ComponentModel.DataAnnotations;

namespace GsmWebApi.Models
{
    public class VsWebTest : WebTest
    {
        [Required]
        public string ConfigXml { get; set; }
        public bool IsRetryEnabled { get; set; }
    }
}