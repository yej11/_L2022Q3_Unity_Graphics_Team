using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Overlay : MonoBehaviour
{
    Shader myShader;        // image effect shader 
    Material myMaterial;

    public Texture2D BlendTexture;
    public float blendOpacity = 1.0f;

    void Start()
    {
        myShader = Shader.Find("Hidden/Overlay");    // image effect shader file must have been created
        myMaterial = new Material(myShader);
    }

    private void Update()
    {
        blendOpacity = Mathf.Clamp(blendOpacity, 0.0f, 1.0f);
    }

    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        myMaterial.SetTexture("_BlendTex", BlendTexture);
        myMaterial.SetFloat("_Opacity", blendOpacity);
        Graphics.Blit(source, destination, myMaterial);
    }
}
