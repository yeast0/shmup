using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectile : MonoBehaviour
{
    public Vector2 direction = new Vector2(0, 1); 
    public int speed = 8;
    // projectile speed

    public Vector2 velocity;
    public bool isEnemy = true;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 3);
        // destroy projectile after 3 seconds
    }

    // Update is called once per frame
    void Update()
    {
        velocity = direction * speed;
        // velocity is direction times speed
    }


    void FixedUpdate()
    {
        Vector2 pos = transform.position;

        pos += velocity * Time.fixedDeltaTime;

        transform.position = pos;
        //make position new position
    }
}
