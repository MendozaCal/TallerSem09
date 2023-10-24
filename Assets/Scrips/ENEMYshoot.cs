using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENEMYshoot : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;
    private float shootTimer;
    [SerializeField]
    private float shootDelayTime;
    private HealthSystem healthSystem;
    private int vida;
    void Update()
    {
        healthSystem = GetComponent<HealthSystem>();
        vida = healthSystem.life;
        Timer();
        Shoot();


    }
    void Timer()
    {
        shootTimer += Time.deltaTime;
    }
    void Shoot()
    {
        if ((vida > 0) && shootTimer >= shootDelayTime)
        {
            GameObject obj = Instantiate(bulletPrefab);
            obj.transform.position = transform.position;
            shootTimer = 0;
        }
    }
}
