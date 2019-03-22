using Examensarbete.Data.Identity;
using Examensarbete.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examensarbete.DataLayer
{
    public class DataService : IDataService
    {
        private readonly ExamensarbeteContext _context;

        public DataService(ExamensarbeteContext context)
        {
            _context = context;
        }
        //private readonly ApplicationDbContext _context;

        //public DataService(ApplicationDbContext context)
        //{
        //    _context = context;
        //}
    }
}
