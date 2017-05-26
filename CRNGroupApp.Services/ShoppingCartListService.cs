using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRNGroupApp.Data;
using CRNGroupApp.Models;

namespace CRNGroupApp.Services
{
    class ShoppingCartListService
    {
        private readonly Guid _userId;
        public ShoppingCartListService(Guid UserId)
        {
            _userId = UserId;
        }

    }
}
