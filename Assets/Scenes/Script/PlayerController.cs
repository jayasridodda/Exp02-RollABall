using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollAball : MonoBehaviour
{
    // Start is called before the first frame update
    public float xforce = 5.0f, yforce = 200.0f, zforce = 5.0f;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float x = 0.0f, y = 0.0f, z = 0.0f;
        if (Input.GetKey(KeyCode.A))
        {
            x = x - xforce;
        }
        if (Input.GetKey(KeyCode.D))
        {
            x = x + xforce;
        }
        if (Input.GetKey(KeyCode.W))
        {
            z = z + zforce;
        }
        if (Input.GetKey(KeyCode.S))
        {
            z = z - zforce;
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            y = yforce;
        }
        GetComponent<Rigidbody>().AddForce(x, y, z);

    }
}
