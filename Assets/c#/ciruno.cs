using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.ParticleSystem;

public class ciruno : MonoBehaviour
{
     public float hp = 250;
    public AudioSource audioSource;
    public AudioClip toppa;
    public Animation yure;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            audioSource.PlayOneShot(toppa);
            yure.Play();
            M M;
            GameObject game = GameObject.Find("timer");
            M = game.GetComponent<M>();
            M.stop = 0;
            GameObject.Find("atarihantei").GetComponent<PRS>().ito();
            Destroy(gameObject, 0.3f);
            Destroy(this);
            
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
    void end()
        {
            SceneManager.LoadScene("StageSlect1");
        }
}
