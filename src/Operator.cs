﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text.Json.Serialization;

namespace ArknightsResources.Operators.Models
{
    /// <summary>
    /// 表示干员的结构
    /// </summary>
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public readonly struct Operator : IEquatable<Operator>
    {
        /// <summary>
        /// 使用指定的参数构造<see cref="Operator"/>的新实例
        /// </summary>
        /// <param name="name">干员名称</param>
        /// <param name="star">干员星级</param>
        /// <param name="codename">干员图像代号</param>
        /// <param name="gender">干员性别</param>
        /// <param name="birthday">干员生日</param>
        /// <param name="class">干员职业</param>
        /// <param name="illustrations">干员立绘信息</param>
        /// <param name="voices">干员配音信息</param>
        /// <param name="profiles">干员档案信息</param>
        [JsonConstructor]
        public Operator(string name, string codename, int star, OperatorGender gender, OperatorBirthday? birthday, OperatorClass @class, OperatorIllustrationInfo[] illustrations, OperatorVoiceInfo[] voices, OperatorProfile[] profiles)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Codename = codename ?? throw new ArgumentNullException(nameof(codename));
            Star = star;
            Gender = gender;
            Birthday = birthday;
            Class = @class;
            Illustrations = illustrations ?? throw new ArgumentNullException(nameof(illustrations));
            Voices = voices ?? throw new ArgumentNullException(nameof(voices));
            Profiles = profiles ?? throw new ArgumentNullException(nameof(profiles));
        }

        /// <summary>
        /// 干员名称
        /// </summary>
        public string Name { get; }

        /// <summary>
        /// 干员星级
        /// </summary>
        public int Star { get; }

        /// <summary>
        /// 干员内部代号
        /// </summary>
        public string Codename { get; }

        /// <summary>
        /// 干员性别
        /// </summary>
        public OperatorGender Gender { get; }

        /// <summary>
        /// 干员生日
        /// </summary>
        public OperatorBirthday? Birthday { get; }

        /// <summary>
        /// 干员职业
        /// </summary>
        public OperatorClass Class { get; }

        /// <summary>
        /// 干员的立绘信息
        /// </summary>
        public OperatorIllustrationInfo[] Illustrations { get; }

        /// <summary>
        /// 干员的配音信息
        /// </summary>
        public OperatorVoiceInfo[] Voices { get; }

        /// <summary>
        /// 干员档案
        /// </summary>
        public OperatorProfile[] Profiles { get; }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            return obj is Operator op && Equals(op);
        }

        /// <inheritdoc/>
        public bool Equals(Operator other)
        {
            return Name == other.Name &&
                   Star == other.Star &&
                   Codename == other.Codename &&
                   Gender == other.Gender &&
                   EqualityComparer<OperatorBirthday?>.Default.Equals(Birthday, other.Birthday) &&
                   EqualityComparer<OperatorClass>.Default.Equals(Class, other.Class) &&
                   Illustrations.SequenceEqual(other.Illustrations) &&
                   Voices.SequenceEqual(other.Voices) &&
                   Profiles.SequenceEqual(other.Profiles);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            int hashCode = -45877082;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Star.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Codename);
            hashCode = hashCode * -1521134295 + Gender.GetHashCode();
            hashCode = hashCode * -1521134295 + Birthday.GetHashCode();
            hashCode = hashCode * -1521134295 + Class.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<OperatorIllustrationInfo[]>.Default.GetHashCode(Illustrations);
            hashCode = hashCode * -1521134295 + EqualityComparer<OperatorVoiceInfo[]>.Default.GetHashCode(Voices);
            hashCode = hashCode * -1521134295 + EqualityComparer<OperatorProfile[]>.Default.GetHashCode(Profiles);
            return hashCode;
        }

        private string GetDebuggerDisplay() => Name;

        /// <inheritdoc/>
        public static bool operator ==(Operator left, Operator right)
        {
            return EqualityComparer<Operator>.Default.Equals(left, right);
        }

        /// <inheritdoc/>
        public static bool operator !=(Operator left, Operator right)
        {
            return !(left == right);
        }
    }
}
