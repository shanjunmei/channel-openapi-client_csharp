

namespace com.hzins.channel.api.model.req
{
	/// <summary>
	/// <p>
	/// �?保请求消�?
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-4-9 下午3:22:12</date>
	/// <version></version>
	public class OrderCancelReq
	{
		public string transNo;

		public int partnerId;

		public string sign;

		public string insureNo;

		public com.hzins.channel.api.model.info.ExtendInfo extendInfo;

		// 扩展信息
		
	}
}
