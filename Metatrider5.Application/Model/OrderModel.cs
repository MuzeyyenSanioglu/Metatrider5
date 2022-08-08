using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metatrider5.Application.Model
{
    public class OrderModel
    {
        public int ticket { get; set; }
        public double profit { get; set; }
        public double swap { get; set; }
        public double commission { get; set; }
        public double closePrice { get; set; }
        public DateTime closeTime { get; set; }
        public double closeVolume { get; set; }
        public double openPrice { get; set; }
        public DateTime openTime { get; set; }
        public double lots { get; set; }
        public double contractSize { get; set; }
        public int expertId { get; set; }
        public string placedType { get; set; }
        public string orderType { get; set; }
        public string dealType { get; set; }
        public string symbol { get; set; }
        public string comment { get; set; }
        public string state { get; set; }
        public double stopLoss { get; set; }
        public double takeProfit { get; set; }
        public int requestId { get; set; }
        public int digits { get; set; }
        public double profitRate { get; set; }
        public double stopLimitPrice { get; set; }
        public object dealInternalIn { get; set; }
        public object dealInternalOut { get; set; }
        public OrderInternal orderInternal { get; set; }
        public string expirationType { get; set; }
        public DateTime expirationTime { get; set; }
        public string fillPolicy { get; set; }
    }
    public class OrderInternal
    {
        public int ticketNumber { get; set; }
        public string id { get; set; }
        public int login { get; set; }
        public int s50 { get; set; }
        public string symbol { get; set; }
        public long historyTime { get; set; }
        public int openTime { get; set; }
        public int expirationTime { get; set; }
        public int executionTime { get; set; }
        public string type { get; set; }
        public string fillPolicy { get; set; }
        public string expirationType { get; set; }
        public string sC4 { get; set; }
        public string placedType { get; set; }
        public int sD0 { get; set; }
        public double openPrice { get; set; }
        public double stopLimitPrice { get; set; }
        public double price { get; set; }
        public double stopLoss { get; set; }
        public double takeProfit { get; set; }
        public int volume { get; set; }
        public int requestVolume { get; set; }
        public string state { get; set; }
        public int expertId { get; set; }
        public double dealTicket { get; set; }
        public string comment { get; set; }
        public double contractSize { get; set; }
        public int digits { get; set; }
        public int baseDigits { get; set; }
        public double s170 { get; set; }
        public double s178 { get; set; }
        public double s180 { get; set; }
        public double profitRate { get; set; }
        public long openTimeMs { get; set; }
        public string s198 { get; set; }
        public int s1C8 { get; set; }
        public string s1CC { get; set; }
        public DateTime executionTimeAsDateTime { get; set; }
        public double lots { get; set; }
        public double requestLots { get; set; }
        public DateTime openTimeMsAsDateTime { get; set; }
    }

}
