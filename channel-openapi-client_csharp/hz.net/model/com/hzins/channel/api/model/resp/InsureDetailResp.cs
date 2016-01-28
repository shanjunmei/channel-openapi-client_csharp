

namespace com.hzins.channel.api.model.resp
{
	/// <summary>
	/// <p>
	/// 保单查询返回信息
	/// </p>
	/// </summary>
	/// <author>hz15041177</author>
	/// <date>2015-5-5 下午2:48:45</date>
	/// <version></version>
	public class InsureDetailResp
	{
		public com.hzins.channel.api.model.info.ApplicantInfo applicantInfo;

		public System.Collections.Generic.IList<com.hzins.channel.api.model.info.InsurantInfo
			> insurantInfos;

		public com.hzins.channel.api.model.info.PolicyDetailInfo policyDetailInfo;

		public string contact;

		public string contactMob;

		public string companyName;

		public string prodName;

		public string transNo;

		public int partnerId;

		public string insureNum;

		// 投保人信�?
		// 被保险人信息
		// 保单明细
		// 紧�?�联系人
		// 紧�?�联系人电话
		// 保险公司名称
		// 产品名称
		//流水�?
		//渠道�?
		//投保单号
		
	}
}
