

namespace com.hzins.channel.api.model.req
{
	/// <summary>
	/// <p>
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date></date>
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

		
		
	}
}
