using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move 
{
    
    public MoveBase Base { get; set; }
    public int Times { get; set; }

    public Move(MoveBase eBase)
    {
        Base = eBase;
        Times = eBase.Times;
    }
}
