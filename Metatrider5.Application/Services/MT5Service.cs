using Metatrider5.Application.Model;
using Metatrider5.Application.Services.Interfaces;
using Metatrider5.Application.Settings.Interfaces;
using mtapi.mt5;
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

        public Result CreateOrder(Order order)
        {
            throw new NotImplementedException();
        }


        public Result<List<Order>> GetOpenedOrders(MT5API api)
        {
             Result<List<Order>> result = new Result<List<Order>>();
            try
            {
               
                List<Order> orders =    api.GetOpenedOrders().ToList();
                result.SetData(orders);
            }
            catch (Exception ex)
            {

                result.SetFailure(ex);
            }
            return result;
        }
    }
}
