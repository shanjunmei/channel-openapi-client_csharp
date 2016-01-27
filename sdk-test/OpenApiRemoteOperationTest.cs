using com.hzins.channel.api.model.common;
using com.hzins.channel.api.model.req;
using com.hzins.channel.api.model.resp;
using Newtonsoft.Json;
using com.hzins.rpc.client.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.hzins.rpc.client.test
{
    class OpenApiRemoteOperationTest
    {
        static OpenApiRemoteOperation operation = ProxyFactory.create<OpenApiRemoteOperation>();

        public static void  testProductList()
        {
            
            ProductListReq req = new ProductListReq();
            req.partnerId = Configure.Channel.partnerId;
            req.transNo = "testc#sdk";
            
            string sign = Md5.encrypt(Configure.Channel.channelKey + Configure.Channel.partnerId.ToString() + req.transNo);

            req.sign = sign;

            string xx = JsonConvert.SerializeObject(req);
            System.Console.WriteLine(xx);

            CommonResult<ProductListResp> ret = operation.productList(req);

            System.Console.WriteLine(JsonConvert.SerializeObject(ret));
            System.Console.ReadKey();
        }
    }
}
