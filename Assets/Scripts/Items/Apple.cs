using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Apple : Items
{
    public Apple() : base(ItemCategory.Consumable) { }
    public override string GiveName()
    {
        return "Apple";
    }

    public override int MaxStacks()
    {
        return 5;
    }

    public override Sprite GiveItemImage()
    {
        return Resources.Load<Sprite>("Item Icons/AppleIcon");
    }
}
