using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{

    [SerializeField]
    private int Damagee;

    public int GetDamage()
    {
        return Damagee;
    }
}
