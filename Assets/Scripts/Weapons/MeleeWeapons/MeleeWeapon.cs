using UnityEngine;

namespace Weapons
{
    public class MeleeWeapon : Weapon
    {
        public DamageType damageType;
        public override void Attack()
        {
            Debug.Log("shhh shhh");
        }
        public override void SpecialAction()
        {
            // do nothing
        }
    }
}