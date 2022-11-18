using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Shooter[] shooter;

    Rigidbody2D rigidbody2d;
    float horizontal;
    float vertical;

    bool shoot;

    // Start is called before the first frame update
    void Start()
    {
        shooter = transform.GetComponentsInChildren<Shooter>();

        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        shoot = Input.GetKey(KeyCode.Z);
        if (shoot)
        {
            foreach(Shooter shoot in shooter)
            {
                shoot.Shoot();
            }
        }
    }

    void FixedUpdate()
    {
        Vector2 position = rigidbody2d.position;
        position.x = position.x + 3.0f * horizontal * Time.deltaTime;
        position.y = position.y + 3.0f * vertical * Time.deltaTime;

        rigidbody2d.MovePosition(position);
    }
}
