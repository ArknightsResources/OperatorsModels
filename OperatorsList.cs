using System.Collections.Generic;

namespace ArknightsResources.Operators.Models
{
    /// <summary>
    /// 干员列表
    /// </summary>
    public sealed class OperatorsList
    {
        /// <summary>
        /// 包含<see cref="Operator"/>对象的字典
        /// </summary>
        public Dictionary<string, Operator> Operators { get; set; }

        /// <summary>
        /// 使用干员图像代号获取指定的干员
        /// </summary>
        /// <param name="imageCodename">干员图像代号</param>
        /// <returns>一个<see cref="Operator"/>对象,如果找不到干员,则返回null</returns>
        public Operator GetOperatorWithImageCodename(string imageCodename)
        {
            return Operators.ContainsKey(imageCodename) ? Operators[imageCodename] : null;
        }

        /// <summary>
        /// 使用干员名称获取指定的干员
        /// </summary>
        /// <param name="name">干员代号</param>
        /// <returns>一个<see cref="Operator"/>对象,如果找不到干员,则返回null</returns>
        public Operator GetOperatorWithName(string name)
        {
            foreach (var item in Operators)
            {
                if (item.Value.Name == name)
                {
                    return item.Value;
                }
            }
            return null;
        }

        /// <summary>
        /// 将当前的OperatorList转换为其数组形式
        /// </summary>
        /// <returns>包含<see cref="Operator"/>对象的数组</returns>
        public Operator[] ToArray()
        {
            List<Operator> list = new List<Operator>(Operators.Count);
            foreach (var item in list)
            {
                list.Add(item);
            }
            return list.ToArray();
        }
    }
}
