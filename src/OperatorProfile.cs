using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ArknightsResources.Operators.Models
{
    /// <summary>
    /// 表示干员档案的结构
    /// </summary>
    public readonly struct OperatorProfile : IEquatable<OperatorProfile>
    {
        /// <summary>
        /// 初始化<see cref="OperatorProfile"/>结构的新实例
        /// </summary>
        /// <param name="profile">档案内容</param>
        /// <param name="type">档案类型</param>
        [JsonConstructor]
        public OperatorProfile(string profile, OperatorProfileType type)
        {
            Profile = profile ?? throw new ArgumentNullException(nameof(profile));
            Type = type;
        }

        /// <summary>
        /// 该档案的类型
        /// </summary>
        public OperatorProfileType Type { get; }

        /// <summary>
        /// 该档案的内容
        /// </summary>
        [JsonPropertyName("Text")]
        public string Profile { get; }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            return obj is OperatorProfile profile && Equals(profile);
        }

        /// <inheritdoc/>
        public bool Equals(OperatorProfile other)
        {
            return Type == other.Type && Profile == other.Profile;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 1195033859;
            hashCode = hashCode * -1521134295 + Type.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Profile);
            return hashCode;
        }

        /// <inheritdoc/>
        public static bool operator ==(OperatorProfile left, OperatorProfile right)
        {
            return left.Equals(right);
        }

        /// <inheritdoc/>
        public static bool operator !=(OperatorProfile left, OperatorProfile right)
        {
            return !(left == right);
        }
    }
}
