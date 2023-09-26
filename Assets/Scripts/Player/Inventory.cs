using UnityEngine;
using Weapons;

public class Inventory : MonoBehaviour
{
    public Weapon[] weapons;
    public Weapon activeWeapon;
    public PlayerHUD playerHUD;

    int weaponID;

    void Start()
    {
        Knife knifeInstance = ScriptableObject.CreateInstance<Knife>();
        Sword swordInstance = ScriptableObject.CreateInstance<Sword>();
        Pistol pistolInstance = ScriptableObject.CreateInstance<Pistol>();
        Shotgun shotgunInstance = ScriptableObject.CreateInstance<Shotgun>();

        weapons = new Weapon[] {knifeInstance, pistolInstance, swordInstance, shotgunInstance};
        weaponID = 0;
        activeWeapon = weapons[weaponID];
        playerHUD.ActiveWeapon.text = activeWeapon.weaponName;
    }

    public void SwitchWeapon()
    {
        if (weaponID+1 < weapons.Length)
        {
            weaponID++;
            activeWeapon = weapons[weaponID];
        }
        else
        {
            weaponID = 0;
            activeWeapon = weapons[weaponID];
        }
        playerHUD.UpdateWeaponUI(activeWeapon);
    }

}
