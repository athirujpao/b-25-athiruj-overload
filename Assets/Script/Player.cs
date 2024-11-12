using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    int health = 10;
    public int Health => health; //read only ,set only

    float strength = 10f;
    public float Strength => strength;

    float speed = 5f;
    public float StrenghtSpeed => speed;

    float originalSpeed;
    float speedBoostDuration = 0f;
    float speedBoostTimer = 0f;
    bool isSpeedBoostActive = false;

    //make ui for health, strenght and speed

    void Start()
    {
        originalSpeed = speed;
        UpdateHealthText();
        UpdateStrengthText();
        UpdateSpeedText();
    }

    private void Update()
    {
        UpdateSpeedBoostTimer();
        
    }
    void UpdateSpeedBoostTimer() 
    {
        if (isSpeedBoostActive) 
        {
            speedBoostTimer += Time.deltaTime;
            Debug.Log("Speed Boost Upgrade!!!");
            if (speedBoostTimer >= speedBoostDuration) // ตัวจับเลข speedboost
            {
                speed = originalSpeed;
                isSpeedBoostActive = false;
                Debug.Log("Speed Boost ended. back to normal.");
            }
        }
    }


    [SerializeField]  TextMeshProUGUI healthTxt, strengthTxt, speedTxt;
    // method overloading 
    public void PowerUp(int healthincrease) 
    {
        health += healthincrease;
        Debug.Log($"Health increase by {healthincrease}. New {health}");
        UpdateHealthText() ;
    }

    public void PowerUp(float strengthMultiplier)
    {
        strength *= strengthMultiplier;
        UpdateStrengthText() ;
        Debug.Log($"Strength  increased by {strengthMultiplier * 100}%. New Strength: {strength}");
    }
    public void PowerUp(float speedMultiplier, float duration)
    {
        if (!isSpeedBoostActive)
        {
            speed *= speedMultiplier;
            isSpeedBoostActive = true;
            speedBoostDuration = duration;
            speedBoostTimer = 0.0f;
            UpdateSpeedText();
            
            Debug.Log($"Speed boosted by {speedMultiplier * 100}% for {duration} seconds.");
        }
    }


       void UpdateHealthText()
    {
        healthTxt.text = $"Health: {Health}";
    }
 
    void UpdateStrengthText()
    {
        strengthTxt.text = $"Strength: {Strength}";
    }
 
    void UpdateSpeedText()
    {
        speedTxt.text = $"Speed: {speed}";
    }

}

