using Examensarbete.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Examensarbete.BusinessLayer
{
    public class BusinessService : IBusinessService
    {
        private readonly IDataService _dataService;

        public BusinessService(IDataService dataService)
        {
            _dataService = dataService;
        }
    }
}
