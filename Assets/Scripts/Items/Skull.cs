using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skull : Items
{
    public Skull() : base(ItemCategory.Consumable) { }
    public override string GiveName()
    {
        return "Skull";
    }

    public override int MaxStacks()
    {
        return 15;
    }

    public override Sprite GiveItemImage()
    {
        return Resources.Load<Sprite>("IconosInv/Skull");
    }
}
