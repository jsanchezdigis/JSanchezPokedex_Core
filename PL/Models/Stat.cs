﻿namespace PL.Models
{
    public class Stat
    {
        public int base_stat { get; set; }
        public int effort { get; set; }
        public Stat2 stat { get; set; }
        public List<object> Stats { get; set; }
    }
}
