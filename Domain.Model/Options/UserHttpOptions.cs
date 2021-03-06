﻿using System;

namespace Domain.Model.Options
{
    public class UserHttpOptions
    {
        public Uri ApiBaseUrl { get; set; }
        public string ProfilePath { get; set; }
        public string PostPath { get; set; }
        public string Name { get; set; }
        public int TimeDaysOut { get; set; }
    }
}
