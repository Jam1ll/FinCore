using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;


namespace FinCore.Core.Application.DTOs.User
{
    public class ChangeUserStatusDto
    {
        [JsonProperty("status")]
        [Required]
        public bool Status { get; set; }
    }

}
