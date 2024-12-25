namespace dota_mentor.Interfaces;

public interface IHero
{
    double Id { get; set; }
    string Name { get; set; }
    string LocalizedName { get; set; }
    string PrimaryAttr { get; set; }
    string AttackType { get; set; }
    string[] Roles { get; set; }
    string Img { get; set; }
    string Icon { get; set; }
    double BaseHealth { get; set; }
    double BaseHealthRegen { get; set; }
    double BaseMana { get; set; }
    double BaseManaRegen { get; set; }
    double BaseArmor { get; set; }
    double BaseMr { get; set; }
    double BaseAttackMin { get; set; }
    double BaseAttackMax  { get; set; }
    double BaseStr { get; set; }
    double BaseAgi { get; set; }
    double BaseInt { get; set; }
    double StrGain { get; set; }
    double AgiGain { get; set; }
    double IntGain { get; set; }
    double AttachRange { get; set; }
    double ProjectileSpeed { get; set; }
    double AttackRate { get; set; }
    double BaseAttackTime { get; set; }
    double AttackPoint { get; set; }
    double MoveSpeed { get; set; }
    double TurnRate { get; set; }
    bool CmEnabled { get; set; }
    double Legs { get; set; }
    double DayVision { get; set; }
    double NightVision { get; set; }
    double TurboPicks { get; set; }
    double TurboWins { get; set; }
    double ProBan { get; set; }
    double ProWins { get; set; }
    double ProPick { get; set; }
}



