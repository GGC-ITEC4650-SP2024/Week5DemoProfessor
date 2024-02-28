using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InvManager : MonoBehaviour
{
    public Image leftBox;
    public Image centerBox;
    public Image rightBox;

    public Item[] allPossibleItems;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public int getInvSize()
    {
        int size = 0;
        for (int i = 0; i < allPossibleItems.Length; i++)
        {
            if (allPossibleItems[i].owned())
            {
                size++;
            }
        }
        return size;
    }

    public int nextIndex(int i)
    {
        if (i < allPossibleItems.Length - 1) { return i + 1; }
        else { return 0;}
    }

    public int prevIndex(int i)
    {
        if (i > 0) { return i - 1;}
        else { return allPossibleItems.Length - 1;}
    }

}
