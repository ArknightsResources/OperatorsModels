using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ArknightsResources.Operators.Models
{
    /// <summary>
    /// 表示干员立绘信息的结构
    /// </summary>
    public readonly struct OperatorIllustrationInfo : IEquatable<OperatorIllustrationInfo>
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
        public override bool Equals(object obj)
        {
            return obj is OperatorIllustrationInfo info && Equals(info);
        }

        /// <inheritdoc/>
        public bool Equals(OperatorIllustrationInfo other)
        {
            return IllustrationName == other.IllustrationName &&
                   Description == other.Description &&
                   ImageCodename == other.ImageCodename &&
                   Type == other.Type &&
                   Illustrator == other.Illustrator;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -111007248;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(IllustrationName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Description);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ImageCodename);
            hashCode = hashCode * -1521134295 + Type.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Illustrator);
            return hashCode;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"Name:{IllustrationName};IllustType:{Type};IllustCodename:{ImageCodename};Illustrator:{Illustrator}";
        }

        /// <inheritdoc/>
        public static bool operator ==(OperatorIllustrationInfo left, OperatorIllustrationInfo right)
        {
            return left.Equals(right);
        }

        /// <inheritdoc/>
        public static bool operator !=(OperatorIllustrationInfo left, OperatorIllustrationInfo right)
        {
            return !(left == right);
        }
    }
}
