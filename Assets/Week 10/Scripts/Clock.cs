using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clock : MonoBehaviour
{
    public Slider slider;
    float time;
    public float speed = 1;

    void Update()
    {
        time += Time.deltaTime * speed;
        time = time % 60;
        slider.value = time;
    }
}
