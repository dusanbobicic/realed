using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class ControlPanel : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject Panel;

    private bool _visible;

    // Use this for initialization
    void Start () {
        GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }
	
    // Update is called once per frame
    void Update () {
		
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        //var obj_name = "";
        //switch (vb.VirtualButtonName)
        //{
        //    case "Top":
        //        obj_name = "Top_Info";
        //        break;
        //    case "Left":
        //        obj_name = "Left_Info";
        //        break;
        //    case "Right":
        //        obj_name = "Right_Info";
        //        break;
        //}
        _visible = !_visible;
        //Debug.Log(obj_name);
        Panel.SetActive(_visible);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        //_top_info.SetActive(_visible);
    }
}
