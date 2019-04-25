using Examensarbete.Models;
using Examensarbete.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examensarbete.ViewModels
{
    public class CourseViewModel
    {
        //TODO Ta bort id(?) elr lägga till i db
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<TopicViewModel> Content { get; set; }
    }
}
