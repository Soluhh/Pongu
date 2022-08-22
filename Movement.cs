using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 1;

    void Update()
    {
        float y = Input.GetAxis("Vertical");

        transform.position += new Vector3(0, y, 0) * Time.deltaTime * speed;
    }
}
