using UnityEngine;
using System.Collections;
//this script can be found in the Component section under the option Intro RPG/Player/Interact
public class Interact : MonoBehaviour 
{
    #region Variables
    //We are setting up these variable and the tags in update for week 3,4 and 5
    [Header("Player and Camera connection")]

    //create two gameobject variables one called player and the other mainCam
    public GameObject player;

    #endregion
    #region Start
    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    //connect our player to the player variable via tag
    //connect our Camera to the mainCam variable via tag
    #endregion
    #region Update
    private void Update()
    {
        //if our interact key is pressed
        //Note: We need to create a custom input "Axes" (there are lost of default ones)
        // Edit > Project Setting > Input
        // name 'Interact'
        // positive button set to 'E'
        // Alt positive Joystick button 2

        if (Input.GetButtonDown("Interact"))
        {
            //create a ray (beam that shoots forward
            Ray interact;
            //this ray is shooting out from the main cameras screen point center of screen
            interact = Camera.main.ScreenPointToRay(new Vector2(Screen.width /2, Screen.height / 2));

            //create hit info
            RaycastHit hitInfo;

            //if this physics raycast hits something within 10 units
            if (Physics.Raycast(interact, out hitInfo, 10))
            {
                #region NPC tag
                //and that hits info is tagged NPC
                if (hitInfo.collider.CompareTag("NPC"))
                {
                    //Debug that we hit a NPC
                    Debug.Log("We hit NPC");
                }

                #endregion
                #region Item
                //and that hits info is tagged Item
                if (hitInfo.collider.CompareTag("Item"))
                {
                    //Debug that we hit an Item
                    Debug.Log("We hit Item");
                }

                #endregion
                #region Null
                ////and that hits info is tagged Item
                //if (hitInfo.Equals(null))
                //{
                //    //Debug that we hit an Item
                //    Debug.Log("We hit Nothing");
                //}
                #endregion
            }
            else
            {
                Debug.Log("We hit Nothing");
            }


        }
    }
    #endregion
}






