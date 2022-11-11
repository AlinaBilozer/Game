using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
    public UnityEvent on_trigger_enter_custom;

    void OnTriggerEnter(Collider other)
    {
        on_trigger_enter_custom.Invoke();

    }
    void OnTriggerExit(Collider other)
    {
        

    }
}
