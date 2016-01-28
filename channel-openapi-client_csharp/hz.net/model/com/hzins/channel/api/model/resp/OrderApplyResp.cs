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
    /**
     * <p>
     * 
     * </p>
     * @author	hz15031081 
     * @date	2015-4-13 下午7:56:26
     * @version      
     */
    public class OrderApplyResp
    {

        public string transNo;

        // 代理商信息
        public int partnerId;

        // 惠择投保单号
        public string insureNum;

        // 保单信息
        public IList<OrderInfo> orderInfos;

        //保单与被保人关联信息
        public IList<OrderExtInfo> orderExts;


    }
}