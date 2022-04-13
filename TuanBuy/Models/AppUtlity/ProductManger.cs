using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TuanBuy.Models.Entities;

namespace TuanBuy.Models.AppUtlity
{
    public class ProductManger
    {
        private readonly TuanBuyContext _dbContext;
        public ProductManger(TuanBuyContext context)
        {
            _dbContext = context;
        }
        //商品下架join

    }
}
