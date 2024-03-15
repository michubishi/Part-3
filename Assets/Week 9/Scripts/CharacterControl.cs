using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CharacterControl : MonoBehaviour
{
    public static Villager SelectedVillager { get; private set; }
    public static String text;
    public static void SetSelectedVillager(Villager villager)
    {
        if(SelectedVillager != null)
        {
            SelectedVillager.Selected(false);
        }
        SelectedVillager = villager;
        SelectedVillager.Selected(true);

        if(SelectedVillager.GetType() == typeof(Archer))
        {
            text = "Archer";
        }

        else if (SelectedVillager.GetType() == typeof(Merchant))
        {
            text = "Merchant";
        }

        else if (SelectedVillager.GetType() == typeof(Thief))
        {
            text = "Thief";
        }

        else if(SelectedVillager == null)
        {
            text = "Nothing selected";
        }
    }
}
