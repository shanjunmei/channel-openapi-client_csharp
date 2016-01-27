

namespace com.hzins.channel.api.model
{
	/// <summary>
	/// <p>
	/// </p>
	/// </summary>
	/// <author>hz15031081</author>
	/// <date>2015-4-2 下午5:43:13</date>
	/// <version></version>
	public class ApplicationData
	{
        // 投保时间
        private string _applicationDate;

       

        // 起保日期，保单的生效时间
        private string _startDate;

       

        // 终保日期，保单的失效时间
        private string _endDate;

       

        // 结算价，即相应保险产品的保费
        private double _singlePrice;

     

        public string applicationDate
        {
            get { return _applicationDate; }
            set { _applicationDate = value; }
        }

        public string startDate
        {
            get { return _startDate; }
            set { _startDate = value; }
        }

        public string endDate
        {
            get { return _endDate; }
            set { _endDate = value; }
        }

        public double singlePrice
        {
            get { return _singlePrice; }
            set { _singlePrice = value; }
        }
	}
}
