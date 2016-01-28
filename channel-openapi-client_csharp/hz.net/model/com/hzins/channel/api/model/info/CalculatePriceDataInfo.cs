

namespace com.hzins.channel.api.model.info
{
	/// <summary>
	/// <p>
	/// 寿险健康险需加入的试算实体类
	/// </p>
	/// </summary>
	/// <author>hz15041177</author>
	/// <date>2015-11-7 下午7:58:39</date>
	/// <version></version>
	public class CalculatePriceDataInfo
	{
        public string optionValue;

        public int paymentLimit;

        public int insurancePeriod;

        public int insuranceUnit;

        public double insuranceAmount;

		//保证项目选项�?(暂时不传)
		//缴费期限 �?次�?�缴或�?�趸�? �?0
		//保障期限
		//保障期限单位 1为年 2为岁
		//保险金额
	
	}
}
