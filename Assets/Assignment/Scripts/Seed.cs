using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Seed : MonoBehaviour
{
    protected bool isSelected = false;
    public GameObject SeedPrefab;
    
    void Start()
    {
        
    }

    protected void plant()
    {
        Vector3 mouseLocation = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        mouseLocation = Camera.main.ScreenToWorldPoint(mouseLocation); //make mouse position refer to world space
        mouseLocation.z = 0; //constantly update the z position so seeds don't go missing

        GameObject seed = Instantiate(SeedPrefab); //spawn a seed according to the current mouse position
        seed.transform.position = mouseLocation;
    }

    public void Select() //tell the program that a button has been selected
    {
        isSelected = true;

    }

    public void Deselect() //tells the program that the button has been deselected
    {
        isSelected = false;
    }




}
