

namespace com.hzins.channel.api.model.info
{
	/// <summary>
	/// <p>
	/// 申请结算明细信息
	/// </p>
	/// </summary>
	/// <author>hz15051252</author>
	/// <date>2015�?6�?12�? 下午7:06:25</date>
	/// <version></version>
	public class SettlementBillDetailInfo
	{
		public int billId;

		public int year;

		public int month;

		public string range;

		public string createTime;

		public int userType;

		public double applyFee;

		public double deductTax;

		public double payFee;

		public int state;

		//申请服务费结算之后的settlementBill数据的Id
		//结算年份
		//结算月度
		//结算周期
		//申请结算时间
		//用户类型(0表示渠道�?1表示代理�?)
		//应付收入(税前)
		//代扣税款
		//应付收入(税后)
		//结算状�??(0未结算，1表示已结�?)
		
	}
}
