using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    public int life;
    [SerializeField] VidaCanvas vidacanvas;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("EnemyUp") || collision.gameObject.CompareTag("Enemyright") || collision.gameObject.CompareTag("BulletEnemy"))
        {
            RecibirDa�o(collision.gameObject.GetComponent<Damage>().GetDamage());
        }
    }

    private void RecibirDa�o(int value)
    {
        life -= value;
        if (life <= 0)
        {
            vidacanvas.SeeLife(life);

            Destroy(gameObject);
            SceneManager.LoadScene(3);
        }
    }
}
