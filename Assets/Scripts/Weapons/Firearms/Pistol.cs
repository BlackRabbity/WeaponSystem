using UnityEngine;

namespace Weapons
{
    [CreateAssetMenu(fileName = "NewPistol", menuName = "Weapons/Pistol")]
    public class Pistol : Firearm
    {
        void Awake()
        {
            weaponName = "Pistol";
            damage = 40;
            fireRate = 1.0f;
            magazineSize = 7;
        }
    }
}
