

namespace com.hzins.channel.api.model.req
{
	/// <summary>
	/// <p>
	/// 服务费明细请求信�?
	/// </p>
	/// </summary>
	/// <author>hz15051252</author>
	/// <date>2015�?6�?12�? 下午3:41:09</date>
	/// <version></version>
	public class SettlementDetailReq
	{
		public string transNo;

		public int partnerId;

		public string userId;

		public string insureNums;

		public string startTime;

		public string endTime;

		public int pageNum;

		public int pageSize;

		public string sign;

		//流水号，每次请求不相�?
		//代理商编�?
		//渠道唯一的标�?
		//投保单号(多个以英文�?�号隔开)
		//查询�?始时�?
		//查询结束时间
		//查询页数
		//每页数量
		//签名
		
	}
}
