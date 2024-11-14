using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public MyItemDefinition Definition { get; private set; }
    public int Stacks { get; set; }
    public Item(MyItemDefinition definition, int stacks)
    {
        this.Definition = definition;
        this.Stacks = stacks;
    }
}
public class MyInventory : MonoBehaviour
{

    public Item[] Items = new Item[10];

    public int capacity;


    public Item Add(ItemDefinition itemDefinition, int amount)
    {
        if (itemDefinition == null) { return null; }
        foreach (Item itemOrNull in Items)
        {
            if (itemOrNull != null && itemOrNull.Definition == itemDefinition && itemOrNull.Stacks < itemDefinition.MaxStacks)
            {
                int total = itemOrNull.Stacks + amount;
                if (total > itemDefinition.MaxStacks)
                {
                    itemOrNull.Stacks itemDefinition.MaxStacks;
                    return Add(itemDefinition, total - itemDefinition.MaxStacks);
                }
                else
                {
                    itemOrNull.Stacks = total;
                    return null;
                }
            }

            for (int idx = 0; idx < Items.Length; idx++)
            {
                if (Items[idx] == null)
                {
                    if (amount <= itemDefinition.MaxStacks) 
                    {
                        Item newItem = new Item(itemDefinition, amount);
                        Items[idx] = newItem;
                        return null;
                    }
                    else
                    {
                        Item newItem = new Item(itemDefinition, itemDefinition.MaxStacks);
                        Items[idx] = newItem;
                        amount -= itemDefinition.MaxStacks;
                        
                    }
                }
            }
        }
      
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
    }
}
