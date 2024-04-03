using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Seed : MonoBehaviour
{
   
    public GameObject SeedPrefab;
    void Start()
    {
        
    }

    void Update()
    {
        Vector3 mouseLocation = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        mouseLocation = Camera.main.ScreenToWorldPoint(mouseLocation); //make mouse position refer to world space
        mouseLocation.z = 0; //constantly update the z position so seeds don't go missing

        if (Input.GetMouseButtonDown(0)) //when the player clicks the left mouse button
        {
            
            GameObject seed = Instantiate(SeedPrefab); //spawn a seed according to the current mouse position
            seed.transform.position = mouseLocation;
        }
        
    }
    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(1))
        {
            //harvest
        }
    }

   


}
