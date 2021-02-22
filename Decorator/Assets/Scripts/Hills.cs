/* Frank Calabrese
 * Hills.cs
 * Assignment 4
 * A concrete region containing stats and a name
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hills : Region
{
  public Hills()
  {
        this.name = "Hills";
  }

    public override int GetPower()
    {
        return 5;
    }

    public override int GetProduction()
    {
        return 2;
    }
}
