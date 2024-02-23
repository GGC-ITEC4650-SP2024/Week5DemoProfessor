using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP_PlayerController : MonoBehaviour
{
    Animator myAnim;


    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //movement
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        myAnim.SetFloat("H_MOVE", h);
        myAnim.SetFloat("V_MOVE", v);

        if(Input.GetButton("Fire3")) {
            myAnim.speed = 4;
        } else {
            myAnim.speed = 1;
        }
    }
}
