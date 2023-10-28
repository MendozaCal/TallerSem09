using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{
    public int life;
    public Slider slidervida;
    Damage damage;
    void Start()
    {
        slidervida.maxValue = life;
        slidervida.value = slidervida.maxValue;
        damage = GetComponent<Damage>();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyUp") || collision.gameObject.CompareTag("Enemyright") || collision.gameObject.CompareTag("BulletEnemy"))
        {
            RecibirDaño(collision.gameObject.GetComponent<Damage>().GetDamage());
        }
    }
    private void RecibirDaño(int value)
    {
        life -= value;
        if (life <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene(3);
        }
    }
}
