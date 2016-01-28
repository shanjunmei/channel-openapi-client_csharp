

namespace com.hzins.channel.api.model.req
{
	/// <summary>
	/// <p>
	/// 服务费结算请求实�?
	/// </p>
	/// </summary>
	/// <author>hz15051252</author>
	/// <date>2015�?5�?11�? 下午3:38:53</date>
	/// <version/>
	public class SettlementReq
	{
		public string transNo;

		public int partnerId;

		public string sign;

		public string userId;

		public com.hzins.channel.api.model.info.FinancialInfo financialInfo;

	
	}
}
