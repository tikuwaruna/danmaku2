using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shot : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip sho;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        Invoke("Des", 4f);
        audioSource.PlayOneShot(sho);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(0, 8, 0) * Time.deltaTime;
    }
   void Des()
    {
        Destroy(gameObject);
    }
}
