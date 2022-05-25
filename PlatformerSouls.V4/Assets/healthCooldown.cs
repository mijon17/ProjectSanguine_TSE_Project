using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class healthCooldown : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public Gradient gradient;
    public Image fill;


    public void SetMaxCooldown(float time)
    {
        slider.maxValue = time;
        slider.value = time;

        fill.color = gradient.Evaluate(1f);
    }

    public void SetCooldown(float time)
    {
        slider.value = time;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
