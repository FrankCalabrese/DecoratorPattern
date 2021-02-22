/* Frank Calabrese
 * BuildingCreator.cs
 * Assignment 4
 * contains functions to add building decorators to a Region
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BuildingCreator : MonoBehaviour
{
    public Region region;

    public void ChooseBuilding(string building)
    {
        switch (building)
        {
            case "Fortress":
                this.region = new Fortress(region);
                break;
            case "Village":
                this.region = new Village(region);
                break;
            default:
                Debug.LogError("No building called " + building);
                break;
        }
        
        DisplayStats();
    }

    public void ChooseRegion(string region)
    {
        switch (region)
        {
            case "Hills":
                this.region = new Hills();
                break;
            case "Plains":
                this.region = new Plains();
                break;
            default:
                Debug.LogError("No region called " + region);
                break;
        }
        DisplayStats();
    }

    public void DisplayStats()
    {
        gameObject.GetComponent<Text>().text = region.GetStats() + " has " + region.GetPower() + " power, and " + region.GetProduction() + " production.";
    }
}
