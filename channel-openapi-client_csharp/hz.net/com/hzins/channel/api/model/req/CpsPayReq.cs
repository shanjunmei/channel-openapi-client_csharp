

namespace com.hzins.channel.api.model.req
{
	/// <summary>
	/// <p>
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-4-30 下午2:20:46</date>
	/// <version></version>
	public class CpsPayReq
	{
		public string transNo;

		public string orderNum;

		public int partnerId;

		public string userId;

		public string sign;

		public int platformType;

		public string backUrl;

		//请求流水�?
		//投保单号，不是订单号
		//渠道id
		//渠道唯一标示
		//加密�?
		//普�?�类型，0为Pc.1为H5
		//支付成功之后返回链接(如果是cps支付，需填写，用户能有更好的体验)
		
	}
}
