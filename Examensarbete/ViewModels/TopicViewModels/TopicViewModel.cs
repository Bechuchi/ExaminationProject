﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examensarbete.ViewModels.TopicViewModels
{
    public class TopicViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Areas { get; set; }
    }

    public enum TopicArea
    {
        Fact,
        Exercises,
        Exams
    }
}
