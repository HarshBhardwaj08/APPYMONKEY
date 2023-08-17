using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BG_SCRIPTS : MonoBehaviour
{
    [SerializeField] float scrollspeed = 0.1f;
    MeshRenderer mesh_renderer;

    float x_scroll;
    private void Awake()
    {
        mesh_renderer = GetComponent<MeshRenderer>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scroll();
    }

    private void scroll()
    {
        x_scroll = Time.time * scrollspeed;
        Vector2 offset = new Vector2(x_scroll, 0f);
        mesh_renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }
}
