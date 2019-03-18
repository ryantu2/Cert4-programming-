using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//intereact with the UI
using UnityEngine.UI;

namespace LinearHealthBar
{
	[AddComponentMenu("Intro RPG/RPG/Player/Heart-health")]
	public class Health : MonoBehaviour 
	{
		[Header("Player Stats")]
		//public maxhealth
		public float maxHealth;
		//public current health
		public float curhealth;
		
		[Header("UI Reference")]
		public Slider healthBar;
		public Image sliderFill;

		// Use this for initialization
		void Start () {
			
		}
		
		// Update is called once per frame
		void Update () 
		{
			healthBar.value = Mathf.Clamp01(curhealth / maxHealth);
			healthManager();
		}

		void healthManager()
		{
			if (curhealth <= 0 && sliderFill.enabled)
			{
				sliderFill.enabled = false;
				Debug.Log("Disabled");
			}
			else if(!sliderFill.enabled && curhealth > 0)
			{
				sliderFill.enabled = true;
				Debug.Log("enabled");
			}
		}
	}
}



