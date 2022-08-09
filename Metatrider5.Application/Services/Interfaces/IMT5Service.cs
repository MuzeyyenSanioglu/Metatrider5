using Metatrider5.Application.Model;
using mtapi.mt5;
using Newtonsoft.Json.Linq;
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
        Result<string> GetApiKey(ulong usercode, string password);
        Result<List<OrderModel>> GetOpenedOrders(string apiKey);
        Result<OrderModel> CreateOrder(string apiKey, string symbol, string operation, int volume, double? price,
           int? slippage, double? stoploss, double? takeProfit, string? comment);
        Result<DemoAccountModel> GetDemoAccount();

    }
}
