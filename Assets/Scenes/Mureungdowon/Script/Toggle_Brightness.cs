using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Toggle_Brightness : MonoBehaviour
{
    public GameObject camera;
    public GameObject Brightness_camera;
    bool isOn;

    public void OnValueChanged()
    {
        isOn = GetComponent<Toggle>().isOn;
        if (isOn)
        {
            Brightness_camera.SetActive(true);
            camera.SetActive(false);
        }
        else
        {
            Brightness_camera.SetActive(false);
        }
    }
}
