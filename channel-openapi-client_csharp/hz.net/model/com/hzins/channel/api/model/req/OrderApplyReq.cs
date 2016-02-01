

namespace com.hzins.channel.api.model.req
{
	/// <summary>
	/// <p>
	///
	/// </p>
	/// </summary>
	/// <author>hz15041177</author>
	/// <date></date>
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

		
		
	}
}
