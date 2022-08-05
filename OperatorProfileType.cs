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
        BasicInfo,
        /// <summary>
        /// 综合体检测试
        /// </summary>
        PhysicalExam,
        /// <summary>
        /// 客观履历
        /// </summary>
        ObjectiveProfile,
        /// <summary>
        /// 临床诊断分析
        /// </summary>
        ClinicalAnalysis,
        /// <summary>
        /// 档案资料一
        /// </summary>
        ArchiveFile1,
        /// <summary>
        /// 档案资料二
        /// </summary>
        ArchiveFile2,
        /// <summary>
        /// 档案资料三
        /// </summary>
        ArchiveFile3,
        /// <summary>
        /// 档案资料四
        /// </summary>
        ArchiveFile4,
        /// <summary>
        /// 晋升记录
        /// </summary>
        PromotionFile,
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