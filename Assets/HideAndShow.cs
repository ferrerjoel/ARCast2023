using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideAndShow : MonoBehaviour{
    // Start is called before the first frame update

    public GameObject demonObject;
    public GameObject demonObject2;
    private bool hideObject;

    void Start(){

        hideObject = true;
    }

    // Update is called once per frame
    void Update(){
        
        for(int i =0; i<Input.touchCount; ++i){
            if(Input.GetTouch(i).phase == TouchPhase.Began){
            hideObject = !hideObject;
        }

        if(hideObject){
            demonObject.SetActive(false);
            demonObject2.SetActive(true);
        }else if(!hideObject){
            demonObject.SetActive(true);
            demonObject2.SetActive(false);
        }
        }
        
    }
}
