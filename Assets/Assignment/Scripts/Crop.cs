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
        if (Input.GetMouseButtonDown(0) && isSelected && !EventSystem.current.IsPointerOverGameObject())
        {
            plant();
        }
    }


}
