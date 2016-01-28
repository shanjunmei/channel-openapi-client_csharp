using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using com.hzins.channel.api.model.common;

using com.hzins.channel.api.model.resp;
using com.hzins.channel.api.model.req;
using com.hzins.channel.api.model.info;
using com.hzins.rpc.client.core;

namespace com.hzins.rpc.client.openapi.inter
{
  
    public interface OpenApiRemoteOperation
    {



        /**
         * 
         * <p>
         * 
         * 产品列表
         *
         * </p>
         * 
         * @param req
         * @return
         * 
         * @author hz15101769
         * @date 2016年1月7日 上午8:52:49
         * @version
         */
        [Command("productList")]
        CommonResult<ProductListResp> productList(ProductListReq req);

        /**
         * 
         * <p>
         * 
         * 产品详情
         *
         * </p>
         * 
         * @param req
         * @return
         * 
         * @author hz15101769
         * @date 2016年1月7日 上午8:56:35
         * @version
         */
        CommonResult<ProductDetailResp> productDetail(ProductDetailReq req);

        /**
         * 
         * <p>
         * 
         * 投保
         *
         * </p>
         * 
         * @param req
         * @return
         * 
         * @author hz15101769
         * @date 2016年1月6日 下午4:55:04
         * @version
         */
         CommonResult<OrderApplyResp> orderApply(OrderApplyReq req);

        /**
         * 
         * <p>
         * 
         * 退保
         *
         * </p>
         * 
         * @param req
         * @return
         * 
         * @author hz15101769
         * @date 2016年1月7日 上午9:05:18
         * @version
         */
        CommonResult<OrderCancelResp> orderCancel(OrderCancelReq req);

        /**
         * 
         * <p>
         * 
         * 保单下载
         *
         * </p>
         * 
         * @param req
         * @return
         * 
         * @author hz15101769
         * @date 2016年1月7日 上午9:05:26
         * @version
         */
        CommonResult<InsureDownloadResp> download(InsureDownloadReq req);

        /**
         * 
         * <p>
         * 
         * CPS支付
         *
         * </p>
         * 
         * @param req
         * @return
         * 
         * @author hz15101769
         * @date 2016年1月7日 上午9:05:45
         * @version
         */
        CommonResult<CpsPayResp> cpsPay(CpsPayReq req);

        /**
         * 
         * <p>
         * 
         * 8.API支付
         *
         * </p>
         * 
         * @param req
         * @return
         * 
         * @author hz15101769
         * @date 2016年1月7日 上午9:05:55
         * @version
         */
        CommonResult<PrePayResp> prePay(PrePayReq req);

        /**
         * 
         * <p>
         * 
         * APP支付
         *
         * </p>
         * 
         * @param req
         * @return
         * 
         * @author hz15101769
         * @date 2016年1月7日 上午9:06:14
         * @version
         */
        CommonResult<AppPrePayResp> appPrePay(AppPrePayReq req);

        /**
         * 
         * <p>
         * 
         * 渠道注册
         *
         * </p>
         * 
         * @param req
         * @return
         * 
         * @author hz15101769
         * @date 2016年1月7日 上午9:06:26
         * @version
         */
        CommonResult<RegisterResp> register(RegisterReq req);

        /**
         * 
         * <p>
         * 
         * 投保单查询
         *
         * </p>
         * 
         * @param req
         * @return
         * 
         * @author hz15101769
         * @date 2016年1月7日 上午9:06:40
         * @version
         */
        CommonResult<SearchInsureResp> orderDetail(OrderDetailReq req);

        /**
         * 
         * <p>
         * 
         * 批量查询保单（分页）
         *
         * </p>
         * 
         * @param req
         * @return
         * 
         * @author hz15101769
         * @date 2016年1月7日 上午9:07:22
         * @version
         */
        CommonResult<SearchInsureResp> orderSearch(OrderSearchReq req);

        /**
         * 
         * <p>
         * 
         * 投保单详情
         *
         * </p>
         * 
         * @param req
         * @return
         * 
         * @author hz15101769
         * @date 2016年1月7日 上午9:07:29
         * @version
         */
        CommonResult<InsureDetailResp> insureDetail(InsureDetailReq req);

        /**
         * 
         * <p>
         * 
         * 服务费结算
         *
         * </p>
         * 
         * @param req
         * @return
         * 
         * @author hz15101769
         * @date 2016年1月7日 上午9:07:45
         * @version
         */
        CommonResult<FinancialInfo> submitSettlement(SettlementReq req);

        /**
         * 
         * <p>
         * 
         * 服务费明细
         *
         * </p>
         * 
         * @param req
         * @return
         * 
         * @author hz15101769
         * @date 2016年1月7日 上午9:08:12
         * @version
         */
        CommonResult<SettlementDetailResp> settlementDetail(SettlementDetailReq req);

        /**
         * 
         * <p>
         * 
         * 结算申请明细
         *
         * </p>
         * 
         * @param req
         * @return
         * 
         * @author hz15101769
         * @date 2016年1月7日 上午9:08:30
         * @version
         */
        CommonResult<SettlementBillDetailResp> settlementBillDetail(SettlementBillDetailReq req);

        /**
         * 
         * <p>
         * 
         * 结算申请汇总
         *
         * </p>
         * 
         * @param req
         * @return
         * 
         * @author hz15101769
         * @date 2016年1月7日 上午9:08:44
         * @version
         */
        CommonResult<SettlementBillTotalResp> settlementBillTotal(SettlementBillTotalReq req);

        /**
         * 
         * <p>
         * 
         * 服务费按月汇总
         *
         * </p>
         * 
         * @param req
         * @return
         * 
         * @author hz15101769
         * @date 2016年1月7日 上午9:09:09
         * @version
         */
        CommonResult<IncomeDetailResp> incomeDetail(IncomeDetailReq req);

    }
}
