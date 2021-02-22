/* Frank Calabrese
 * Plains.cs
 * Assignment 4
 * A concrete region containing stats and a name
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plains : Region
{
    public Plains()
    {
        this.name = "Plains";
    }

    public override int GetPower()
    {
        return 2;
    }

    public override int GetProduction()
    {
        return 5;
    }
}
