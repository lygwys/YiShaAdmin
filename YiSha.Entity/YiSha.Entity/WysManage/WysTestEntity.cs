using System;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations.Schema;
using YiSha.Util;

namespace YiSha.Entity.WysManage
{
    /// <summary>
    /// 创 建：admin
    /// 日 期：2021-03-25 15:54
    /// 描 述：实体类
    /// </summary>
    [Table("WysTest")]
    public class WysTestEntity : BaseExtensionEntity
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string TestTitle { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string TestContent { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string TestTag { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string ThumbImage { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string TestAuthor { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int? TestSort { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(DateTimeJsonConverter))]
        public DateTime? TestDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int? TestType { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int? ViewTimes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? ProvinceId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? CityId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [JsonConverter(typeof(StringJsonConverter))]
        public long? CountyId { get; set; }
    }
}
