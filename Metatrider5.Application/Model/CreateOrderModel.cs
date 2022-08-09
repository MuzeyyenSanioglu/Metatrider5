using Metatrider5.Application.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metatrider5.Application.Model
{
    public class CreateOrderModel
    {
        [Required]
        public string apiKey { get; set; }
        [Required]
        public string symbol { get; set; }
        [Required]
        public OrderType operation { get; set; }
        [Required]
        public int volume { get; set; }
        public double? price { get; set; }
        public int? slippage { get; set; }
        public double? stoploss { get; set; }
        public double? takeProfit { get; set; }
        public string? comment { get; set; }
    }
}
