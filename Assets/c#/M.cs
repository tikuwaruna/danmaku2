using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class M : MonoBehaviour
{
    public static float tm = 35.4f;
    public Text TxT;
    public float stop = 1;
    public PRS prs;
    public AudioClip nige;
    public AudioSource od;
    bool st = true;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("timer", 0.4f);
    }

    // Update is called once per frame
    void Update()
    {
        TxT.text = tm.ToString("f2");
        if (tm < -0.1 && st == true)
        {
            od.PlayOneShot(nige);
            prs.slect();
            tm = 0;
            st = false;
        }
        tm -= Time.deltaTime * stop;
        
    }
    public void timer()
    {

    }
}
