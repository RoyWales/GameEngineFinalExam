using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MoveBullets : MonoBehaviour
{

    public Rigidbody2D Bullet;

    public float MoveSpeed = 10.0f;

   


    void Start()
    {
        Bullet = this.gameObject.GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        Bullet.velocity = new Vector2(0, 1) * MoveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Enemy")
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("Win");
        }
        if (collision.gameObject.name == "top")
        {
            Destroy(this.gameObject);
        }
    }
}
