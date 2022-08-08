using Metatrider5.Application.Model;
using Metatrider5.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using mtapi.mt5;
using Newtonsoft.Json.Linq;

namespace Metatrider5.WebAPI.Controllers
{
    public class MT5Controller : ControllerBase
    {
        public IMT5Service _mt5Service;

        public MT5Controller(IMT5Service mt5Service)
        {
            _mt5Service = mt5Service;
        }

        [HttpGet("GetAPIKey")]
        public ActionResult<Result<string>> GetAPIKey(ulong username, string password)
        {
            Result<string> result = _mt5Service.GetApiKey(username, password);
            return result;
        }
        [HttpGet("GetOrders")]
        public ActionResult<Result<List<OrderModel>>> GetOrders(string apiKey)
        {

            Result<List<OrderModel>> result = _mt5Service.GetOpenedOrders(apiKey);
         
            return result;
        }

    }
}
