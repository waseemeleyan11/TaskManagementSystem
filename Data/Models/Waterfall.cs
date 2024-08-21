using System.Collections.Generic;
//19/8 v2

﻿namespace TaskManagementSystem.Data.Models
{
    public class Waterfall : Project
    {
        //Sama Test

        public DateTime ExpectedEndTime { get; set; }
        public ICollection<Task> Tasks { get; set; }
    }
}
