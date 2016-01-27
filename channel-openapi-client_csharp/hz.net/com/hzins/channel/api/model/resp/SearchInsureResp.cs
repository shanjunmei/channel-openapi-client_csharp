

namespace com.hzins.channel.api.model.resp
{
	/// <summary>
	/// <p>
	/// 查询保单列表
	/// </p>
	/// </summary>
	/// <author>hz15041177</author>
	/// <date>2015-5-22 下午3:28:04</date>
	/// <version></version>
	public class SearchInsureResp
	{
		public int partnerId;

		public string transNo;

		public System.Collections.Generic.IList<com.hzins.channel.api.model.info.OrderDetailInfo
			> orderDetailInfos;

		//代理商编�?
		//交易流水号，每一单请求交易不能相�?
		//保单列表
		
	}
}
