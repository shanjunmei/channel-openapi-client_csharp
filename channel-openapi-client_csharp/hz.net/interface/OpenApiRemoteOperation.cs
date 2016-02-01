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
    /// <summary>
    /// 服务端接口
    /// </summary>
    public interface OpenApiRemoteOperation
    {



        /// <summary>
        /// 产品列表
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        [Command("productList")]
        CommonResult<ProductListResp> productList(ProductListReq req);

        /// <summary>
        /// 产品详情
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        CommonResult<ProductDetailResp> productDetail(ProductDetailReq req);

        /// <summary>
        /// 投保
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        CommonResult<OrderApplyResp> orderApply(OrderApplyReq req);

        /// <summary>
        /// 退保
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        CommonResult<OrderCancelResp> orderCancel(OrderCancelReq req);

        /// <summary>
        /// 保单下载
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        CommonResult<InsureDownloadResp> download(InsureDownloadReq req);

        /// <summary>
        /// CPS支付
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        CommonResult<CpsPayResp> cpsPay(CpsPayReq req);

        /// <summary>
        /// API支付
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        CommonResult<PrePayResp> prePay(PrePayReq req);

        /// <summary>
        /// APP支付
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        CommonResult<AppPrePayResp> appPrePay(AppPrePayReq req);

        /// <summary>
        /// 渠道注册
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        CommonResult<RegisterResp> register(RegisterReq req);

        /// <summary>
        /// 投保单查询
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        CommonResult<SearchInsureResp> orderDetail(OrderDetailReq req);

        /// <summary>
        /// 批量查询保单（分页）
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        CommonResult<SearchInsureResp> orderSearch(OrderSearchReq req);

        /// <summary>
        /// 投保单详情
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        CommonResult<InsureDetailResp> insureDetail(InsureDetailReq req);

        /// <summary>
        /// 服务费结算
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        CommonResult<FinancialInfo> submitSettlement(SettlementReq req);

        /// <summary>
        /// 服务费明细
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        CommonResult<SettlementDetailResp> settlementDetail(SettlementDetailReq req);

        /// <summary>
        /// 结算申请明细
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        CommonResult<SettlementBillDetailResp> settlementBillDetail(SettlementBillDetailReq req);

        /// <summary>
        /// 结算申请汇总
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        CommonResult<SettlementBillTotalResp> settlementBillTotal(SettlementBillTotalReq req);

        /// <summary>
        /// 服务费按月汇总
        /// </summary>
        /// <param name="req"></param>
        /// <returns></returns>
        CommonResult<IncomeDetailResp> incomeDetail(IncomeDetailReq req);

    }
}
