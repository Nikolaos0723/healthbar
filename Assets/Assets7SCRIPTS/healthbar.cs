using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class healthbar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public void setmaxhealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

       fill.color= gradient.Evaluate(1f);
    }
    public void setHealth(int Health)
    {
        slider.value = Health;

        fill.color= gradient.Evaluate(slider.normalizedValue);
    }
}
