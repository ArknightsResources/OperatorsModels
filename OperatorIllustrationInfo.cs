using System.Xml.Serialization;

namespace ArknightsResources.Operators.Models
{
    /// <summary>
    /// 表示干员立绘信息的结构
    /// </summary>
    public struct OperatorIllustrationInfo
    {
        /// <summary>
        /// 初始化<see cref="OperatorIllustrationInfo"/>结构的新实例
        /// </summary>
        /// <param name="illustrationName">立绘名称</param>
        /// <param name="description">立绘描述</param>
        /// <param name="imageCodename">立绘图片代号</param>
        /// <param name="type">立绘类型</param>
        /// <param name="illustrator">立绘画师</param>
        public OperatorIllustrationInfo(string illustrationName, string description, string imageCodename,
                                        OperatorType type, string illustrator)
        {
            IllustrationName = illustrationName;
            Description = description;
            ImageCodename = imageCodename;
            Type = type;
            Illustrator = illustrator;
        }

        /// <summary>
        /// 立绘名称
        /// </summary>
        [XmlAttribute]
        public string IllustrationName;

        /// <summary>
        /// 立绘描述
        /// </summary>
        [XmlAttribute]
        public string Description;

        /// <summary>
        /// 立绘图片代号
        /// </summary>
        [XmlAttribute]
        public string ImageCodename;

        /// <summary>
        /// 此立绘的种类
        /// </summary>
        [XmlAttribute]
        public OperatorType Type;

        /// <summary>
        /// 立绘画师
        /// </summary>
        [XmlAttribute]
        public string Illustrator;

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{IllustrationName};{Type};{ImageCodename};{Illustrator}";
        }
    }
}
