using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    [SerializeField]private Text _TextScore;
	[SerializeField]private int _score = 0;

   private void OnTriggerEnter2D(Collider2D  target)
   {
	   if(target.tag == "Enamy")
	   {
		   UpdateScore();
		   target.gameObject.SetActive(false);
		  
	   }
   }
   private void UpdateScore()
   {
	   _score++;
	   _TextScore.text = "Score :" + _score.ToString();
   }
}
