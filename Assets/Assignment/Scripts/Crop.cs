using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class Crop : Seed
{
    public TextMeshProUGUI cropText;
    public TextMeshProUGUI totalScore;
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && isSelected && !EventSystem.current.IsPointerOverGameObject()) //checks if left click has been pressed and on the right button, also checks if it is over a UI
        {
            plant(); //plant the seed
        }

        HarvestManager.totalAmount(); //calculate the amount of crops and flowers together

        cropText.text = "Crops Harvested: " + HarvestManager.scoreCrop.ToString(); //displays the total amount of crops
        totalScore.text = "Overall Harvested: " + HarvestManager.totalScore.ToString(); //displays the total amount of everything

    }


}
