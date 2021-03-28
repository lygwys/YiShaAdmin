using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using YiSha.Model.Param.SystemManage;
using YiSha.Util;

namespace YiSha.Model.Param.WysManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2021-03-25 15:54
    /// 描 述：实体查询类
    /// </summary>
    public class WysTestListParam:BaseAreaParam
    {
        public string TestTitle { get; set; }
        public int? TestType { get; set; }
        public string TestTag { get; set; }
    }
}
