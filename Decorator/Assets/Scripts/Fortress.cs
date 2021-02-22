/* Frank Calabrese
 * Fortress.cs
 * Assignment 4
 * A concrete decorator containing stats and a name modifier
 */


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fortress : BuildingDecorator
{
    Region region;

    public Fortress(Region region)
    {
        this.region = region;
    }

    public override string GetStats()
    {
        return region.GetStats() + " with a Fortress";
    }

    public override int GetPower()
    {
        return region.GetPower() + 10;
    }

    public override int GetProduction()
    {
        return region.GetProduction() + 2;
    }
}
