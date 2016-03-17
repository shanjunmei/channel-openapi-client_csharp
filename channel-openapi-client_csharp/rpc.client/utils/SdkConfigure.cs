namespace com.hzins.rpc.client.utils
{
    /// <summary>
    /// sdk配置
    /// </summary>
    public class SdkConfigure
    {

        /// <summary>
        /// 请求相关配置
        /// </summary>
        public static class Request
        {
            /// <summary>
            /// 请求连接超时时间
            /// </summary>
            public static int http_connection_timeout = 0;// ms为单位
            // 默认为0，系统默认超时时间，根据操作系统而定

            /// <summary>
            /// 请求读取超时时间
            /// </summary>
            public static int http_read_timeout = 0;// ms为单位
            // 默认为0，系统默认超时时间，根据操作系统而定


            /// <summary>
            /// user-agent
            /// </summary>
            public static string userAgent = "Channel OpenApi Sdk(c#)v1.1";
            /// <summary>
            /// contentType
            /// </summary>
            public static string contentType = "application/json;charset=UTF-8";

        }
        /// <summary>
        /// 渠道配置
        /// </summary>
        public static class Channel
        {

            /// <summary>
            /// 请求url base
            /// </summary>
            public static string baseUrl = "http://channel.hzins.com/api/";
            //public const   string baseUrl = "http://channel.hzins.com/api/";
            /// <summary>
            /// 渠道id
            /// </summary>
            public static int? partnerId=null; //241649
            /// <summary>
            /// 渠道密钥
            /// </summary>
            public static string channelKey = null;//241649#%##^15
        }

    }
}
