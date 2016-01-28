

namespace com.hzins.channel.api.model.resp
{
	/// <summary>
	/// <p>
	/// 支付接口返回参数
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-4-27 上午11:26:31</date>
	/// <version></version>
	public class AppPrePayResp
	{
        //投保单号
		public string transNo;

        //调用支付的参数串
		public string orderNum;

		public string gatewayData;

	}
}
