using Examensarbete.Data.Identity;
using Examensarbete.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examensarbete.Services
{
    public class ExamServices : IExamService
    {
        private readonly ApplicationDbContext _context;

        public ExamServices(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
