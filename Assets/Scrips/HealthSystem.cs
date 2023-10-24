using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthSystem : MonoBehaviour
{
    [SerializeField]
    int life;
    
    void Update()
    {
        if (life <= 0)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene(3);
        }
    }
}
