using System.Text.Json.Serialization;

namespace ArknightsResources.Operators.Models
{
    /// <summary>
    /// 表示干员立绘信息的结构
    /// </summary>
    public readonly struct OperatorIllustrationInfo
    {
        /// <summary>
        /// 初始化<see cref="OperatorIllustrationInfo"/>结构的新实例
        /// </summary>
        /// <param name="illustrationName">立绘名称</param>
        /// <param name="description">立绘描述</param>
        /// <param name="imageCodename">立绘图片代号</param>
        /// <param name="type">立绘类型</param>
        /// <param name="illustrator">立绘画师</param>
        [JsonConstructor]
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
        public string IllustrationName { get; }

        /// <summary>
        /// 立绘描述
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// 立绘图片代号
        /// </summary>
        public string ImageCodename { get; }

        /// <summary>
        /// 此立绘的种类
        /// </summary>
        public OperatorType Type { get; }

        /// <summary>
        /// 立绘画师
        /// </summary>
        public string Illustrator { get; }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"Name:{IllustrationName};IllustType:{Type};IllustCodename:{ImageCodename};Illustrator:{Illustrator}";
        }
    }
}
