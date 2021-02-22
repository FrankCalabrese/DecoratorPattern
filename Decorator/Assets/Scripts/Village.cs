/* Frank Calabrese
 * Village.cs
 * Assignment 4
 * A concrete decorator containing stats and a name modifier
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Village : BuildingDecorator
{
    Region region;

    public Village(Region region)
    {
        this.region = region;
    }

    public override string GetStats()
    {
        return region.GetStats() + " with a Village";
    }

    public override int GetPower()
    {
        return region.GetPower() + 2;
    }

    public override int GetProduction()
    {
        return region.GetProduction() + 10;
    }
}
