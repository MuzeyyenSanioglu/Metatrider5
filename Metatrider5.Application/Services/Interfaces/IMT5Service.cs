using Metatrider5.Application.Model;
using mtapi.mt5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metatrider5.Application.Services.Interfaces
{
    public interface IMT5Service
    {
        Result<MT5API> Connect(ulong usercode, string password);
        Result<List<Order>> GetOpenedOrders(MT5API api);
        Result CreateOrder(Order order);

    }
}
