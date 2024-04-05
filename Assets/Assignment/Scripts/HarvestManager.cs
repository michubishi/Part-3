using TMPro;
using UnityEngine;

public class HarvestManager : MonoBehaviour
{
    public static int scoreCrop;
    public static int scoreFlower;
    public static int totalScore;


    public static void totalAmount()
    {
        totalScore = scoreCrop + scoreFlower; //calculate the amount of both together
    }
}
