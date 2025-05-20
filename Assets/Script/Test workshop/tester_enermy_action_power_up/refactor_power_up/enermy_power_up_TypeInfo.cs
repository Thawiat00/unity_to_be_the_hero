using UnityEngine;

public class enermy_power_up_TypeInfo : ScriptableObject
{
    // Class that represents a specific type of hp,attack
    [Range(100f, 1000f)]
    public float m_MaxHP = 100f;

    [Range(1f, 1000f)]
    public float m_default_attack = 10f;

    [Range(1f, 100f)]
    public float increate_power_up_hp = 10f;


    [Range(1f, 100f)]
    public float increate_power_up_attack = 10f;

    // This class could have many other vehicle parameters, such as Turning Radius, Range, Damage etc



}
