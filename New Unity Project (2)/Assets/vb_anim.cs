using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class Vb_anim : MonoBehaviour, IVirtualButtonEventHandler {
    public GameObject vbBtnObj;
	// Use this for initialization
	void Start () {
        vbBtnObj = GameObject.Find("Laciebtn");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
     //   cubeAni.GetComponent<Animator>();
	}
    public void OnButtonPressed(VirtualButtonBehaviour vb) {
      //  cubeAni.Play("none");
      vbBtnObj= GameObject.FindWithTag("kaybol");
        vbBtnObj.SetActive(false);
  
    }

   


    // Update is called once per frame
    void Update () {
		
	}

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
       // cubeAni.Play("none");
    }
}
