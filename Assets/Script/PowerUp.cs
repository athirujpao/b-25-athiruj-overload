using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;

public abstract class PowerUp : MonoBehaviour
{
    public abstract void ApplyPowerUp(Player player);
}
