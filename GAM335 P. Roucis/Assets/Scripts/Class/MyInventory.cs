/*using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
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
    public struct Item
    {
        public ItemDef Definition;
        public int Stacks;

        public Item(ItemDef def, int stacks = 1)
        {
            Definition = def;
            Stacks = stacks;
        }
    }
*//*
    public Item[] Items = new Item[10];*//*

    public Item?[] Items { get; private set; }

    public int Capacity;

    public ItemDef TESTITEM;

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

    public int? Add(ItemDef itemDef, int stacks = 1)
    {
        if (itemDef == null) { return null; }
        if (stacks <= 0) { return null; }
        for (int idx = 0; idx < Items.Length; idx++)
        {
            Item? itemOrNull = Items[idx];
            if(itemOrNull is Item item && item.Definition == itemDef && item.Stacks < itemDef.MaxStacks)
            {
                int total = item.Stacks + stacks;
                if(total > itemDef.MaxStacks)
                {
                    item.Stacks = itemDef.MaxStacks;
                    Items[idx] = item;
                    stacks = total - itemDef.MaxStacks;
                }
                else
                {
                    item.Stacks = total;
                    Items[idx] = item;
                    return 0;
                }
            }
        }
        for (int idx = 0; idx < Items.Length; idx++)
        {
            Item? itemOrNull = Items[idx];
            if (itemOrNull == null)
            {
                int newStacks = Mathf.Min(newStacks, itemDef.MaxStacks);
                Item newItem = new Item(itemDef, newStacks);
                Items[idx] = newItem;

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
}*/