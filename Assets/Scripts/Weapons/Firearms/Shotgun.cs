using UnityEngine;

namespace Weapons
{
    [CreateAssetMenu(fileName = "NewShotgun", menuName = "Weapons/Shotgun")]
    public class Shotgun : Firearm
    {
        void Awake()
        {
            weaponName = "Shotgun";
            damage = 140;
            fireRate = 1.0f;
            magazineSize = 12;
        }
    }
}
