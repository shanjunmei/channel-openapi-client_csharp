

namespace com.hzins.channel.api.model.req
{
	/// <summary>
	/// <p>
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-7-24 下午7:57:02</date>
	/// <version/>
	public class OrderSearchReq
	{
		public int partnerId;

		public string transNo;

		public string sign;

		public int pageNum;

		public int pageSize;

		public string startTime;

		public string endTime;

		public string applicant;

		public string insurant;

		public string idCard;

		public string userId;

		public System.Collections.Generic.IList<string> insureNums;

		// 代理商编�?
		// 交易流水号，每一单请求交易不能相�?
		// 数字签名
		// 当前�?
		// 每页显示数据
		//投保�?始时�?
		//投保结束时间
		//投保人姓�?
		//被保险人姓名
		//投保人证件号�?
		//userId
		// 多个投保单号
		
	}
}
