using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hzins.rpc.client.core
{
   public class ServiceInfo : Attribute
    {
        public string value;

        public ServiceInfo(string value) {
            this.value = value;
        }
    }
}
