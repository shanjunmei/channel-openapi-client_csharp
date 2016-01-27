

namespace com.hzins.channel.api.model.resp
{
	public class ProductDetailResp : com.hzins.channel.api.model.resp.BaseResp
	{
		public string productName;

		public string planName;

		public int productId;

		public int planId;

		public System.Collections.Generic.IList<com.hzins.channel.api.model.PlanDetail> 
			planDetails;

		public double price;

		//    public String introduction;
		//    public List<Map<String, String>> planParams;
		
	}
}
