

namespace com.hzins.channel.api.model.req
{
	/// <summary>
	/// <p>
	/// 支付接口请求对象
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-4-27 上午11:26:02</date>
	/// <version></version>
	public class AppPrePayReq
	{
		public string transNo;

		public int partnerId;

		public string userId;

		public string sign;

		public string orderNum;

		public int payGatewayId;

		public int bankId;

		public int appTypeId;

		public string ip;

		// 交易流水号，每一单请求交易不能相�?
		// 代理商编�?
		//商户Id
		// 数字签名
		// 投保单号
		//  1 支付�?,21 微信充�??
		//银行编号，目前只支持微信和支付宝支付，暂时此字段不对外开�?
		//安卓3 ios 6
		//IP地址
		
	}
}
