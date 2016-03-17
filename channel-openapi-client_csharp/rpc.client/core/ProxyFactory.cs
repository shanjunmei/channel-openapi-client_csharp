using Castle.DynamicProxy;

namespace com.hzins.rpc.client.core
{
    /// <summary>
    /// 动态代理工厂
    /// </summary>
    public  class ProxyFactory
    {
      
       /// <summary>
       /// 动态代理创建
       /// </summary>
       /// <typeparam name="T"></typeparam>
       /// <param name="serviceBase"></param>
       /// <returns></returns>
        public static T create<T>(string serviceBase) {
            ProxyGenerator g =new ProxyGenerator();
            IInterceptor interceptor = new Proxy(serviceBase);
            T o=(T) g.CreateInterfaceProxyWithoutTarget(typeof(T),interceptor);
            return o;
        }
       
    }
}
