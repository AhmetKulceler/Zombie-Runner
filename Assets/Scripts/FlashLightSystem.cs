using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightSystem : MonoBehaviour
{
    [SerializeField] float intensityDecay = .1f;
    [SerializeField] float angleDecay = .5f;
    [SerializeField] float minimumAngle = 25f;

    [SerializeField] float maximumAngle = 75f;
    [SerializeField] float maximumIntensity = 10f;

    Light myLight;

    private void Start()
    {
        myLight = GetComponent<Light>();
    }

    private void Update()
    {
        DecreaseLightIntensity();
        DecreaseLightAngle();        
    }

    public void AddLightIntensity(float intensityAmount)
    {
        if (myLight.intensity < maximumIntensity)
        {
            myLight.intensity += intensityAmount;
        }
    }

    public void AddLightAngle(float angleAmount)
    {
        if (myLight.spotAngle < maximumAngle)
        {
            myLight.spotAngle += angleAmount;
        }        
    }

    private void DecreaseLightIntensity()
    {
        if (myLight.intensity <= 0)
        {
            return;
        }
        else 
            myLight.intensity -= (intensityDecay * Time.deltaTime);        
    }

    private void DecreaseLightAngle()
    {
        if (myLight.spotAngle < minimumAngle)
        {
            return;
        }
        else 
            myLight.spotAngle -= (angleDecay * Time.deltaTime);
    }
}
