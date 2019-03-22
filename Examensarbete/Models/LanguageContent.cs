using System;
using System.Collections.Generic;

namespace Examensarbete.Models
{
    public partial class LanguageContent
    {
        public int Id { get; set; }
        public string LanguageCode { get; set; }
        public string Content { get; set; }
        public int ContentId { get; set; }

        public Content ContentNavigation { get; set; }
    }
}
