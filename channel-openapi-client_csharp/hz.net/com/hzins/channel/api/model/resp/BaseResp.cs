

namespace com.hzins.channel.api.model.resp
{
    /// <summary>
    /// <p>
    /// 响应基类
    /// </p>
    /// </summary>
    /// <author>hz15031081</author>
    /// <date>2015-4-2 5:10:35</date>
    /// <version></version>
    public abstract class BaseResp
    {
        //交易流水号
        public string transNo { get; set; }

        //渠道号
        public int partnerId { get; set; }



    }
}
