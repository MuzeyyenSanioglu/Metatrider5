using System.Text.Json.Serialization;

namespace Metatrider5.Application.Model.Enums
{
    public enum OrderType
    {
        Buy , 
        Sell, 
        BuyLimit, 
        SellLimit,
        BuyStop, 
        SellStop
    }
}
