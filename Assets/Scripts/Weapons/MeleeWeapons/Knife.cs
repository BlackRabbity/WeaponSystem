using UnityEngine;

namespace Weapons
{
    [CreateAssetMenu(fileName = "NewKnife", menuName = "Weapons/Knife")]
    public class Knife : MeleeWeapon
    {
        void Awake()
        {
            weaponName = "Knife";
            damage = 15;
            damageType = DamageType.Piercing;
        }
    }
}
