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

    void Update()
    {
        Timer();
        Shoot();


    }
    void Timer()
    {
        shootTimer += Time.deltaTime;
    }
    void Shoot()
    {
        if (gameObject.CompareTag("EnemyUp") && shootTimer >= shootDelayTime)
        {
            GameObject obj = Instantiate(bulletPrefab);
            obj.transform.position = transform.position;
            shootTimer = 0;
        }
    }
}
