using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayDamage : MonoBehaviour
{
    [SerializeField] Canvas DamageTakenCanvas;
    [SerializeField] float waitTime = 1f;
    // Start is called before the first frame update
    void Start()
    {
        DamageTakenCanvas.enabled = false;
    }
    
    public void  DamageTakenUIDisplay()
    {
        StartCoroutine("DisplayUI");
    }

    private IEnumerator DisplayUI()
    {
        DamageTakenCanvas.enabled = true;
        yield return new WaitForSeconds(waitTime);
        DamageTakenCanvas.enabled = false;
    }
}

