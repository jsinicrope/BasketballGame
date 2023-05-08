using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private float min = 0f;
    private float max = 0f;
    public float dist = 5f;
    public bool canMoveX = false;
    public bool canMoveY = false;
    public bool canMoveZ = true;
    // Start is called before the first frame update
    void Start()
    {
        //min = transform.position.z;
        //max = transform.position.z + dist;
        if (canMoveX == true)
        {
            min = transform.position.x;
            max = transform.position.x + dist;
        }

        if (canMoveY == true)
        {
            min = transform.position.y;
            max = transform.position.y + dist;
        }

        if (canMoveZ == true)
        {
            min = transform.position.z;
            max = transform.position.z + dist;
        }

    }

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.PingPong(Time.time * 2, max - min) + min);
        if (canMoveX == true)
        {
            xMovement();
        }

        if (canMoveY == true)
        {
            yMovement();
        }

        if (canMoveZ == true)
        {
            zMovement();
        }


    }

    void xMovement()
    {

        transform.position = new Vector3(Mathf.PingPong(Time.time * 2, max - min) + min, transform.position.y, transform.position.z); 
        
    }

    void yMovement()
    {

        transform.position = new Vector3(transform.position.x, Mathf.PingPong(Time.time * 2, max - min) + min, transform.position.z);
        
    }


    void zMovement()
    {
        
        transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.PingPong(Time.time * 2, max - min) + min);
        
    }
}
