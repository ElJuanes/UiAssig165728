using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Items
{

    public Weapon() : base(ItemCategory.Equippable) { }
    public override string GiveName()
    {
        return "Weapon";
    }

    public override int MaxStacks()
    {
        return 1;
    }

    public override Sprite GiveItemImage()
    {
        Sprite testSprite = Resources.Load<Sprite>("IconosInv/Weapon");
        if (testSprite == null)
        {
            Debug.LogError("Sprite not found!");
        }
        return Resources.Load<Sprite>("IconosInv/Weapon");
    }
}
