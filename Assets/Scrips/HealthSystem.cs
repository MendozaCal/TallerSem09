using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    
    public int life;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyUp") || collision.gameObject.CompareTag("Enemyright") || collision.gameObject.CompareTag("BulletEnemy"))
        {
            RecibirDaņo(collision.gameObject.GetComponent<Damage>().GetDamage());
        }
    }

    private void RecibirDaņo(int value)
    {   
        life -= value;
        if (life <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(3);
        }
    }
}
