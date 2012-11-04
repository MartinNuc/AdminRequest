using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.NetworkInformation;

namespace AdminRequest
{
    class IpListItem
    {
        public string Username { get; set; }
        public PhysicalAddress Mac { get; set; }
        public IPAddress Ip { get; set; }

        public IpListItem(string Username, IPAddress Ip, PhysicalAddress Mac)
        {
            this.Username = Username;
            this.Mac = Mac;
            this.Ip = Ip;
        }

        public override string ToString()
        {
            return Ip.ToString() + " - " + Username + " - " + Mac;
        }
    }
}
