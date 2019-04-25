using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Examensarbete.Models
{
    public partial class Content
    {
        public Content()
        {
            Exam = new HashSet<Exam>();
            FactsBodyContent = new HashSet<Facts>();
            FactsHeaderContent = new HashSet<Facts>();
            LanguageContent = new HashSet<LanguageContent>();
            Question = new HashSet<Question>();
            Topic = new HashSet<Topic>();
        }

        public int Id { get; set; }

        public ICollection<Exam> Exam { get; set; }

        [NotMapped] //Kommer aldrig i kod gå från content till vilken fact den tillhär
        public ICollection<Facts> FactsBodyContent { get; set; }

        [NotMapped]
        public ICollection<Facts> FactsHeaderContent { get; set; }
        public ICollection<LanguageContent> LanguageContent { get; set; }
        public ICollection<Question> Question { get; set; }
        public ICollection<Topic> Topic { get; set; }
    }
}
