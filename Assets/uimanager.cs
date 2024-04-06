using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uimanager : MonoBehaviour
{
    public RawImage crosshair;
    public Canvas canvas;
    // Start is called before the first frame update
    void Start()
    {
        crosshair.rectTransform.position = new Vector2(Screen.width/2, Screen.height/2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
