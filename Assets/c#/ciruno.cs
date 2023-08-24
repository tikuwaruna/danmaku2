using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ciruno : MonoBehaviour
{
     public float hp = 250;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            Destroy(gameObject, 0.3f);
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("ok");
        if (other.gameObject.tag == "shot")
        {
            Debug.Log("shot");
            hp -= 1.5f;
            Destroy(other.gameObject);
        }
    }
}
