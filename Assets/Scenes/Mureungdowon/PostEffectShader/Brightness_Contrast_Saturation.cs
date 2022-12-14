using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brightness_Contrast_Saturation : MonoBehaviour
{
    Shader myShader;        // image effect shader 
    Material myMaterial;

    public float brightness = 1.0f;
    public float saturation = 1.0f;
    public float contrast = 1.0f;
    void Start()
    {
        myShader = Shader.Find("Hidden/Brightness_Contrast_Saturation");    // image effect shader file must have been created
        myMaterial = new Material(myShader);
    }

    private void Update()
    {
        brightness = Mathf.Clamp(brightness, 0.0f, 3.0f);
        saturation = Mathf.Clamp(saturation, 0.0f, 3.0f);
        contrast = Mathf.Clamp(contrast, 0.0f, 3.0f);
    }
    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        myMaterial.SetFloat("_Brightness", brightness);
        myMaterial.SetFloat("_Saturation", saturation);
        myMaterial.SetFloat("_Contrast", contrast);
        Graphics.Blit(source, destination, myMaterial);
    }
}
