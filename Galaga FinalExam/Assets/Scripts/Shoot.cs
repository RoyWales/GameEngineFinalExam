using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform BulletSpawn;

    public GameObject Bullet;

    public float nextFire = 1.0f;
    public float currentTime = 0.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        BulletSpawn = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Fire();
    }

    public void Fire()
    {
        currentTime += Time.deltaTime;

        if(Input.GetKeyDown("space") && currentTime > nextFire)
        {
            nextFire += currentTime;

            Instantiate(Bullet, BulletSpawn.position, Quaternion.identity);

            nextFire -= currentTime;
            currentTime = 0.0f;
        }
    }
}
