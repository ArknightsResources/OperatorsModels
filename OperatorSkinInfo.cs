using System.Xml.Serialization;

namespace ArknightsResources.Operators.Models
{
    /// <summary>
    /// 表示干员皮肤信息的结构
    /// </summary>
    public struct OperatorSkinInfo
    {
        /// <summary>
        /// 皮肤名称
        /// </summary>
        [XmlAttribute]
        public string Name;

        /// <summary>
        /// 皮肤描述
        /// </summary>
        [XmlAttribute]
        public string Description;

        /// <summary>
        /// 图片代号
        /// </summary>
        [XmlAttribute]
        public string ImageCodename;

        /// <summary>
        /// 返回供编程使用,表示该结构的字符串
        /// </summary>
        /// <returns>供编程使用,以分号(";")分隔每个值的表示该结构的字符串</returns>
        public override string ToString()
        {
            return $"{Name};{Description};{ImageCodename}";
        }
    }
}
