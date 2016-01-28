using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hzins.rpc.client.utils
{
    public class SdkConfigure
    {


        public static class Request
        {

            public readonly static int http_connection_timeout = 0;// ms为单位
            // 默认为0，系统默认超时时间，根据操作系统而定

            public readonly static int http_read_timeout = 0;// ms为单位
            // 默认为0，系统默认超时时间，根据操作系统而定

            public readonly static string userAgent = "Channel OpenApi Sdk(c#)";

            public readonly static string contentType = "application/json;charset=UTF-8";
        }


    }
}
