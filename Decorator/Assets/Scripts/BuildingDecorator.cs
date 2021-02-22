/* Frank Calabrese
 * BuildingDecorator.cs
 * Assignment 4
 * An abstract decorator for the Region class
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BuildingDecorator : Region
{
    public abstract override string GetStats();

}
