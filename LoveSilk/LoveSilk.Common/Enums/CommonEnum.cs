using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoveSilk.Common.Enums
{
    /// <summary>
    /// 用户状态字段 统一使用
    /// </summary>
    public class CommonEnum
    {
        public enum userRole
        {
            /// <summary>
            /// 集团负责人
            /// </summary>
            [Description("集团负责人")]
            JT = 2,
            /// <summary>
            /// 机构负责人
            /// </summary>
            [Description("机构负责人")]
            JG = 1,
            /// <summary>
            /// 普通职员
            /// </summary>
            [Description("普通职员")]
            ZY = 0
        }

        /// <summary>
        /// 是否填写完成
        /// </summary>
        public enum IsOver
        {
            /// <summary>
            /// 暂未填写完毕
            /// </summary>
            [Description("暂未填写完毕")]
            NoOver = 1,
            /// <summary>
            /// 填写完毕
            /// </summary>
            [Description("填写完毕")]
            Over = 2
        }

        /// <summary>
        /// 功能点
        /// </summary>
        public enum NodeFun
        {
            /// <summary>
            /// 案件信息
            /// </summary>
            [Description("案件信息")]
            Anb_AnJian ,
            /// <summary>
            /// 客户基础信息
            /// </summary>
            [Description("客户基础信息")]
            Anb_Cus,
            /// <summary>
            /// 垫付信息
            /// </summary>
            [Description("垫付信息")]
            Anb_Dpay,
            /// <summary>
            /// 工伤信息
            /// </summary>
            [Description("工伤信息")]
            Anb_GSinfo,
            /// <summary>
            /// 工伤理算信息
            /// </summary>
            [Description("工伤理算信息")]
            Anb_GSLSinfo,
            /// <summary>
            /// 事故信息
            /// </summary>
            [Description("事故信息")]
            Anb_SGinfo,
            /// <summary>
            /// 首诊医疗信息
            /// </summary>
            [Description("首诊医疗信息")]
            Anb_SZYLinfo,
            /// <summary>
            /// 末次医疗信息
            /// </summary>
            [Description("末次医疗信息")]
            Anb_MCYLinfo,
            /// <summary>
            /// 车辆信息
            /// </summary>
            [Description("车辆信息")]
            Anb_CarInfo,
            /// <summary>
            /// 保险调解
            /// </summary>
            [Description("保险调解")]
            Anb_BXMediate,
            /// <summary>
            /// 诉前准备
            /// </summary>
            [Description("诉前准备")]
            Anb_beforeLaw,
            /// <summary>
            /// 医药费诉讼
            /// </summary>
            [Description("医药费诉讼")]
            Anb_YyfLaw,
            /// <summary>
            /// 整体诉讼
            /// </summary>
            [Description("整体诉讼")]
            Anb_MainLaw,
            /// <summary>
            /// 诉后结案
            /// </summary>
            [Description("诉后结案")]
            Anb_AfterLaw,
            /// <summary>
            /// 案件财务
            /// </summary>
            [Description("案件财务")]
            Anb_Finance,




            /// <summary>
            /// 无下一环节
            /// </summary>
            [Description("无下一环节")]
            Anb_Over,

        }


        /// <summary>
        /// 功能点-视图
        /// </summary>
        public enum ViewFun
        {
            /// <summary>
            /// 案件信息
            /// </summary>
            [Description("案件信息")]
            V_AnJian,
            /// <summary>
            /// 客户基础信息
            /// </summary>
            [Description("客户信息")]
            V_AnbCus,
            /// <summary>
            /// 垫付信息
            /// </summary>
            [Description("垫付")]
            V_AnbDpay,
            /// <summary>
            /// 工伤信息
            /// </summary>
            [Description("工伤")]
            V_AnbGSinfo,
            /// <summary>
            /// 工伤理算信息
            /// </summary>
            [Description("工伤理算")]
            V_AnbGSLSinfo,
            /// <summary>
            /// 事故信息
            /// </summary>
            [Description("事故信息")]
            V_AnbSGinfo,
            /// <summary>
            /// 首诊医疗信息
            /// </summary>
            [Description("首诊医疗")]
            V_AnbSZYLinfo,
            /// <summary>
            /// 末次医疗信息
            /// </summary>
            [Description("末次医疗")]
            V_AnbMCYLinfo,


            /// <summary>
            /// 车辆信息
            /// </summary>
            [Description("车辆信息")]
            V_AnbCarInfo,
            /// <summary>
            /// 保险调解
            /// </summary>
            [Description("保险调解")]
            V_AnbBXMediate,
            /// <summary>
            /// 诉前准备
            /// </summary>
            [Description("诉前准备")]
            V_AnbbeforeLaw,
            /// <summary>
            /// 医药费诉讼
            /// </summary>
            [Description("医药费诉讼")]
            V_AnbYyfLaw,
            /// <summary>
            /// 整体诉讼
            /// </summary>
            [Description("整体诉讼")]
            V_AnbMainLaw,
            /// <summary>
            /// 诉后结案
            /// </summary>
            [Description("诉后结案")]
            V_AnbAfterLaw,
            /// <summary>
            /// 案件财务
            /// </summary>
            [Description("案件财务")]
            V_AnbFinance,


            /// <summary>
            /// 无下一环节
            /// </summary>
            [Description("无下一环节")]
            Anb_Over,

        }

        public enum anjianzhuangtai
        {
            待签,
            已签,
            结案,
            坏账案件,
            放弃,
            退案
        }
    }
}
