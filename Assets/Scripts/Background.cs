using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public float speed;
    public MeshRenderer mr;
    private float x;

    // Update is called once per frame
    void Update()
    {
        scroll();
    }

    void scroll()
    {
        x = Time.time * speed;
        Vector2 offset = new Vector2(x, 0f);
        mr.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
