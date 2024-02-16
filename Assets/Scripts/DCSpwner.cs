using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DCSpwner : MonoBehaviour
{
    public GameObject dcPrefab;

    // Start is called before the first frame update
    void Start()
    {
        GameObject g = Instantiate(dcPrefab);
        g.transform.position = new Vector3(
            Random.Range(-10f, 10f),
            5, 
            Random.Range(-10f, 10f));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
