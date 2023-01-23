using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipmentBelt : MonoBehaviour
{
    public enum EquipmentSlotID
    {
        HOLSTER_ONE,
        HOLSTER_TWO,
        BACK_ONE,
        BACK_TWO,
        MELEE
    }
    public Transform holsterSheath1Loc;
    public Transform holsterSheath2Loc;
    public Transform backSheath1Loc;
    public Transform backSheath2Loc;
    public Transform meleeSheathLoc;

    public GameObject holsterWeapon1;
    public GameObject holsterWeapon2;
    public GameObject backWeapon1;
    public GameObject backWeapon2;
    public GameObject meleeWeapon;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EquipEquipment (GameObject weaponObject, EquipmentSlotID weaponSlotID)
    {
        if (!weaponObject.GetComponent<WeaponObject>()) { return; }//makes sure object is a weapon

        switch (weaponSlotID)
        {
            case EquipmentSlotID.HOLSTER_ONE:
                holsterWeapon1 = Instantiate(weaponObject, holsterSheath1Loc, false);
                break;
            case EquipmentSlotID.HOLSTER_TWO:
                holsterWeapon2 = Instantiate(weaponObject, holsterSheath2Loc, false);
                break;
            case EquipmentSlotID.BACK_ONE:
                backWeapon1 = Instantiate(weaponObject, backSheath1Loc, false);
                break;
            case EquipmentSlotID.BACK_TWO:
                backWeapon2 = Instantiate(weaponObject, backSheath2Loc, false);
                break;
            case EquipmentSlotID.MELEE:
                meleeWeapon = Instantiate(weaponObject, meleeSheathLoc, false);
                break;
        }
    }
}
