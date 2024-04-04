using UnityEngine;
using UnityEngine.EventSystems;

public class Flower : Seed
{
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isSelected && !EventSystem.current.IsPointerOverGameObject()) //checks if left mouse is clicked, and the plant seed is selected and not over a UI
        {
            plant(); //plant the seed
        }
    }

}
