using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthSlider;

    public void IncrementHealth(int amount)
    {
        healthSlider.value += amount;
    }

    public void DecrementHealth(int amount)
    {
        healthSlider.value -= amount;
    }

    public int GetHealth()
    {
        return (int)healthSlider.value;
    }
}
