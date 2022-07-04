using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BattleHud : MonoBehaviour
{
    [SerializeField] Text nameText;
    [SerializeField] HPHud hpHud;

    public void SetData(Enemy enemy)
    {
        nameText.text = enemy.Base.Name;
        hpHud.SetHP((float)enemy.CurrentHp / enemy.Hp);
    }

}
