

namespace com.hzins.channel.api.model.resp
{
	/// <summary>
	/// <p>
	/// 结算申请返回
	/// </p>
	/// </summary>
	/// <author>hz15051252</author>
	/// <date>2015�?6�?12�? 下午7:12:25</date>
	/// <version></version>
	public class SettlementBillTotalResp
	{
		public string transNo;

		public int partnerId;

		public double payed;

		public double unPayed;

		public double allowPayed;

		//已结�?
		//未结�?
		//当前可结�?(不会根据时间条件查询)
		
	}
}
