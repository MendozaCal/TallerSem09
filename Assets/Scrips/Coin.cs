using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] int points;
    [SerializeField] Puntaje puntaje;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            puntaje.MorePoints(points);
            Destroy(this.gameObject);
        }
    }
}
