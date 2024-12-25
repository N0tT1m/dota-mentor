using dota_mentor.Interfaces;

namespace dota_mentor.Services;

public class Hero : IHero
{
    public Hero(string name, string localizedName, string primaryAttr, string attackType, string[] roles, string img, string icon)
    {
        Name = name;
        LocalizedName = localizedName;
        PrimaryAttr = primaryAttr;
        AttackType = attackType;
        Roles = roles;
        Img = img;
        Icon = icon;
    }

    public double Id { get; set; }
    public string Name { get; set; }
    public string LocalizedName { get; set; }
    public string PrimaryAttr { get; set; }
    public string AttackType { get; set; }
    public string[] Roles { get; set; }
    public string Img { get; set; }
    public string Icon { get; set; }
    public double BaseHealth { get; set; }
    public double BaseHealthRegen { get; set; }
    public double BaseMana { get; set; }
    public double BaseManaRegen { get; set; }
    public double BaseArmor { get; set; }
    public double BaseMr { get; set; }
    public double BaseAttackMin { get; set; }
    public double BaseAttackMax { get; set; }
    public double BaseStr { get; set; }
    public double BaseAgi { get; set; }
    public double BaseInt { get; set; }
    public double StrGain { get; set; }
    public double AgiGain { get; set; }
    public double IntGain { get; set; }
    public double AttachRange { get; set; }
    public double ProjectileSpeed { get; set; }
    public double AttackRate { get; set; }
    public double BaseAttackTime { get; set; }
    public double AttackPoint { get; set; }
    public double MoveSpeed { get; set; }
    public double TurnRate { get; set; }
    public bool CmEnabled { get; set; }
    public double Legs { get; set; }
    public double DayVision { get; set; }
    public double NightVision { get; set; }
    public double TurboPicks { get; set; }
    public double TurboWins { get; set; }
    public double ProBan { get; set; }
    public double ProWins { get; set; }
    public double ProPick { get; set; }
}