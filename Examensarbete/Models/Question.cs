using System;
using System.Collections.Generic;

namespace Examensarbete.Models
{
    public partial class Question
    {
        public int Id { get; set; }
        public int HeaderContentId { get; set; }
        public int BodyContentId { get; set; }
        public int AnswerContentId { get; set; }

        public Content AnswerContent { get; set; }
        public Content BodyContent { get; set; }
        public Content HeaderContent { get; set; }
    }
}
