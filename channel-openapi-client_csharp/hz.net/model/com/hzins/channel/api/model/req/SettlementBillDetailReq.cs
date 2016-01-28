

namespace com.hzins.channel.api.model.req
{
	/// <summary>
	/// <p>
	/// 结算申请请求信息
	/// </p>
	/// </summary>
	/// <author>hz15051252</author>
	/// <date>2015�?6�?12�? 下午6:58:30</date>
	/// <version></version>
	public class SettlementBillDetailReq
	{
		public string transNo;

		public int billId;

		public int partnerId;

		public string userId;

		public string startTime;

		public string endTime;

		public string sign;

		//流水号，每次请求不相�?
		//申请服务费结算之后的settlementBill数据的Id
		//代理商ID
		//渠道唯一的标�?
		//查询的申请结算开始时�?
		//查询的申请结算结束时�?
		//签名
	
	}
}
