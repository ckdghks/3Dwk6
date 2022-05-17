using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{ 
    public Vector3 v1 = new Vector3(0, 0, 1.0f);

    // Update is called once per frame1
    void Update()
    {
        transform.position += v1 * Time.deltaTime;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Wall")
        {
            //Debug.Log("Wall!");
            v1 *= -1;
        }
    }
}
