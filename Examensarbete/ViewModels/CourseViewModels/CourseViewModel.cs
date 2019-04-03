using Examensarbete.ViewModels.TopicViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examensarbete.ViewModels.CourseViewModels
{
    public class CourseViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public List<TopicViewModel> Content { get; set; }

        public int MyProperty { get; set; }
    }
}
