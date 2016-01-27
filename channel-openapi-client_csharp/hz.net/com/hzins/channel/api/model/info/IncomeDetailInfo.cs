

namespace com.hzins.channel.api.model.info
{
	/// <summary>
	/// <p>
	/// 服务费按月汇总详细信�?
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-4-2 下午5:51:54</date>
	/// <version></version>
	public class IncomeDetailInfo
	{
		public int settlementState;

		public int month;

		public string userId;

		public int year;

		public double totalIncome;

		public double premium;

		//0为未结算�?1为结算中�?2为已经结�?
		//总计服务�?(Income+Award)
		//总计保费
	
	}
}
