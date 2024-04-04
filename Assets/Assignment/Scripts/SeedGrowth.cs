using System.Collections;
using UnityEngine;

public class SeedGrowth : MonoBehaviour
{
    public Sprite[] sprites;
    protected SpriteRenderer spriteRenderer;
    protected bool isGrown = false;


    protected virtual IEnumerator Grow() 
    {
        for (int i = 0; i< sprites.Length; i++) //loops through array of sprites every 1 second
        {
            yield return new WaitForSeconds(1);
            spriteRenderer.sprite = sprites[i];
            if (sprites[i] == sprites[2]) //if the sprite has reached it's maximum growth
            {
                isGrown = true; //tell the program that it is done growing
            }
        }
    }

    protected virtual void HarvestSeed()
    {
        Destroy(this.gameObject); //when you harvest it, it gets destroyed
    }

    protected bool checkGrowth()
    {
        return isGrown;
    }
}
