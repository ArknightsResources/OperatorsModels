namespace ArknightsResources.Operators.Models
{
	/// <summary>
	/// 干员Spine动画类别的枚举
	/// </summary>
	public enum OperatorSpineAnimationType
	{
		/// <summary>
		/// 基建与战斗-默认
		/// </summary>
		Default,
		/// <summary>
		/// 基建-交互
		/// </summary>
		Interact,
		/// <summary>
		/// 基建-移动
		/// </summary>
		Move,
		/// <summary>
		/// 基建-休息
		/// </summary>
		Relax,
		/// <summary>
		/// 基建-坐下
		/// </summary>
		Sit,
		/// <summary>
		/// 基建-睡眠
		/// </summary>
		Sleep,
		/// <summary>
		/// 基建-特殊
		/// </summary>
		Special
	}

	/// <summary>
	/// 干员Spine动画模型组类型的枚举
	/// </summary>
	public enum OperatorSpineModelSet
	{
		/// <summary>
		/// 战斗正面
		/// </summary>
		CombatFront,
		/// <summary>
		/// 战斗背面
		/// </summary>
		CombatBack,
		/// <summary>
		/// 基建
		/// </summary>
		Build
	}
}
