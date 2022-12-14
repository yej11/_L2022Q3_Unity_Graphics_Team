using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multipass : MonoBehaviour
{
    Shader myShader;        // image effect shader 
    Material myMaterial;

    public bool InvertEffect;
    public bool DepthEffect;

    void Start()
    {
        myShader = Shader.Find("Hidden/MultiPass");    // image effect shader file must have been created
        myMaterial = new Material(myShader);
    }


    private void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if (InvertEffect)
        {
            Graphics.Blit(source, destination, myMaterial, 0);
        }
        else if (DepthEffect)
        {
            Graphics.Blit(source, destination, myMaterial, 1);
        }
        else
        {
            Graphics.Blit(source, destination);
        }
    }
}
