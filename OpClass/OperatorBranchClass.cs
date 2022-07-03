using System.Xml.Serialization;

namespace ArknightsResources.Operators.Models
{
    /// <summary>
    /// 表示干员的分支职业
    /// </summary>
    public enum OperatorBranchClass
    {
        #region Vanguard
        /// <summary>
        /// 先锋-尖兵
        /// </summary>
        Pioneer,
        /// <summary>
        /// 先锋-冲锋手
        /// </summary>
        Charger,
        /// <summary>
        /// 先锋-战术家
        /// </summary>
        Tactician,
        /// <summary>
        /// 先锋-执旗手
        /// </summary>
        StandardBearer,
        #endregion

        #region Sniper
        /// <summary>
        /// 狙击-速射手
        /// </summary>
        Marksman,
        /// <summary>
        /// 狙击-重射手
        /// </summary>
        HeavyShooter,
        /// <summary>
        /// 狙击-炮手
        /// </summary>
        Artilleryman,
        /// <summary>
        /// 狙击-神射手
        /// </summary>
        Deadeye,
        /// <summary>
        /// 狙击-散射手
        /// </summary>
        Spreadshooter,
        /// <summary>
        /// 狙击-攻城手
        /// </summary>
        Besieger,
        /// <summary>
        /// 狙击-投掷手
        /// </summary>
        Flinger,
        #endregion

        #region Guard
        /// <summary>
        /// 近卫-强攻手
        /// </summary>
        Centurion,
        /// <summary>
        /// 近卫-斗士
        /// </summary>
        Fighter,
        /// <summary>
        /// 近卫-术战者
        /// </summary>
        ArtsFighter,
        /// <summary>
        /// 近卫-教官
        /// </summary>
        Instructor,
        /// <summary>
        /// 近卫-领主
        /// </summary>
        Lord,
        /// <summary>
        /// 近卫-剑豪
        /// </summary>
        Swordmaster,
        /// <summary>
        /// 近卫-武者
        /// </summary>
        Musha,
        /// <summary>
        /// 近卫-无畏者
        /// </summary>
        Dreadnought,
        /// <summary>
        /// 近卫-收割者
        /// </summary>
        Reaper,
        /// <summary>
        /// 近卫-解放者
        /// </summary>
        Liberator,
        #endregion

        #region Caster
        /// <summary>
        /// 术师-中坚术师
        /// </summary>
        CoreCaster,
        /// <summary>
        /// 术师-扩散术师
        /// </summary>
        SplashCaster,
        /// <summary>
        /// 术师-轰击术师
        /// </summary>
        BlastCaster,
        /// <summary>
        /// 术师-链术师
        /// </summary>
        ChainCaster,
        /// <summary>
        /// 术师-阵法术师
        /// </summary>
        PhalanxCaster,
        /// <summary>
        /// 术师-秘术师
        /// </summary>
        MysticCaster,
        /// <summary>
        /// 术师-驭械术师
        /// </summary>
        MechAccordCaster,
        #endregion

        #region Defender
        /// <summary>
        /// 重装-铁卫
        /// </summary>
        Protector,
        /// <summary>
        /// 重装-守护者
        /// </summary>
        Guardian,
        /// <summary>
        /// 重装-不屈者
        /// </summary>
        Juggernaut,
        /// <summary>
        /// 重装-驭法铁卫
        /// </summary>
        ArtsProtector,
        /// <summary>
        /// 重装-决战者
        /// </summary>
        Duelist,
        /// <summary>
        /// 重装-要塞
        /// </summary>
        Fortress,
        #endregion

        #region Medic
        /// <summary>
        /// 医疗-医师
        /// </summary>
        Medic,
        /// <summary>
        /// 医疗-群愈师
        /// </summary>
        MultiTargetMedic,
        /// <summary>
        /// 医疗-疗养师
        /// </summary>
        Therapist,
        /// <summary>
        /// 医疗-行医
        /// </summary>
        WanderingMedic,
        /// <summary>
        /// 医疗-咒愈师
        /// </summary>
        IncantationMedic,
        #endregion

        #region Specialist
        /// <summary>
        /// 特种-处决者	
        /// </summary>
        Executor,
        /// <summary>
        /// 特种-陷阱师
        /// </summary>
        Trapmaster,
        /// <summary>
        /// 特种-钩索师
        /// </summary>
        Hookmaster,
        /// <summary>
        /// 特种-推击手
        /// </summary>
        PushStroker,
        /// <summary>
        /// 特种-伏击客
        /// </summary>
        Ambusher,
        /// <summary>
        /// 特种-行商
        /// </summary>
        Merchant,
        /// <summary>
        /// 特种-傀儡师	
        /// </summary>
        Dollkeeper,
        /// <summary>
        /// 特种-怪杰
        /// </summary>
        SacrificialSpecialist,
        #endregion

        #region Supporter
        /// <summary>
        /// 辅助-凝滞师
        /// </summary>
        DecelBinder,
        /// <summary>
        /// 辅助-削弱者
        /// </summary>
        Hexer,
        /// <summary>
        /// 辅助-吟游者
        /// </summary>
        Bard,
        /// <summary>
        /// 辅助-护佑者
        /// </summary>
        Abjurer,
        /// <summary>
        /// 辅助-召唤师
        /// </summary>
        Summoner,
        /// <summary>
        /// 辅助-工匠
        /// </summary>
        Artificer
        #endregion
    }
}
