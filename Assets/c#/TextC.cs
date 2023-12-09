using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TextC : MonoBehaviour
{
    public Button buttonimege;
    public Text Btext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.gameObject == EventSystem.current.currentSelectedGameObject.gameObject)
        {
            Btext.color = buttonimege.colors.highlightedColor;
        }
        else
        {
            Btext.color = buttonimege.colors.normalColor;
        }
    }
}
