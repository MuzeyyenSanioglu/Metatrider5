using Metatrider5.Application.Helper;
using Metatrider5.Application.Model;
using Metatrider5.Application.Services.Interfaces;
using Metatrider5.Application.Settings.Interfaces;
using mtapi.mt5;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metatrider5.Application.Services
{
    public class MT5Service : IMT5Service
    {
        
        public IMT5ConnectionSettings _mt5CollectionSettings;

        public MT5Service(IMT5ConnectionSettings mt5CollectionSettings)
        {

            _mt5CollectionSettings = mt5CollectionSettings;
        }

        public Result<MT5API> Connect(ulong usercode ,string password)
        {
            Result<MT5API> result = new Result<MT5API>();

            try
            {
                MT5API api = new MT5API(usercode, password, _mt5CollectionSettings.Host, _mt5CollectionSettings.Port);
                //api.OnConnectProgress += Qc_OnConnectProgress;
                api.Connect();
                result.SetData(api);
            }
            catch (Exception ex)
            {

                result.SetFailure(ex);
            }
            return result;  
        }

        public Result<string> GetApiKey(ulong usercode, string password)
        {
            string url = $"{_mt5CollectionSettings.BaseURL}/Connect?user={usercode}&password={password}&host={_mt5CollectionSettings.Host}&port={_mt5CollectionSettings.Port}";
            Result<string> apıkeyResponse = HttpRequestBuilder.GetInstance(url).Get().SendAsync<string>().Result;
            return apıkeyResponse;
        }

        public Result<OrderModel> CreateOrder(string apiKey ,string symbol , string operation,int volume,double? price,
           int? slippage, double? stoploss , double? takeProfit  ,string? comment )
        {
            Result<OrderModel> result = new Result<OrderModel>();
            //http://mt5.mtapi.be/OrderSend?id=029ae670-35d2-4365-9e34-d1c1e10ecd84&symbol=USDJPY&operation=Sell&volume=1&slippage=1&stoploss=0&takeprofit=0
            try
            {
                string url = $"{_mt5CollectionSettings.BaseURL}/OrderSend?id={apiKey}&symbol={symbol}&operation={operation}&volume={volume}";
                if (price != null)
                    url += $"&price={price}";
                if (slippage != null)
                    url += $"&slippage={slippage}";
                if (stoploss != null)
                    url += $"&stoploss={stoploss}";
                if (takeProfit != null)
                    url += $"&takeprofit={takeProfit}";
                if (comment != null)
                    url += $"&comment={comment}";
                Result<OrderModel> order = HttpRequestBuilder.GetInstance(url).Get().SendAsync<OrderModel>().Result;
                return order;
            }
            catch (Exception ex )
            {
                result.SetFailure(ex);
            }
            return result;
        }


        public Result<List<OrderModel>> GetOpenedOrders(string apiKey)
        {
             Result<List<OrderModel>> result = new Result<List<OrderModel>>();
            try
            {
                ///OpenedOrders?id=029ae670-35d2-4365-9e34-d1c1e10ecd84
                string url  = $"{_mt5CollectionSettings.BaseURL}/OpenedOrders?id={apiKey}";
                Result<List<OrderModel>> orders = HttpRequestBuilder.GetInstance(url).Get().SendAsync<List<OrderModel>>().Result;

                result.SetData(orders.Data);
            }
            catch (Exception ex)
            {

                result.SetFailure(ex);
            }
            return result;
        }

        public Result<DemoAccountModel> GetDemoAccount()
        {
            Result<DemoAccountModel> result = new Result<DemoAccountModel>();
            try
            {
                string url = $"{_mt5CollectionSettings.BaseURL}/GetDemo?host={_mt5CollectionSettings.Host}&port={_mt5CollectionSettings.Port}";
                Result<DemoAccountModel> account = HttpRequestBuilder.GetInstance(url).Get().SendAsync<DemoAccountModel>().Result;
                return account;
            }
            catch (Exception ex)
            {
                result.SetFailure(ex);
            }
            return result;
        }
    }
}
