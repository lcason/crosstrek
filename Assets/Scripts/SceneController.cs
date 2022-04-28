using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Doozy.Runtime;
using Doozy.Runtime.UIManager.Containers;

public class SceneController : MonoBehaviour
{
     
    // Start is called before the first frame update

    
    private int step = -1;

    public UIContainer[] panels;

    public Animator dipStickAnim;

    public GameObject dipstick;


    // Update is called once per frame
    void Update()
    {
        foreach(Touch touch in Input.touches) {
            if (touch.phase == TouchPhase.Began) {
                print("hello touchy");
                nextPanel();
            }
        }

    }

    IEnumerator Timer()
    {
        

        yield return new WaitForSeconds(3);

        dipStickAnim.enabled = false;
        
    }


    void nextPanel()
    {
       

        if (step == -1)
        {
            step++;
            panels[step].gameObject.SetActive(true);
            return;
        }

        panels[step].gameObject.SetActive(false);
        step++;

        if (step == panels.Length)
        {
            step = 0;
            dipStickAnim.enabled = true;

        }

        panels[step].gameObject.SetActive(true);

        if (step == 3)
        {

            //hax
            dipstick.SetActive(true);
            StartCoroutine(Timer());
        } else
        {
            dipstick.SetActive(false);
        }

        //if (step != 3 )
        //{
        //    dipStick.gameObject.SetActive(false);
           
        //}


    }
    // ui container show hide will trigger correct animations -- probably 
}
