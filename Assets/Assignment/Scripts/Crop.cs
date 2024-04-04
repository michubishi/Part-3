using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Crop : Seed
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isSelected && !EventSystem.current.IsPointerOverGameObject()) //checks if left click has been pressed and on the right button, also checks if it is over a UI
        {
            plant(); //plant the seed
        }
    }


}
