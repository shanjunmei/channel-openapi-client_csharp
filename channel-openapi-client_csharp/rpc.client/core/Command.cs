using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hzins.rpc.client.core
{
    public  class Command : Attribute
    {
        public string command;
        public Command(string command)
        {
            this.command = command;
        }


    }
}
