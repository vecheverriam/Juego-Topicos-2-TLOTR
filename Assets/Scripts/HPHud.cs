using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPHud : MonoBehaviour
{
    [SerializeField] GameObject health;

    public void SetHP(float hpNormalized)
    {
        health.transform.localScale = new Vector3(hpNormalized, 1f);
    }
}
