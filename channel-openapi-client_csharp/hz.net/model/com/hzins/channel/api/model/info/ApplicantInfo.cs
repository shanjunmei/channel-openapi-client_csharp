

namespace com.hzins.channel.api.model.info
{
	/// <summary>
	/// <p>
	/// 投保人信息
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-4-2 下午5:46:53</date>
	/// <version></version>
	public class ApplicantInfo
	{
        // 投保人姓名
        public string cName;

        // 投保人英文名，境外险必填
        public string eName;

        // 投保人证件类型
        public int cardType;

        // 证件号码
        public string cardCode;

        // 性别 0女 1男
        public int sex;

        // 出生日期
        public string birthday;

        // 手机号码
        public string mobile;

        // 电子邮箱
        public string email;

        // 职业信息
        public string jobInfo;

        //国籍
        public string country;

		
		
	}
}
