using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Enemigo/Create new move")]
public class MoveBase : ScriptableObject
{
    [SerializeField] string name;


    [SerializeField] EffectType efecto;
    [SerializeField] int power;
    [SerializeField] int accuracy;
    [SerializeField] int times; //veces que puede efectuar golpe

    public string Name
    {
        get
        {
            return name;
        }
    }

    public EffectType Efecto
    {
        get
        {
            return efecto;
        }
    }

    public int Power
    {
        get
        {
            return power;
        }
    }

    public int Accuracy
    {
        get
        {
            return accuracy;
        }
    }

    public int Times
    {
        get
        {
            return times;
        }
    }
}
