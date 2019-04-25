using System;
using System.Collections.Generic;

namespace Examensarbete.Models
{
    public partial class Facts
    {
        public int Id { get; set; }
        public int HeaderContentId { get; set; }
        public int BodyContentId { get; set; }
        public int Level { get; set; }
        public int SortOrder { get; set; }
        public int TopicId { get; set; }

        public Content BodyContent { get; set; }
        public Content HeaderContent { get; set; }
        public Topic Topic { get; set; }
    }
}
