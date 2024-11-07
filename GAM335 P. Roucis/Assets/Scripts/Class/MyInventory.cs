/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyInventory : MonoBehaviour
{
    public MyItemDefinition[] Items;
    public int capacity;

    void Start()
    {
        Items = new MyItemDefinition[capacity];
    }


    public bool Add(MyItemDefinition item)
    {
        int? NextOpenIndex()
        {

            for (int idx = 0; idx < capacity; idx++)
            {
                if (Items[idx] == null)
                {
                    return idx;
                }
            }
            return null;
        }
        int? nextIndexOrNull = NextOpenIndex();
        if (nextIndexOrNull is int nextIndex)
        {
            Items[nextIndex] = item;
            return true;
        }
        else
        {
            return false;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
*/