﻿using Castle.DynamicProxy;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace com.hzins.rpc.client.core
{
    class Proxy : IInterceptor
    {
        public void Intercept(IInvocation invocation)
        {
            MethodInfo method = invocation.Method;
            
            string command = method.Name;
            Command api=method.GetCustomAttribute<Command>();
            if (api != null) {
                if (!String.IsNullOrEmpty(api.command)) {
                    command = api.command;
                }
                
            }

          
            object[] param = invocation.Arguments;

            ServiceInfo serviceInfo = method.GetCustomAttribute<ServiceInfo>();
            if (serviceInfo == null) {
               serviceInfo= method.DeclaringType.GetCustomAttribute<ServiceInfo>();
            }
            string baseInfo = serviceInfo.value;
           int pc= method.GetParameters().Length;
           object actualParam = param;
           if (pc == 1)
           {
               actualParam=param[0];
           }

           string response = remoteInvoke(baseInfo + command, actualParam);

           
            Type returnType=method.ReturnType;
            
            invocation.ReturnValue = convert2entity(response, returnType);

        }

        public string remoteInvoke(string api, object obj) {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(api);
            request.ContentType = Configure.Request.contentType;
            request.Method = "POST";
            if (Configure.Request.http_connection_timeout > 0) { 
                 request.ContinueTimeout = Configure.Request.http_connection_timeout;
            }
            if (Configure.Request.http_read_timeout>0)
            {
                 request.ReadWriteTimeout = Configure.Request.http_read_timeout;
            }
           
           

            StreamWriter writer = new StreamWriter(request.GetRequestStream(),System.Text.UTF8Encoding.UTF8);
            string param=convert2json(obj);
            
            writer.Write(param);
            writer.Flush();

            WebResponse response= request.GetResponse();

            StreamReader reader=new StreamReader(response.GetResponseStream());
            return reader.ReadToEnd();
                     
        }

        public string convert2json(object obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

       
        public object convert2entity(string json,Type type) {
            return JsonConvert.DeserializeObject(json, type);
        }
    }
}
