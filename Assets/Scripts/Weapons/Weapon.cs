using UnityEngine;

namespace Weapons
{
    public abstract class Weapon : ScriptableObject
    {
        public string weaponName;
        public int damage;

        public abstract void Attack();
        public abstract void SpecialAction();
    }
}
