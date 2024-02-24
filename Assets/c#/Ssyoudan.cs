using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ssyoudan : MonoBehaviour
{
    [SerializeField] GameObject KT2; 
    [SerializeField]float angle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "oodma (1)(Clone)")
        {
            for (float i = -45; i <= 45; i += 22.5f)
            {
                //Debug.Log("okie"+ (i+angle));
                // GameObjectを新たに生成する
                // 第一引数：生成するGameObject
                // 第二引数：生成する座標
                // 第三引数：生成する角度
                // 戻り値：生成したGameObject
                GameObject createObject = Instantiate(KT2, transform.position, Quaternion.identity);

                KT2 bulletScript = createObject.GetComponent<KT2>();

                bulletScript.Init(i);

            }
            Destroy(gameObject, 0.01f);
        }
    }
}
