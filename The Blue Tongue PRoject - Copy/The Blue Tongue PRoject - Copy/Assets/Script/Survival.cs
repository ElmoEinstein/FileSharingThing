using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Survival : MonoBehaviour
{ 
    public LayerMask FoodLayer; 

    [Header("Player Health")]
    public float MaxHealth = 100f;
    public float Health;
    public Slider HealthSlider;

    [Header("Player hunger")]
    public float MaxHunger = 100f;
    public float Hunger;
    public float HungerOT;
    public Slider HungerSlider;

    [Header("Player thirst")]
    public float MaxThirst = 100f;
    public float Thirst;
    public float ThirstOT;
    public Slider ThirstSlider;

    private void Start()
    {
        Health = MaxHealth;
        Health = 0;
    }


    void Update()
    {
        Hunger = Hunger - HungerOT * Time.deltaTime;
        Thirst = Thirst - HungerOT * Time.deltaTime;

        if (Hunger <= 0f)
        {
            Health = Health - 0.5f * Time.deltaTime;
            Hunger = 0;
        }

        if (Thirst <= 0f)
        {
            Health = Health - 0.5f * Time.deltaTime;
            Thirst = 0;
        }

        HealthSlider.value = Health / MaxHealth;
        HungerSlider.value = Hunger / MaxHunger;
        ThirstSlider.value = Thirst / MaxThirst;


    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Food"))
        {
            Hunger = Hunger + 50;

            Destroy(other.gameObject);
        }

        if(other.CompareTag("Thirst"))
        {
            Thirst = Thirst + 50;

            Destroy(other.gameObject);
        }
    }
   


    public void TakeFallDamage()
    {
        Health = Health - 10f;

    }
}