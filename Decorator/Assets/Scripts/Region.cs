/* Frank Calabrese
 * Region.cs
 * Assignment 4
 * An abstract class with a name and some abstract getters
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Region
{
    public string name = "Region";


    public virtual string GetStats()
    {
        return name;
    }

    public abstract int GetPower();

    public abstract int GetProduction();
}
