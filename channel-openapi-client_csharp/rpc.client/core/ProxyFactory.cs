using Castle.DynamicProxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace com.hzins.rpc.client.core
{
   public  class ProxyFactory
    {
      
        public static T create<T>(string serviceBase) {
            ProxyGenerator g =new ProxyGenerator();
            IInterceptor interceptor = new Proxy(serviceBase);
            T o=(T) g.CreateInterfaceProxyWithoutTarget(typeof(T),interceptor);
            return o;
        }
       
    }
}
