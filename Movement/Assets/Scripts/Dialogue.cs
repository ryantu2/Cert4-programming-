using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public bool showDlg, grid;
    public Vector2 scr;
    public string[] dlgText;
    public int index, optionsIndex;

    private void OnGUI()
    {
        if (showDlg)
        {
            if(scr.x != Screen.width/16 || scr.y != Screen.height / 9)
            {
                scr.x = Screen.width / 16;
                scr.y = Screen.height / 9;
            }
            GUI.Box(new Rect(0,6*scr.y,Screen.width,3*scr.y), dlgText[index]);
          
            //!index+1 >=dlgText.Length
            //!index >= dlgText.Length-1
            //index < dlgText.Length
            if (!(index + 1 >= dlgText.Length || index ==optionsIndex))
            {
                if(GUI.Button(new Rect(scr.x*15,scr.y*8.5f,scr.x,scr.y*0.5f), "Next"))
                {
                    index++;
                }
            }
            else if (index == optionsIndex)
            {
                if(GUI.Button(new Rect(scr.x * 13, scr.y * 8.5f, scr.x, scr.y * 0.5f), "Accept"))
                {
                    index++;
                }
                if(GUI.Button(new Rect(scr.x * 14, scr.y * 8.5f, scr.x, scr.y * 0.5f), "Decline"))
                {
                    index = dlgText.Length - 1;
                }

            }
            else
            {
                if (GUI.Button(new Rect(scr.x * 15, scr.y * 8.5f, scr.x, scr.y * 0.5f), "bye"))
                {
                    index = 0;
                    showDlg = false;
                    Cursor.lockState = CursorLockMode.Locked;
                    Cursor.visible = false;
                    //enable player and camera movement
                }
            }

        }
       
        
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
