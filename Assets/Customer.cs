using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Customer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject customerOrder;
    public float speed = 1.0f;
    public Vector3 destinationPosition = new Vector3(-5.0f,1.0f,0.0f);
    private bool spawnedOrder = false;
    void Start()
    {
        //transform.position = new Vector3(-5.0f,1.0f,0.0f);
        //moving = true;

    }

    // Update is called once per frame
    void Update()
    {
        //Instantiate(customerOrder,transform.position,Quaternion.identity);
        Vector3 dir = destinationPosition - transform.position;
        float distance = dir.magnitude;
        dir = dir.normalized;
        float move = speed * Time.deltaTime;
        if(move > distance) move = distance;
        transform.Translate(dir*move);
        if(transform.position == destinationPosition && spawnedOrder == false) 
        {
            Instantiate(customerOrder,transform.position,Quaternion.identity);
            spawnedOrder = true;
        }
    }

}
