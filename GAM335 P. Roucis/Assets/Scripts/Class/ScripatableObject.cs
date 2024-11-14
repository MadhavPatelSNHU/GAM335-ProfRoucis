using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Sword", menuName = "Scriptable Objects/Sword")]
public class Sword : ScriptableObject
{
    public string Name;
    public Sprite Icon;
    public int MaxStacks;
}
[CreateAssetMenu(fileName = "Rubble", menuName = "Scriptable Objects/Rubble")]
public class Rubble : ScriptableObject
{
    public string Name;
    public Sprite Icon;
    public int MaxStacks;
}
