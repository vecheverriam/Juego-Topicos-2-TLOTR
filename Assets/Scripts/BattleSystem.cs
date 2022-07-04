using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum BattleEstado
{
    Start,
    PlayerAction,
    PlayerMove,
    EnemyMove, 
    Busy,
}

public class BattleSystem : MonoBehaviour
{
    [SerializeField] BattleCharacter playerUnit;
    [SerializeField] BattleCharacter badUnit;
    [SerializeField] BattleHud playerHud;
    [SerializeField] BattleHud badHud;
    [SerializeField] BattleDialogBox dialogBox;

    BattleEstado estado;
    int currentAction;


    private void Start()
    {
        StartCoroutine(SetupBattle());
    }

    public IEnumerator SetupBattle()
    {
        playerUnit.Setup();
        badUnit.Setup();
        playerHud.SetData(playerUnit.enemy);
        badHud.SetData(badUnit.enemy);

        yield return dialogBox.TypeDialog($"An {badUnit.enemy.Base.Name} appeared.");
    }

    void PlayerAction()
    {
        estado = BattleEstado.PlayerAction;
        StartCoroutine(dialogBox.TypeDialog("Chose Attack or run"));
        dialogBox.EnableActionSelection(true);
    }

    private void Update()
    {
        if(estado == BattleEstado.PlayerAction)
        {
            HandleActionSelection();
        }
    }

    void HandleActionSelection()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))//aca esta el error por el input system
        {
            if (currentAction < 1)
                ++currentAction;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (currentAction > 0)
                --currentAction;
        }

        dialogBox.UpdateActionSelection(currentAction);

    }

    
}
