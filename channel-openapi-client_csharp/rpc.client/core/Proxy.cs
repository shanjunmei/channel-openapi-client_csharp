using Castle.DynamicProxy;
using com.hzins.rpc.client.utils;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;
using System.Reflection;

namespace com.hzins.rpc.client.core
{
    class Proxy : IInterceptor
    {

        private string serviceBase;

        public Proxy(string serviceBase)
        {
            this.serviceBase = serviceBase;
        }

        public void Intercept(IInvocation invocation)
        {
            MethodInfo method = invocation.Method;

            string command = method.Name;
            Command[] apis = (Command[])method.GetCustomAttributes(typeof(Command), false);

            if (apis != null && apis.Length > 0)
            {
                Command api = apis[0];
                if (!String.IsNullOrEmpty(api.command))
                {
                    command = api.command;
                }

            }


            object[] param = invocation.Arguments;

            string baseInfo = serviceBase;
            int pc = method.GetParameters().Length;
            object actualParam = param;
            if (pc == 1)
            {
                actualParam = param[0];
            }

            string response = remoteInvoke(baseInfo + command, actualParam);


            Type returnType = method.ReturnType;

            invocation.ReturnValue = convert2entity(response, returnType);

        }

        public string remoteInvoke(string api, object obj)
        {
            string param = convert2json(obj);
            api = sign(api, param);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(api);
            request.ContentType = SdkConfigure.Request.contentType;
            request.Method = "POST";
            if (SdkConfigure.Request.http_connection_timeout > 0)
            {
                request.Timeout = SdkConfigure.Request.http_connection_timeout;
            }
            if (SdkConfigure.Request.http_read_timeout > 0)
            {
                request.ReadWriteTimeout = SdkConfigure.Request.http_read_timeout;
            }



            StreamWriter writer = new StreamWriter(request.GetRequestStream(), System.Text.UTF8Encoding.UTF8);


            writer.Write(param);
            writer.Flush();

            WebResponse response = request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream(), System.Text.UTF8Encoding.UTF8);
            return reader.ReadToEnd();

        }
        /// <summary>
        /// 签名
        /// </summary>
        /// <param name="api"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        private static string sign(string api, string param)
        {
            string sign = Md5.encrypt(SdkConfigure.Channel.channelKey + param);
            api = api + "?sign=" + sign;
            return api;
        }

        public string convert2json(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }


        public object convert2entity(string json, Type type)
        {
            return JsonConvert.DeserializeObject(json, type);
        }
    }
}
