﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Gnomi.Models.Api.Models
{
    public class SignupForm
    {
        [StringLength(30)]
        public string ProfileName { get; set; }

        [StringLength(30)]
        public string FirstName { get; set; }

        [StringLength(40)]
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        [StringLength(24)]
        public string Gender { get; set; }

        [StringLength(16)]
        public string Zipcode { get; set; }
    }
}