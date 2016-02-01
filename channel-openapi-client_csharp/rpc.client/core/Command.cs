using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hzins.rpc.client.core
{
    /// <summary>
    /// 服务端方法映射
    /// </summary>
    public class Command : Attribute
    {
        /// <summary>
        /// 服务端方法名
        /// </summary>
        public string command;

        /// <summary>
        /// 服务端方法名
        /// </summary>
        /// <param name="command"></param>
        public Command(string command)
        {
            this.command = command;
        }


    }
}
