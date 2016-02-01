/**
 * Copyright (c) 2006-2015 Hzins Ltd. All Rights Reserved. 
 *  
 * This code is the confidential and proprietary information of   
 * Hzins. You shall not disclose such Confidential Information   
 * and shall use it only in accordance with the terms of the agreements   
 * you entered into with Hzins,http://www.hzins.com.
 *  
 */


using System.Collections.Generic;

using com.hzins.channel.api.model.info;

namespace com.hzins.channel.api.model.resp
{
    /// <summary>
    /// 投保返回信息
    /// </summary>
    public class OrderApplyResp
    {
        /// <summary>
        /// 交易流水号
        /// </summary>
        public string transNo;


        /// <summary>
        /// 代理商信息
        /// </summary>
        public int partnerId;

        /// <summary>
        /// 惠择投保单号
        /// </summary>
        public string insureNum;



        /// <summary>
        /// 保单信息
        /// </summary>
        public IList<OrderInfo> orderInfos;

        /// <summary>
        /// 保单与被保人关联信息
        /// </summary>
        public IList<OrderExtInfo> orderExts;


    }
}