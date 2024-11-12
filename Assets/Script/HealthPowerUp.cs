using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPowerUp : PowerUp
{
    public int healthincrease;
    // Start is called before the first frame update
    void Start()
    {
        healthincrease = 20;
    }

    // Update is called once per frame
    public override void ApplyPowerUp(Player player)
    {
        player.PowerUp(healthincrease);
    }
}
