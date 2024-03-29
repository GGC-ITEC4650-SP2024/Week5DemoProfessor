using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    InvManager invMgr;

    // Start is called before the first frame update
    void Start()
    {
        invMgr = GameObject.Find("Inv").GetComponent<InvManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.eulerAngles += Vector3.up * 180 * Time.deltaTime;
    }

    //Called when my gameObject collides with another
    //Requires at least 1 of the gameObjects to have a Rigidbody or CharacterController.
    private void OnTriggerEnter(Collider other)
    {
        invMgr.addItemByName(name);
        Destroy(gameObject);
    }
}
