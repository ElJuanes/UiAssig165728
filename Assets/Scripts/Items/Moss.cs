using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moss : Items
{
    public Moss() : base(ItemCategory.Consumable) { }
    public override string GiveName()
    {
        return "Moss";
    }

    public override int MaxStacks()
    {
        return 10;
    }

    public override Sprite GiveItemImage()
    {
        return Resources.Load<Sprite>("IconosInv/Moss");
    }
}
