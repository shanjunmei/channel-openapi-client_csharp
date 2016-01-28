

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
	public class PrePayReq
	{
		public string transNo;

		public int partnerId;

		public string userId;

		public string caseCode;

		public string sign;

		public string orderNum;

		public int onliePaymnetId;

		public int bankId;

		public string pageNoticeUrl;

		public string price;

		// 交易流水号，每一单请求交易不能相�?
		// 代理商编�?
		//商户Id
		// 方案代码
		// 数字签名
		// 投保单号
		// 在线支付网关标识�?1：支付宝�?3：银联；12：易宝在线；13：易宝无卡支付；14：财付�?�；15：手机支付；16：银�?(B2B)�?21：微信支�?
		// 银行标识，当值大�?0时，会直接跳转到相应的银行页�?
		// 页面返回地址
		// 支付金额（单位：元）
		
	}
}
