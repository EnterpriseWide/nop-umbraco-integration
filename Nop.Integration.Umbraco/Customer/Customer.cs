﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nop.Integration.Umbraco.Models
{
    [JsonObject(Title = "customer")]
    public class Customer
    {
        public Customer()
        {
            roles = new List<int>() { 3 };
        }

        [JsonProperty("role_ids")]
        public List<int> roles { get; set; }

        [JsonProperty("email")]
        [Required]
        public string Email { get; set; }

        [JsonProperty("first_name")]
        [Required]
        public string FirstName { get; set; }

        [JsonProperty("last_name")]
        [Required]
        public string LastName { get; set; }

        [JsonProperty("password")]
        [Required]
        public string Password { get; set; }
    }
}