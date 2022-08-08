using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metatrider5.Application.Settings.Interfaces
{
    public interface IMT5ConnectionSettings
    {
        string Host { get; set; }
        string BaseURL { get; set; }
        int Port { get; set; }
    }
}
