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

        public Result CreateOrder(Order order)
        {
            throw new NotImplementedException();
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
    }
}
