using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class enemyFA : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.DOMove(new Vector3(0, 2.7f, 0), 0.4f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
