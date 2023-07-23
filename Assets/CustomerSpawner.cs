using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawner : MonoBehaviour
{
    public GameObject customer;
    public int maxNrCustomers = 3;
    private float time = 0.0f;
    private float previousTime = 0.0f;
    private int nrCustomers;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = Time.time;
        if(time - previousTime > 10.0f && maxNrCustomers > nrCustomers)
        {
            previousTime = time;
            Instantiate(customer,transform.position,Quaternion.identity);
            nrCustomers += 1;

        }
    }
}
