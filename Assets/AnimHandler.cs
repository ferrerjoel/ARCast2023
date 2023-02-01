using System.Collections;
using System.Collections.Generic;
using UnityEngine.Playables;
using UnityEngine;

public class AnimHandler : MonoBehaviour{
    // Start is called before the first frame update

    public PlayableDirector timeline;

    void Start(){
        timeline = GetComponent<PlayableDirector>();
    }

    // Update is called once per frame
    void Update(){
        for(int i =0; i<Input.touchCount; ++i){
            if(Input.GetTouch(i).phase == TouchPhase.Began){
                timeline.Play();
            }
        }
    }
}