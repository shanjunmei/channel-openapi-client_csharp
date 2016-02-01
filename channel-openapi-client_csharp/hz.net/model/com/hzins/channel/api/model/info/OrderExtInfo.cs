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
namespace com.hzins.channel.api.model.info
{

    /**
     * <p>
     * 
     * </p>
     * @author	hz15031081 
     * @date	2015-4-13 下午4:36:22
     * @version      
     */
    public class OrderExtInfo
    {

        /// <summary>
        /// 惠择投保单号
        /// </summary>
        public string insureNum;

        /// <summary>
        /// 被保人id集合
        /// </summary>
        public IList<string> insurantIds;

        /// <summary>
        /// 被保人数量
        /// </summary>
        public int insurantCount;

        /// <summary>
        /// 本单总价
        /// </summary>
        public double priceTotal;

        public Dictionary<string, string> insurantMap;


    }
}