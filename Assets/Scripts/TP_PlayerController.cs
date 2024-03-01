using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP_PlayerController : MonoBehaviour
{
    Animator myAnim;
    InvManager invMgr;

    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
        invMgr = GameObject.Find("Inv").GetComponent<InvManager>();
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

        //select next item in inventory
        if(Input.GetButtonDown("Fire2")) {
            invMgr.selectNextItem();
        }

        if(Input.GetButtonDown("Jump")) {
            //use the current item
            Item item = invMgr.getSelectedItem();
            Invoke(item.name, 0);
        }        
    }

    public void Rocket() {
        print("Doing rocket stuff");
    }
}
