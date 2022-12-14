using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ArknightsResources.Operators.Models
{
    /// <summary>
    /// 表示干员配音信息的结构
    /// </summary>
    public readonly struct OperatorVoiceInfo : IEquatable<OperatorVoiceInfo>
    {
        /// <summary>
        /// 初始化<see cref="OperatorVoiceInfo"/>结构的新实例
        /// </summary>
        /// <param name="voice">配音人员</param>
        /// <param name="type">配音的语言种类</param>
        [JsonConstructor]
        public OperatorVoiceInfo(string voice, OperatorVocalType type)
        {
            Voice = voice;
            Type = type;
        }

        /// <summary>
        /// 干员配音人员
        /// </summary>
        public string Voice { get; }

        /// <summary>
        /// 干员配音的语言种类
        /// </summary>
        public OperatorVocalType Type { get; }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            return obj is OperatorVoiceInfo info && Equals(info);
        }

        /// <inheritdoc/>
        public bool Equals(OperatorVoiceInfo other)
        {
            return Voice == other.Voice &&
                   Type == other.Type;
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = 291305966;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Voice);
            hashCode = hashCode * -1521134295 + Type.GetHashCode();
            return hashCode;
        }

        /// <inheritdoc/>
        public static bool operator ==(OperatorVoiceInfo left, OperatorVoiceInfo right)
        {
            return left.Equals(right);
        }

        /// <inheritdoc/>
        public static bool operator !=(OperatorVoiceInfo left, OperatorVoiceInfo right)
        {
            return !(left == right);
        }
    }
}
