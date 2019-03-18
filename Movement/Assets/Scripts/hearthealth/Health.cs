using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Allow us to interact with UI elements

namespace QuaterHeart
{
     //this script can be found in the Component section under the option Intro PRG/Player/Health
    [AddComponentMenu("Intro RPG/RPG/Player/Heart-health")]

    public class Health : MonoBehaviour
    {
        [Header("Player Stats")]
        //public maxHealth
        public float maxHealth;
        //public curHealth
        public float curHealth;

        [Header("Heart Slots")] //setup image slots to auto set up
        //according to the amount of slots needed
        // aka spawn the fuckers in
        //Canvas Image heartSlots array
        public Image[] heartSlots = new Image[3];

        //Sprite hearts array
        public Sprite[] hearts = new Sprite[5];
        //private percent healthPerSection
        private float healthPerSection;
        #region Start
            void Start()
            {
                Updatehearts();
            }
        #endregion
        #region Update 
            void Update()
            {
                //index variable starting at 0 for slot checks
                int i = 0;
                //foreach Image slot in heartSlots
                foreach(Image img in heartSlots)
                {
                    //if curHealth is greater or equal to full for this slot amount
                    if(curHealth >= (healthPerSection * 4) + (healthPerSection* 4) * i)
                    {
                        
                        //Set heart to 4/4
                        heartSlots[i].sprite = hearts[0];
                    }
                    //else if curHealth is greater or equal to 3/4 for this slot amount
                    else if (curHealth >= (healthPerSection * 3) + (healthPerSection *4) * i)
                    {
                        //Set Heart to 3/4
                        heartSlots[i].sprite = hearts[1];
                    }
                    //else if curHealth is greater or equal to 2/4 for this slot amount
                    else if (curHealth >= (healthPerSection * 2) + (healthPerSection *4) *i)
                    {
                        //Set Heart to 2/4
                        heartSlots[i].sprite = hearts[2];
                    }
                    //else if curHealth is greater or equal to 1/4 for this slot amount
                    else if (curHealth >= (healthPerSection * 1) + (healthPerSection *4)* i)
                    {
                        //Set Heart to 1/4
                        heartSlots[i].sprite = hearts[3];
                    }
                    //else
                    else
                    {
                        //we are empty
                        heartSlots[i].sprite = hearts[4];
                    }
                    
                    //after checking this slot increase slot index
                    i++;
   
                
                }
                
               
            }
            
        
        #endregion
        #region UpdateHearts
            public void Updatehearts() {
                // 3 hearts  = 12
                // heart = 4
                // heart = 4 sections
                // section = 1
                healthPerSection = maxHealth / (heartSlots.Length*4) ;

            }
        #endregion
    }
}


