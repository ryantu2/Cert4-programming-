using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//need access to UI
using UnityEngine.UI;

//namespace
namespace DelayedHealth
{
    [AddComponentMenu("Intro RPG/RPG/Player/Delayed-health")]
    public class Health : MonoBehaviour
    {



        //two sliders
        // background slider as normal
        //duplicate
        // parent this duplicate to the original slider


        //player health max curr and delay
        [Header("Player Stats")]
        public float maxHealth;
        public float CurrentHealth;
        public float delayHealth;
        // dropspeed
        public float dropSpeed = 8f;

        [Header("Delayed Bar and ImageFill")]
        //DelaySlider CurrenthealthSlider
        public Slider delayedHealthbar;
        //DelayFill CurrentFill
        public Image delayedSliderFill;

        
        [Header("UI Main bar and ImageFill")]
        public Slider healthBar;
        public Image sliderFill;






        // Use this for initialization
        void Start()
        {
            healthBar.value = Mathf.Clamp01(maxHealth);
            delayedHealthbar.value = Mathf.Clamp01(maxHealth);
            CurrentHealth = delayHealth = maxHealth;
            print(CurrentHealth);
        }

        // Update is called once per frame
        void Update()
        {
            //setting of current health value on slider
            healthBar.value = Mathf.Clamp01(CurrentHealth / maxHealth);
            //if delayed health is bigger than our current health
            if (CurrentHealth < delayHealth)
            {

                delayHealth -= dropSpeed * Time.deltaTime;
                delayedHealthbar.value = Mathf.Clamp01(delayHealth / maxHealth);
                //over time according to our speed make delayed health match current health
                //for (float i = delayHealth; i < CurrentHealth; i-=Time.deltaTime)
                //{
                //    delayedHealthbar.value = Mathf.Clamp01(i);
                //}
                //delayHealth = CurrentHealth;
            }
            else
            {
                delayHealth = CurrentHealth;
            }

            //call healthManager function

        }

        //health manager funciton
        //control the display of the current health fill
        // - off and on
        //control the display of the delayed health fill
        // - off 
        //	 on ...  set delayed value to current health
        //   on ... set slider to current health
    }
}
// need component menu


