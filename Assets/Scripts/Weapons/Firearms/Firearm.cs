using UnityEngine;

namespace Weapons
{
    public class Firearm : Weapon
    {
        public float fireRate;
        public int magazineSize;
        public override void Attack()
        {
            Debug.Log("pew pew");
        }

        public override void SpecialAction()
        {
            //reload
            Debug.Log("Reload");
        }
    }
}
