using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemigo", menuName = "Enemigo/Create new enemigo")]
public class EnemyBase : ScriptableObject
{
    [SerializeField] string name;//Estos son los stats de todos no solo los enemimgos

    [SerializeField] Sprite frontSprite;//sprite de inicio de pelea
    [SerializeField] Sprite attackSprite;//Sprite de combate enemigo

    //Atributos de enemigo
    [SerializeField] int hp;
    [SerializeField] int energy;
    [SerializeField] int dmg;
    [SerializeField] int dmgProb;
    [SerializeField] int defense;
    [SerializeField] int probEffect;

    [SerializeField] EffectType effect;

    [SerializeField] List<LearnMove> learnMoves;


    public string Name
    {
        get
        {
            return name;
        }
    }

    public Sprite FrontSprite
    {
        get
        {
            return frontSprite;
        }
    }

    public Sprite AttackSprite
    {
        get
        {
            return attackSprite;
        }
    }

    public int Hp
    {
        get
        {
            return hp;
        }
    }

    public int Energy
    {
        get
        {
            return energy;
        }
    }

    public int Dmg
    {
        get
        {
            return dmg;
        }
    }

    public int DmgProb
    {
        get
        {
            return dmgProb;
        }
    }

    public int Defense
    {
        get
        {
            return defense;
        }
    }

    public int ProbEffect
    {
        get
        {
            return probEffect;
        }
    }

    public EffectType Effect
    {
        get
        {
            return effect;
        }
    }

    public List<LearnMove> LearnMoves
    {
        get { return learnMoves; }
    }
}

[System.Serializable]

public class LearnMove
{
    [SerializeField] MoveBase moveBase;
    [SerializeField] int level;

    public MoveBase Base
    {
        get { return moveBase; }
    }

    public int Level
    {
        get { return level; }
    }
}
public enum EffectType
{
    None,
    Stun,
    Bleed,
    Debuff,
}
