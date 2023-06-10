using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Des", 6);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 6, 0) * Time.deltaTime;
    }
   void Des()
    {
        Destroy(gameObject);
    }
}
