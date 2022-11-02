using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Trigger : MonoBehaviour
{
  public UnityEvent custom_on_trigger_enter;
	 void OnTriggerEnter()
	{
		custom_on_trigger_enter.Invoke();

       print ("Ball touch me")
	}
}
