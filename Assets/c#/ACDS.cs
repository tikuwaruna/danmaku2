using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ACDS : MonoBehaviour
{
    float timeCount = 0;
    [SerializeField] GameObject ACD;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (PRS.akike == false)
        {
            timeCount += Time.deltaTime;
        if (timeCount > 0.07f)
        {
            timeCount = 0;
            transform.position = new Vector3(Random.Range(-6.14f, 6.14f), 5.35f, 0);
            GameObject createObject = Instantiate(ACD, transform.position, Quaternion.identity);
        }
        }
        
    }
}
