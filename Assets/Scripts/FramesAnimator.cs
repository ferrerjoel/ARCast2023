using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FramesAnimator : MonoBehaviour
{
    public Texture2D[] frames; 
    public byte framesPerSecond = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    
    void Update() {
        int index = (int)(Time.time * framesPerSecond) % frames.Length; 
        GetComponent<Renderer>().material.mainTexture = frames[index]; 
    }
}
