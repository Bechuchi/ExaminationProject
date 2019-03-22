using System;
using System.Collections.Generic;

namespace Examensarbete.Models
{
    public partial class Test
    {
        public int Id { get; set; }
        public int HeaderContentId { get; set; }

        public Content HeaderContent { get; set; }
    }
}
