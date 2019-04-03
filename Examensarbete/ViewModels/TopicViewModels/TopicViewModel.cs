using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examensarbete.ViewModels.TopicViewModels
{
    public class TopicViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public bool IsCompleted { get; set; }

        public List<FactViewModel> Facts { get; set; }

        public IEnumerable<ExerciseViewModel> Exercises { get; set; }

        public List<ExamViewModel> Exams { get; set; }

        public List<AreaViewModel> Areas { get; set; }
    }
}
