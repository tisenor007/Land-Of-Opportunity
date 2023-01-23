using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Weapon : ScriptableObject
{
    public enum AmmoType
    {
        FORTY_FIVE,
        FORTY_FOUR
    }
    public enum WeaponType
    {
        MELEE,
        ONE_HANDED,
        TWO_HANDED
    }
    public string weaponName;
    public WeaponType weaponType;
    public AmmoType ammoType;
    public float attackRate; //fire rate or use rate (for melee weapons) 
    public float damage;
    public float condition;
    public GameObject bulletType;
}
