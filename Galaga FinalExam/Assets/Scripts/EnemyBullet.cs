using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyBullet : MonoBehaviour
{

    public Rigidbody2D Bullet;

    public float MoveSpeed = 8.0f;




    void Start()
    {
        Bullet = this.gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Bullet.velocity = new Vector2(0, -1) * MoveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("Dead");
        }

        if (collision.gameObject.name == "bottom")
        {
            Destroy(this.gameObject);
        }
    }
}
