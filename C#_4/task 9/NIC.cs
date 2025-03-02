using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_9
{
    internal class NIC
    {
        private static NIC instance = null;
        public string Manufacture { get; }
        public string MACAddress { get; }
        public NICType Type { get; }

        private NIC(string manufacture, string macAddress, NICType type)
        {
            Manufacture = manufacture;
            MACAddress = macAddress;
            Type = type;
        }

        public static NIC GetInstance(string manufacture, string macAddress, NICType type)
        {
            if (instance == null)
            {
                instance = new NIC(manufacture, macAddress, type);
            }
            return instance;
        }
    }
}
