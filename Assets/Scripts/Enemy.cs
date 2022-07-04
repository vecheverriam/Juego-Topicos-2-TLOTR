using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy //stats de todos no solo enemigos
{
    public EnemyBase Base { get; set; } //se llamaba _base antes en caso de error
    public int Level { get; set; } // se llamaba level antes en caso de error

    public int CurrentHp { get; set; }
    public List<Move> Moves { get; set; }
    public Enemy(EnemyBase eBase, int eLevel)
    {
        Base = eBase;
        Level = eLevel;
        CurrentHp = Hp; //aca creo que debo borrar Base y dejar solo HP

        //Esto genera los ataques de los personajes de acuerdo al nivel que tengan.
        Moves = new List<Move>();
        foreach (var move in Base.LearnMoves)
        {
            if (move.Level <= Level)
                Moves.Add(new Move(move.Base));

            if (Moves.Count >= 6)
                break;
        }
    }

    public int Dmg
    {
        get { return Mathf.FloorToInt((Base.Dmg * Level) / 100f) + 5; }
    }

    public int Defense
    {
        get { return Mathf.FloorToInt((Base.Defense * Level) / 100f) + 5; }
    }

    public int Hp
    {
        get { return Mathf.FloorToInt((Base.Hp * Level) / 100f) + 10; }
    }

    public int Energy
    {
        get { return Mathf.FloorToInt((Base.Energy * Level) / 100f) + 5; }
    }
}
