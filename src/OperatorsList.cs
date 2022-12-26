using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text.Json.Serialization;

namespace ArknightsResources.Operators.Models
{
    /// <summary>
    /// 干员列表
    /// </summary>
    public sealed class OperatorsList : IEquatable<OperatorsList>
    {
        /// <summary>
        /// 包含<see cref="Operator"/>对象的只读字典
        /// </summary>
        public ImmutableDictionary<string, Operator> Operators { get; }

        /// <summary>
        /// 构造<see cref="OperatorsList"/>的新实例
        /// </summary>
        /// <param name="operators">Key为干员代号,Value为<see cref="Operator"/>对象的IDictionary</param>
        public OperatorsList(IDictionary<string, Operator> operators)
        {
            Operators = operators.ToImmutableDictionary();
        }

        /// <summary>
        /// 构造<see cref="OperatorsList"/>的新实例
        /// </summary>
        /// <param name="operators">Key为干员代号,Value为<see cref="Operator"/>对象的不可变字典</param>
        [JsonConstructor]
        public OperatorsList(ImmutableDictionary<string, Operator> operators)
        {
            //For JSON serialization
            Operators = operators;
        }

        /// <summary>
        /// 构造<see cref="OperatorsList"/>的新实例
        /// </summary>
        /// <param name="operators">包含<see cref="Operator"/>对象的<see cref="IEnumerable{T}"/></param>
        public OperatorsList(IEnumerable<Operator> operators)
        {
            int capacity = operators is ICollection<Operator> ops ? ops.Count : operators.Count();
            Dictionary<string, Operator> dict = new Dictionary<string, Operator>(capacity);
            foreach (Operator item in operators)
            {
                dict[item.Codename] = item;
            }
            Operators = dict.ToImmutableDictionary();
        }

        /// <summary>
        /// 通过干员代号获取指定的干员
        /// </summary>
        /// <param name="codename">干员代号</param>
        /// <returns>一个<see cref="Operator"/>对象,如果找不到干员,则返回null</returns>
        public Operator this[string codename] => GetOperatorWithCodename(codename);

        /// <summary>
        /// 通过干员代号获取指定的干员
        /// </summary>
        /// <param name="codename">干员代号</param>
        /// <returns>一个<see cref="Operator"/>对象,如果找不到干员,则返回null</returns>
        public Operator GetOperatorWithCodename(string codename)
        {
            return Operators.TryGetValue(codename, out Operator value) ? value : null;
        }

        /// <summary>
        /// 使用干员名称获取指定的干员
        /// </summary>
        /// <param name="name">干员名称</param>
        /// <returns>一个<see cref="Operator"/>对象,如果找不到干员,则返回null</returns>
        public Operator GetOperator(string name)
        {
            foreach (var item in Operators.Where(item => item.Value.Name == name))
            {
                return item.Value;
            }

            return null;
        }

        /// <summary>
        /// 将当前的OperatorList转换为其数组形式
        /// </summary>
        /// <returns>包含<see cref="Operator"/>对象的数组</returns>
        public Operator[] ToArray()
        {
            Operator[] opArray = new Operator[Operators.Count];
            int index = 0;
            foreach (var item in Operators)
            {
                opArray[index] = item.Value;
                index++;
            }
            return opArray;
        }

        /// <summary>
        /// 获取<see cref="OperatorsList"/>的枚举器
        /// </summary>
        /// <returns><see cref="OperatorsList"/>的枚举器</returns>
        public IEnumerator<Operator> GetEnumerator()
        {
            //不实现IEnumerable接口的原因是:Json反序列化器如果发现类型实现了IEnumerable接口
            //则会将对象按集合的形式序列化与反序列化
            //这会破坏序列化兼容性
            //不过,即使不实现IEnumerable接口,只要有GetEnumerator方法,就可以在foreach中枚举
            return Operators.Values.GetEnumerator();
        }

        /// <inheritdoc/>
        public override bool Equals(object obj)
        {
            return Equals(obj as OperatorsList);
        }

        /// <inheritdoc/>
        public bool Equals(OperatorsList other)
        {
            return !(other is null) && Operators.SequenceEqual(other.Operators);
        }

        ///<inheritdoc/>
        public override int GetHashCode()
        {
            return 2017162682 + EqualityComparer<ImmutableDictionary<string, Operator>>.Default.GetHashCode(Operators);
        }
    }
}
