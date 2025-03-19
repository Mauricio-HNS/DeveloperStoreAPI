﻿namespace DeveloperStore.API.Models
{
    public class Branch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }
        public int BranchId { get; internal set; }
    }
}
