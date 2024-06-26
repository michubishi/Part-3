using UnityEngine;

public class Seed : MonoBehaviour
{

    protected bool isSelected = false;
    public GameObject SeedPrefab;
    protected void plant()
    {
        Vector3 mouseLocation = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0);
        mouseLocation = Camera.main.ScreenToWorldPoint(mouseLocation); //make mouse position refer to world space
        mouseLocation.z = 0; //constantly update the z position so seeds don't go missing

        GameObject seed = Instantiate(SeedPrefab); 
        seed.transform.position = mouseLocation; //spawn a seed according to the current mouse position
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
