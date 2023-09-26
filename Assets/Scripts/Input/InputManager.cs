using UnityEngine;
using Weapons;

public class InputManager : MonoBehaviour
{
    public MouseLook mouseLook;
    public Inventory inventory;

    Controls controls;
    Vector2 mousePosition;

    void Awake()
    {
        controls = new Controls();
        controls.Player.LookX.performed += context => mousePosition.x = context.ReadValue<float>();
        controls.Player.LookY.performed += context => mousePosition.y = context.ReadValue<float>();
        controls.Player.WeaponSwitch.performed += context => inventory.SwitchWeapon();
        controls.Player.Attack.performed += context => inventory.activeWeapon.Attack();
        controls.Player.SpecialAction.performed += context => inventory.activeWeapon.SpecialAction();
    }

    void OnEnable()
    {
        controls.Enable();
    }

    void OnDisable()
    {
        controls.Disable();
    }

    void Update()
    {
        mouseLook.ReceiveInput(mousePosition);
    }


}
