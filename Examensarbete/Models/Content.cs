using System;
using System.Collections.Generic;

namespace Examensarbete.Models
{
    public partial class Content
    {
        public Content()
        {
            Exam = new HashSet<Exam>();
            Facts = new HashSet<Facts>();
            LanguageContent = new HashSet<LanguageContent>();
            Question = new HashSet<Question>();
            Topic = new HashSet<Topic>();
        }

        public int Id { get; set; }

        public ICollection<Exam> Exam { get; set; }
        public ICollection<Facts> Facts { get; set; }
        public ICollection<LanguageContent> LanguageContent { get; set; }
        public ICollection<Question> Question { get; set; }
        public ICollection<Topic> Topic { get; set; }
    }
}
