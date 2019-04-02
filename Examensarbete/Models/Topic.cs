using System;
using System.Collections.Generic;

namespace Examensarbete.Models
{
    public partial class Topic
    {
        public Topic()
        {
            Exam = new HashSet<Exam>();
            Facts = new HashSet<Facts>();
        }

        public int Id { get; set; }
        public int SortOrder { get; set; }
        public int NameContentId { get; set; }
        public int ContentId { get; set; }

        public Content NameContent { get; set; }
        public ICollection<Exam> Exam { get; set; }
        public ICollection<Facts> Facts { get; set; }
    }
}
