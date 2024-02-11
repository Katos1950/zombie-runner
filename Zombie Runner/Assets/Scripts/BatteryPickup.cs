using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryPickup : MonoBehaviour
{
    [SerializeField] float intensity = 1f;
    [SerializeField] float angle = 90f;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag.Equals("Player"))
        {
            FlashLightSystem light = other.gameObject.GetComponentInChildren <FlashLightSystem>();
            light.RestoreLighIntensity(intensity);
            light.RestoreLightAngle(angle);
            Destroy(gameObject);
        }
    }
}
