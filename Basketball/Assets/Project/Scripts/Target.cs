using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    private float min = 0f;
    private float max = 0f;
    public float dist = 5f;
    // Start is called before the first frame update
    void Start()
    {
        min = transform.position.z;
        max = transform.position.z + dist;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y, Mathf.PingPong(Time.time * 2, max - min) + min);
    }
}
