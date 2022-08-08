using Metatrider5.Application.Model;
using Metatrider5.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using mtapi.mt5;

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
        public ActionResult<Result<MT5API>> GetAPIKey(ulong username , string password)
        {
            Result<MT5API> result = _mt5Service.Connect(username,password);
            return result;
        } 
    }
}
