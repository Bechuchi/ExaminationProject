using System;
using System.Collections.Generic;

namespace Examensarbete.Models
{
    public partial class Exam
    {
        public Exam()
        {
            Question = new HashSet<Question>();
        }

        public int Id { get; set; }
        public int HeaderContentId { get; set; }
        public int TopicId { get; set; }

        public Content HeaderContent { get; set; }
        public Topic Topic { get; set; }
        public ICollection<Question> Question { get; set; }
    }
}
