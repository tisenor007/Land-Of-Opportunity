using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameCharacter : ScriptableObject
{
    //determines what the charater will be (including player)
    public enum CharBehavior
    {
        PLAYER,
        HOSTILE,
        NEUTRAL,
        FRIENDLY
    }
    public CharBehavior behavior;
    public float walkSpeed;
    public float sprintSpeed;
    protected string charName;
    protected string age;
    protected int health;
    //stats, model, animation controller continues

}
