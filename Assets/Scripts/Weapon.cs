using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Weapon : ScriptableObject
{
    public string weaponName;
    public enum WeaponType
    {
        MELEE,
        ONE_HANDED,
        TWO_HANDED
    }
}
