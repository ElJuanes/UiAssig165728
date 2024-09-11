using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soul : Items
{
    public Soul() : base(ItemCategory.Consumable){}
    
    public override string GiveName()
    {
        return "Soul";
    }

    public override int MaxStacks()
    {
        return 10;
    }

    public override Sprite GiveItemImage()
    {
        return Resources.Load<Sprite>("IconosInv/Soul");
    }
}
