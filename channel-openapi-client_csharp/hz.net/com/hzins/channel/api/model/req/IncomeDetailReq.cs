

namespace com.hzins.channel.api.model.req
{
    /// <summary>
    /// <p>
    /// 结算前每月汇总查询请求参�?
    /// </p>
    /// </summary>
    /// <author>hz15051252</author>
    /// <date>2015�?6�?12�? 下午6:58:30</date>
    /// <version></version>
    public class IncomeDetailReq
    {
        public string transNo;

        public int partnerId;

        public System.Collections.Generic.IList<string> userIds;

        public int year;

        public int month;

        public string sign;

        //流水号，每次请求不相�?
        //代理商ID
        //渠道唯一的标�?
        //年份
        //月份
        //签名

    }
}
