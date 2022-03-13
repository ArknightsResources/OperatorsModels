using System.Xml.Serialization;

namespace ArknightsResources.Operators.Models
{
    /// <summary>
    /// 干员档案类型的枚举
    /// </summary>
    public enum OperatorProfileType
    {
        /// <summary>
        /// 基础档案
        /// </summary>
        BasicProfile,
        /// <summary>
        /// 客观档案
        /// </summary>
        ObjectiveProfile,
        /// <summary>
        /// 临床诊断分析
        /// </summary>
        ClinicalAnalysis,
        /// <summary>
        /// 档案资料一
        /// </summary>
        File1,
        /// <summary>
        /// 档案资料二
        /// </summary>
        File2,
        /// <summary>
        /// 档案资料三
        /// </summary>
        File3,
        /// <summary>
        /// 档案资料四
        /// </summary>
        File4,
        /// <summary>
        /// 晋升记录
        /// </summary>
        PromotionRecord,
        /// <summary>
        /// 未知
        /// </summary>
        Unknown,
        /// <summary>
        /// 升变档案一
        /// </summary>
        Promotion1
    }
}