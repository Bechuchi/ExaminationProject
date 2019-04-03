using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examensarbete.ViewModels.TopicViewModels
{
    public class AreaViewModel
    {
        public List<FactViewModel> Facts { get; set; }

        public List<ExerciseViewModel> Exercises { get; set; }

        public List<ExamViewModel> Exams { get; set; }
    }
}
