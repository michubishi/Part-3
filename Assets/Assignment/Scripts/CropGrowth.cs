using UnityEngine;

public class CropGrowth : SeedGrowth
{
    int pullCarrotCount;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(Grow());
    }
    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1) && checkGrowth()) //if the mouse is over a fully grown crop
        {
            HarvestSeed(); //harvest the crop
        }
    }

    protected override void HarvestSeed()
    {
        if (Input.GetMouseButton(1)) //whenever right click is pressed, increase count by 1
        {
            pullCarrotCount++;
        }

        if (Input.GetMouseButtonDown(1) && pullCarrotCount == 3) //if right click is pressed and the player has pressed right click 3 times
        {
            pullCarrotCount = 0; //reset count back to zero
            HarvestManager.scoreCrop++; //add to total crop amount
            base.HarvestSeed(); //harvest the crop
        }

    }
}
