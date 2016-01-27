

namespace com.hzins.channel.api.model.resp
{
	/// <summary>
	/// <p>
	/// 服务费明细返回实�?
	/// </p>
	/// </summary>
	/// <author>hz15051252</author>
	/// <date>2015�?6�?12�? 上午9:40:12</date>
	/// <version></version>
	public class SettlementDetailResp
	{
		public string transNo;

		public int partnerId;

		public int pageNum;

		public int pageSize;

		public int total;

		public System.Collections.Generic.IList<com.hzins.channel.api.model.info.SettlementDetailInfo
			> settlementDetailList;

		//流水�?
		//代理商编�?
		//    public int pageIndex;
		//服务费明细信�?
		
	}
}
