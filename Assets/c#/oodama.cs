using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oodama : MonoBehaviour
{
    public bool Freeze = false;
    public float spead = 6;
    public GameObject KT;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Freeze == true)
        {
            spead = 0;
            float Q = -45;
            for (int i = 0; i < 10; i++)
            {
                Instantiate(KT,transform.position,Quaternion.identity);
            }
        }
    }

}
