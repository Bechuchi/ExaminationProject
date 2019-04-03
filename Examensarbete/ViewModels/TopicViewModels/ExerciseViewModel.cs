using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examensarbete.ViewModels.TopicViewModels
{
    public class ExerciseViewModel
    {
        public int Id { get; set; }
        public int Topic { get; set; }
        public string Heading { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
    }
}
