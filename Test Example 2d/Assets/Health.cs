using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider healthBar;
    public static int health = 100;
    // Start is called before the first frame update
    void Start()
    {
        healthBar.value = health;
    }
    private void Update()
    {
        healthBar.value = health;
    }
}
