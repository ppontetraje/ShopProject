using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopProject.Models
{
    public interface IOrderRepository
    {
        void CreateOrder(Order order);
    }
}
