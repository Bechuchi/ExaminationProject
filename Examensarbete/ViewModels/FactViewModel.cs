﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examensarbete.ViewModels
{
    public class FactViewModel
    {
        public int Id { get; set; }
        public string Header { get; set; }
        public string Text { get; set; }
        public int SortOrder { get; set; }
        public int TopicId { get; set; }
    }
}
