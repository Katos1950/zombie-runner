using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLightSystem : MonoBehaviour
{
    [SerializeField] float lightDecay = 0.1f;
    [SerializeField] float angleDeacay = 1f;
    [SerializeField] float minimumAngle = 40f;
    Light light;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        DecreaseLightAngle();
        DecreaseLightIntensity();
    }

    private void DecreaseLightAngle()
    {
        if(light.spotAngle < minimumAngle) { return; }
        light.spotAngle -= angleDeacay * Time.deltaTime;
    }

    private void DecreaseLightIntensity()
    {
        light.intensity -= lightDecay * Time.deltaTime;
    }

    public void RestoreLighIntensity(float intensity)
    {
        light.intensity += intensity;
    }

    public void RestoreLightAngle(float angle)
    {
        light.spotAngle = angle;
    }
}
