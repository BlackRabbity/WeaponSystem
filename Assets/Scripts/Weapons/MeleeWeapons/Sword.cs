using UnityEngine;

namespace Weapons
{
    [CreateAssetMenu(fileName = "NewSword", menuName = "Weapons/Sword")]
    public class Sword : MeleeWeapon
    {
        void Awake()
        {
            weaponName = "Sword";
            damage = 25;
            damageType = DamageType.Slashing;
        }
    }
}
