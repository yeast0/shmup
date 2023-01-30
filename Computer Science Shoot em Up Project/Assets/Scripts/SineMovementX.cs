using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineMovementX : MonoBehaviour
{

    float sinCenterX;
    public float amplitude = 0.5f;
    public float frequency = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        sinCenterX = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        float sin = Mathf.Sin(pos.y * frequency) * amplitude;
        pos.x = sinCenterX + sin;
        // uses sine waves to create a movement pattern

        transform.position = pos;
    }
}
