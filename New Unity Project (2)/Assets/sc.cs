using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class sc : MonoBehaviour,IVirtualButtonEventHandler {

    public GameObject vbBtnObj;
        public GameObject vbBtnObj1;
    // Use this for initialization
    void Start()
    {
  
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        //   cubeAni.GetComponent<Animator>();


    }
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //  cubeAni.Play("none");
        Debug.Log("dokundun");
        vbBtnObj1.active = true;

    }




    // Update is called once per frame
    void Update()
    {
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb) {
        Debug.Log("dokunmadun");
        vbBtnObj1.active = false;

    }
}
