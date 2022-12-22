﻿using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;

namespace ArknightsResources.Operators.Models
{
    /// <summary>
    /// 干员列表
    /// </summary>
    public sealed class OperatorsList : IEnumerable<Operator>
    {
        /// <summary>
        /// 包含<see cref="Operator"/>对象的字典
        /// </summary>
        private Dictionary<string, Operator> Operators { get; set; }

        /// <summary>
        /// 构造<see cref="OperatorsList"/>的新实例
        /// </summary>
        /// <param name="operators">包含<see cref="Operator"/>对象的字典</param>
        [JsonConstructor]
        public OperatorsList(Dictionary<string, Operator> operators)
        {
            Operators = operators;
        }

        /// <summary>
        /// 构造<see cref="OperatorsList"/>的新实例
        /// </summary>
        /// <param name="operators">包含<see cref="Operator"/>对象的<see cref="IEnumerable{T}"/></param>
        public OperatorsList(IEnumerable<Operator> operators)
        {
            int capacity = operators is ICollection<Operator> ops ? ops.Count : operators.Count();
            Operators = new Dictionary<string, Operator>(capacity);
            foreach (Operator item in operators)
            {
                Operators[item.Codename] = item;
            }
        }

        /// <summary>
        /// 通过干员代号获取指定的干员
        /// </summary>
        /// <param name="codename">干员代号</param>
        /// <returns>一个<see cref="Operator"/>对象,如果找不到干员,则返回null</returns>
        public Operator this[string codename] => Operators.TryGetValue(codename, out Operator value)? value : null;

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

        /// <inheritdoc/>
        public IEnumerator<Operator> GetEnumerator()
        {
            return Operators.Values.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return Operators.Values.GetEnumerator();
        }
    }
}
