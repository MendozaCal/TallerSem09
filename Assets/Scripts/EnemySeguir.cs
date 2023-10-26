using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySeguir : MonoBehaviour
{
    [SerializeField] private GameObject player;
    private float dISTANCEjUGADOR;
    [SerializeField] private float sPEED;
    void Update()
    {
        dISTANCEjUGADOR = Vector2.Distance(transform.position, player.transform.position);
        if ((dISTANCEjUGADOR < 4) && gameObject.CompareTag("EnemyUp"))
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, sPEED * Time.deltaTime);

        }
    }
}
