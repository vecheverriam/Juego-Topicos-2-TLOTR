using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum GameEstado { Mapa, Batalla}

public class GameControl : MonoBehaviour
{
    GameEstado estado;

    private void Update()
    {
        if (estado == GameEstado.Mapa)
        {

        }
    }
}
