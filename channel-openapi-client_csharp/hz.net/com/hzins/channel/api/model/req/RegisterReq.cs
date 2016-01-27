

namespace com.hzins.channel.api.model.req
{
	/// <summary>
	/// <p>
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-5-8 上午11:32:45</date>
	/// <version/>
	
	public class RegisterReq
	{


		public string transNo;

		public int partnerId;

		public int channelType;

		public int webType;

		public string userId;

		public string email;

		public string loginPassWord;

		public string contactName;

		public string contactNumber;

		public string sign;

		public int feetemplateId;

		public string expandEmployeeName;

		public int expandEmployeeId;

		public string companyCode;

		public string companyName;

		// 渠道类型 0：个�? 1：公�?  (必填)
		// 1:户外=1 2:旅行�? 3:签证机构 4:旅游网站 0:其他(必填)
		// 渠道在agent中唯�?的标示，存放到数据库的CardNumber字段
		// 邮箱
		// 登陆密码
		// 联系�? 必填
		// 联系电话 必填
		//数字签名
		//渠道服务费模板Id(非必�?)
		//拓展人员名字
		//拓展人员ID
		//公司代码
		//公司名称
		
	}
}
