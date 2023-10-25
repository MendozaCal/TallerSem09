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
        Vector2 direction = player.transform.position - transform.position;
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        if ((dISTANCEjUGADOR < 4) && gameObject.CompareTag("EnemyUp"))
        {
            transform.position = Vector2.MoveTowards(transform.position, player.transform.position, sPEED * Time.deltaTime);
            transform.rotation = Quaternion.Euler(Vector3.forward * angle);

        }
    }
}
