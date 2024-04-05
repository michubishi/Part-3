using UnityEngine;

public class FlowerGrowth : SeedGrowth
{
    public GameObject weedPrefab;
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        StartCoroutine(Grow());
    }


    private void OnMouseOver()
    {
        if (Input.GetMouseButtonDown(1) && checkGrowth()) //if the mouse is over a flower and it is fully grown
        {
            HarvestSeed(); //harvest the flower
        }
    }

    protected override void HarvestSeed()
    {
        Instantiate(weedPrefab, transform.position, transform.rotation); //create a weed that grows after the flower has been harvested
        HarvestManager.scoreFlower++; //add to total flower amount
        base.HarvestSeed();
    }
}
