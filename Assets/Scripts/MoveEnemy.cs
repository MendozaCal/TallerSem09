using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Xml.Serialization;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{   
    [SerializeField] private float tIMERRmOVE;
    private bool Movceenmy = true;
    public float sPEED = 2f;
    public float Distancee = 20f;
    private Vector2 initialPoint;
    private Vector2 FinalPoint;
    private float timer;


    private void Start()
    {
        initialPoint = transform.position;
        Direccion();


    }

    private void Direccion()

    {

        if (gameObject.CompareTag("EnemyUp"))
        { FinalPoint = initialPoint + Vector2.down * Distancee; }

        if (gameObject.CompareTag("Enemyright"))
        { FinalPoint = initialPoint + Vector2.right * Distancee; }
    }

    private void Update()
    {
        Move();
        timer += Time.deltaTime;
    }

    private void Move()
    {

        if (Movceenmy)
        {
            if (timer >= tIMERRmOVE)
            {
                transform.position = Vector2.MoveTowards(transform.position, FinalPoint, sPEED * Time.deltaTime);
                if (Vector2.Distance(transform.position, FinalPoint) < 0.1f)
                {
                    Movceenmy = false;
                    timer = 0;
                }
               
            }
        }
        else
        {
            if (timer >= tIMERRmOVE)
            {
                transform.position = Vector2.MoveTowards(transform.position, initialPoint, sPEED * Time.deltaTime);
                if (Vector2.Distance(transform.position, initialPoint) < 0.1f)
                {
                    Movceenmy = true;
                    timer = 0;
                }
               
            }

        }
    }
}
