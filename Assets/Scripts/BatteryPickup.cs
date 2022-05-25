using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float addIntensity_Amount = 1f;
    [SerializeField] float addAngle_Amount = 15f;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponentInChildren<FlashLightSystem>().AddLightIntensity(addIntensity_Amount);
            other.GetComponentInChildren<FlashLightSystem>().AddLightAngle(addAngle_Amount);            

            Destroy(gameObject);
        }
    }
}
