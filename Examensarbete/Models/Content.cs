using System;
using System.Collections.Generic;

namespace Examensarbete.Models
{
    public partial class Content
    {
        public Content()
        {
            FactsBodyContent = new HashSet<Facts>();
            FactsHeaderContent = new HashSet<Facts>();
            LanguageContent = new HashSet<LanguageContent>();
            QuestionAnswerContent = new HashSet<Question>();
            QuestionBodyContent = new HashSet<Question>();
            QuestionHeaderContent = new HashSet<Question>();
            Test = new HashSet<Test>();
            Topic = new HashSet<Topic>();
        }

        public int Id { get; set; }

        public ICollection<Facts> FactsBodyContent { get; set; }
        public ICollection<Facts> FactsHeaderContent { get; set; }
        public ICollection<LanguageContent> LanguageContent { get; set; }
        public ICollection<Question> QuestionAnswerContent { get; set; }
        public ICollection<Question> QuestionBodyContent { get; set; }
        public ICollection<Question> QuestionHeaderContent { get; set; }
        public ICollection<Test> Test { get; set; }
        public ICollection<Topic> Topic { get; set; }
    }
}
