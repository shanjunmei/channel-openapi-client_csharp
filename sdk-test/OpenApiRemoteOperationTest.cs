using com.hzins.channel.api.model.common;
using com.hzins.channel.api.model.req;
using com.hzins.channel.api.model.resp;
using Newtonsoft.Json;
using com.hzins.rpc.client.core;
using com.hzins.rpc.client.utils;
using com.hzins.rpc.client.openapi.inter;

namespace com.hzins.rpc.client.test
{
    class OpenApiRemoteOperationTest
    {
        static OpenApiRemoteOperation operation = ProxyFactory.create<OpenApiRemoteOperation>(SdkConfigure.Channel.baseUrl);

        private static void init() {
            SdkConfigure.Channel.partnerId = 22803;
            SdkConfigure.Channel.channelKey = "22803^*#%";
        }

        public static void  testProductList()
        {
            init();

            ProductListReq req = new ProductListReq();
            req.partnerId = (int)SdkConfigure.Channel.partnerId;
            req.transNo = "testc#sdk";
            
            //string sign = Md5.encrypt(SdkConfigure.Channel.channelKey + SdkConfigure.Channel.partnerId.ToString() + req.transNo);

            //req.sign = sign;

            string xx = JsonConvert.SerializeObject(req);
            System.Console.WriteLine(xx);

            CommonResult<ProductListResp> ret = operation.productList(req);

            System.Console.WriteLine(JsonConvert.SerializeObject(ret));
            System.Console.ReadKey();
        }
    }
}
