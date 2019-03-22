using System;
using System.Collections.Generic;

namespace Examensarbete.Models
{
    public partial class Topic
    {
        public int Id { get; set; }
        public int SortOrder { get; set; }
        public int ContentId { get; set; }

        public Content Content { get; set; }
    }
}
