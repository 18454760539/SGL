using System;
using System.Linq;
using System.Text;

namespace Models
{
    ///<summary>
    ///员工积分表
    ///</summary>
    public partial class staffintegral
    {
           public staffintegral(){


           }
           /// <summary>
           /// Desc:唯一主键
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string staffintegral_guid {get;set;}

           /// <summary>
           /// Desc:工厂id
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? staffintegral_factoryid {get;set;}

           /// <summary>
           /// Desc:登录用户(员工)guid
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string staffintegral_staff_guid {get;set;}

           /// <summary>
           /// Desc:积分金额
           /// Default:
           /// Nullable:False
           /// </summary>           
           public decimal staffintegral_sub {get;set;}

           /// <summary>
           /// Desc:积分说明
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string staffintegral_explanation {get;set;}

           /// <summary>
           /// Desc:备注
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string staffintegral_remark {get;set;}

           /// <summary>
           /// Desc:积分来源guid
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string staffintegral_pointorder_guid { get;set;}

           /// <summary>
           /// Desc:积分来源
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string staffintegral_source {get;set;}

           /// <summary>
           /// Desc:积分获取时间
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? staffintegral_addtime {get;set;}

           /// <summary>
           /// Desc:删除状态,0为正常,1为已删除
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? staffintegral_isdelete {get;set;}

           /// <summary>
           /// Desc:订单类型(购买商品减少积分,购买产品增加积分等)
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string staffintegral_type { get;set;}

    }
}
