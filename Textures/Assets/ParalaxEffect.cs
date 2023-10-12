using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ParalaxEffect : MonoBehaviour
{
    public float offsetSpeed;
     RawImage rawImage;


    void Start()
    {
        rawImage = GetComponent<RawImage>();

    }

    // Update is called once per frame
    void Update()
    {
        float x = rawImage.uvRect.x + offsetSpeed;
        rawImage.uvRect = new Rect(x, 0, 1,1);
       // float Y = rawImage.uvRect.y + offsetSpeed;
    }
}
