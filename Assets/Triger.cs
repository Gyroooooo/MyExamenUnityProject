using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Triger : MonoBehaviour{
	
 public UnityEvent custom_ =on_trigger_enter;
	void OnTriggerEnter (Collider other);
	{
      print ("ball touch me")
	}