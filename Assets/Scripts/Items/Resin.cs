using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resin : Items
{
    public Resin() : base(ItemCategory.Consumable) { }
    public override string GiveName()
    {
        return "Resin";
    }

    public override int MaxStacks()
    {
        return 5;
    }

    public override Sprite GiveItemImage()
    {
        return Resources.Load<Sprite>("IconosInv/Resin");
    }
}
