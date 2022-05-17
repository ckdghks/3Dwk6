using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    float rotSpeed = 100f;
    public int Score;

    void Start()
    {
        //Debug.Log(Score);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime, Space.World);
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.tag == "Player")
        {
            GameManager Manager = FindObjectOfType<GameManager>();
            if( Manager != null)
            {
                Manager.gotScore += Score;
            }
            gameObject.SetActive(false);
        }
 
    }
}
