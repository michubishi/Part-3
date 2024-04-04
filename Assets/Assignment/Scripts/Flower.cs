using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Flower : Seed
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isSelected && !EventSystem.current.IsPointerOverGameObject())
        {
            plant();
        }
    }

}
