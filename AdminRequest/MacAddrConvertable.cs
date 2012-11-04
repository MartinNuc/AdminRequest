using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISEAGE.May610.Diagrammer;
using System.Net.NetworkInformation;

namespace AdminRequest
{
    class MacAddrConvertable : MacAddr
    {
        public PhysicalAddress ConvertToPhysicalAddress()
        {
            byte[] bytes = { FirstByte, SecondByte, ThirdByte, 
                               FourthByte, FifthByte, SixthByte };
            return new PhysicalAddress(bytes);
        }

        public MacAddrConvertable()
        {
        }

        public MacAddrConvertable(PhysicalAddress Mac) : this(Mac.GetAddressBytes())
        {
        }

        public MacAddrConvertable(String Mac)
        {
            this.Address = Mac;
        }

        public MacAddrConvertable(byte [] bytes)
        {
            if (bytes.Length != 6)
                throw new Exception("Provided byte array is not 6 lenght.");

            this.FirstByte = bytes[0];
            this.SecondByte = bytes[1];
            this.ThirdByte = bytes[2];
            this.FourthByte = bytes[3];
            this.FifthByte = bytes[4];
            this.SixthByte = bytes[5];

        }

        public override string ToString()
        {
            return FirstByte.ToString("X2")
                + ":" + SecondByte.ToString("X2")
                + ":" + ThirdByte.ToString("X2")
                + ":" + FourthByte.ToString("X2")
                + ":" + FifthByte.ToString("X2")
                + ":" + SixthByte.ToString("X2");
        }


    }
}
