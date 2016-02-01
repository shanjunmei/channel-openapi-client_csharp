

namespace com.hzins.channel.api.model.req
{
    /// <summary>
    /// <p>
    /// 请求基类
    /// </p>
    /// </summary>
    /// <author>hz15031081</author>
    /// <date>2015-4-2 5:10:35</date>
    /// <version></version>
    public abstract class BaseReq
    {

        /// <summary>
        /// 交易流水号，每次请求都不一样，方便后期问题跟踪
        /// </summary>
        public string transNo;

        /// <summary>
        /// 渠道号
        /// </summary>
        public int partnerId;

        /// <summary>
        /// 签名，验证身份，防止请求参数篡改
        /// </summary>
        public string sign;

        /// <summary>
        /// 渠道会员
        /// </summary>
        public string userId;

    }
}
