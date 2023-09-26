using UnityEngine;
using UnityEngine.UI;
using Weapons;

public class PlayerHUD : MonoBehaviour
{
    public Text ActiveWeapon;

    public void UpdateWeaponUI(Weapon weapon)
    {
        ActiveWeapon.text = weapon.weaponName;
    }
}
