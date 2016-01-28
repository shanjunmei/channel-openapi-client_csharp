

namespace com.hzins.channel.api.model.info
{
	/// <summary>
	/// <p>
	/// 投保单信�?
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-5-5 下午8:14:55</date>
	/// <version/>
	public class OrderDetailInfo
	{
		public string insureNum;

		public int payState;

		public int issueState;

		public int effectiveState;

		public string insureTime;

		public int totalNum;

		public double price;

		public string productName;

		public string planName;

		public string startDate;

		public string endDate;

		public string deadline;

		public string companyName;

		public string applicant;

		public string insurant;

		// 保单类型�?2待完成，3未支付，4已支�?
		// (1 未支�?;10 未出�?;20 已出�?;30 延时出单;40 取消出单)
		// 生效�?(1 未生�?;2 已生�?;3 已�??�? 21 �?保中)
		// 投保时间
		// 总份�?
		// 价格
		// 起保时间
		// 截止时间
		// 保险期限
		// 保险公司名称
		// 投保人姓�?
		// 被保险人姓名
		
	}
}
