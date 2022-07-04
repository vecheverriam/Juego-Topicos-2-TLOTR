using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleCharacter : MonoBehaviour
{
    [SerializeField] EnemyBase _base;
    [SerializeField] int level;
    [SerializeField] bool isPlayerCharacter;

    public Enemy enemy { get; set; }//unit antes se llamaba enemy

    public void Setup()
    {
        enemy = new Enemy(_base, level);
        if (isPlayerCharacter)
            GetComponent<Image>().sprite = enemy.Base.FrontSprite;
        else
            GetComponent<Image>().sprite = enemy.Base.AttackSprite;
            
    }
}
