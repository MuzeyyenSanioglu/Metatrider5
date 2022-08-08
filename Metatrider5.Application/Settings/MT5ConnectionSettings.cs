using Metatrider5.Application.Settings.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metatrider5.Application.Settings
{
    public class MT5ConnectionSettings : IMT5ConnectionSettings
    {
        public string Host { get; set; } = null!;
        public string BaseURL { get; set; } = null!;
        public int Port { get; set; }
    }
}
