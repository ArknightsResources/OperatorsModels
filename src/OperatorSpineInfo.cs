using System;
using System.Collections.Generic;

namespace ArknightsResources.Operators.Models
{
    /// <summary>
    /// 表示干员Spine动画相关信息的结构
    /// </summary>
    public readonly struct OperatorSpineInfo : IEquatable<OperatorSpineInfo>
    {
        /// <summary>
        /// Spine动画模型组类型
        /// </summary>
        public OperatorSpineModelSet ModelSet { get; }

        /// <summary>
        /// 干员图片代号
        /// </summary>
        public string ImageCodename { get; }

        /// <summary>
        /// 指示Spine动画的类型是否为干员皮肤
        /// </summary>
        public bool IsSkin { get; }

        /// <summary>
        /// 构造<see cref="OperatorSpineInfo"/>的新实例
        /// </summary>
        /// <param name="modelSet">Spine动画模型组类型</param>
        /// <param name="imageCodename">干员图片代号</param>
        /// <param name="isSkin">指示Spine动画的类型是否为皮肤</param>
        public OperatorSpineInfo(OperatorSpineModelSet modelSet, string imageCodename, bool isSkin)
        {
            ModelSet = modelSet;
            ImageCodename = imageCodename;
            IsSkin = isSkin;
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            return obj is OperatorSpineInfo info && Equals(info);
        }

        /// <inheritdoc/>
        public bool Equals(OperatorSpineInfo other)
        {
            return ModelSet == other.ModelSet &&
                   ImageCodename == other.ImageCodename &&
                   IsSkin == other.IsSkin;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 983952918;
            hashCode = hashCode * -1521134295 + ModelSet.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ImageCodename);
            hashCode = hashCode * -1521134295 + IsSkin.GetHashCode();
            return hashCode;
        }

        /// <inheritdoc/>
        public static bool operator ==(OperatorSpineInfo left, OperatorSpineInfo right)
        {
            return left.Equals(right);
        }

        /// <inheritdoc/>
        public static bool operator !=(OperatorSpineInfo left, OperatorSpineInfo right)
        {
            return !(left == right);
        }
    }
}
