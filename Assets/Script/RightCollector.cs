using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightCollector : MonoBehaviour
{
  private void OnTriggerEnter2D(Collider2D  target)
   {
	   if(target.tag == "Enamy1")
	   {
		  
		   target.gameObject.SetActive(false);
		  
	   }
   }
  
}
