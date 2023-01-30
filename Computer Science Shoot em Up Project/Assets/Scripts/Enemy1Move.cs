using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Move : MonoBehaviour
{
    public float MOVspeed = 1;
    // enemy movement speed


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        pos.y -= MOVspeed * Time.fixedDeltaTime;
        // postition is minus movespeed times deltatime

        transform.position = pos;
        // transform by pos
    }
}
