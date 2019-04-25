using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examensarbete.ViewModels
{
    public class TopicViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<FactViewModel> Facts { get; set; }
        public bool IsCompleted { get; set; }
    }
}
