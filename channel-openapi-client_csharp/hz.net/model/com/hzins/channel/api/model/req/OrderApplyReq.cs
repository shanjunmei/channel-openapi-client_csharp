

namespace com.hzins.channel.api.model.req
{
	/// <summary>
	/// <p>
	/// 第三方投保对接投保请求消�?
	/// </p>
	/// </summary>
	/// <author>hz15041177</author>
	/// <date>2015-11-5 下午5:56:55</date>
	/// <version/>
	public class OrderApplyReq
	{
		public string transNo;

		public string caseCode;

		public int partnerId;

		public string sign;

		public com.hzins.channel.api.model.ApplicationData applicationData;

		public com.hzins.channel.api.model.info.ApplicantInfo applicantInfo;

		public System.Collections.Generic.IList<com.hzins.channel.api.model.info.InsurantInfo
			> insurantInfos;

		public com.hzins.channel.api.model.info.ExtendInfo extendInfo;

		public com.hzins.channel.api.model.info.HealthInfo healthInfo;

		public System.Collections.Generic.IList<com.hzins.channel.api.model.info.InsureBeneficiaryInfo
			> insureBenfInfos;

		public com.hzins.channel.api.model.info.CalculatePriceDataInfo calculatePriceDataInfo;

		// 交易流水号，每一单请求交易不能相�?
		// 方案代码，每�?款保险公司的方案代码都不相同，由慧择分配
		// 代理商编�?
		// 数字签名
		// 订单数据
		// 投保人信�?
		// 被保人信�?
		// 扩展信息
		//寿险健康险专用实�?
		//寿险投保受益人实体类
		//寿险健康险需加入的试算实体类
		
	}
}
