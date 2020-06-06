using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class DevDisplay : MonoBehaviour
{
    public Canvas devCanvas;
    public Font devFont;
    public int sizeForFont = 20;
    public Vector2 offset = new Vector2(-350f, 190f);

    Text text;
    RectTransform rectTransform;
    float deltaTime = 0.0f;

    void Start()
    {
        if (GameObject.Find("Canvas") != null || GameObject.FindGameObjectWithTag("UI") != null)
        {
            devCanvas = GameObject.Find("Canvas").GetComponent<Canvas>();
        }
        else
        {
            devCanvas = devCanvas;
        }

        // Initialize Game Object
        GameObject fpsCounter = new GameObject();
        fpsCounter.transform.parent = devCanvas.transform;
        fpsCounter.name = "devText";
        text = fpsCounter.AddComponent<Text>();
        text.font = devFont;
        text.fontSize = sizeForFont;

        // Text position
        rectTransform = text.GetComponent<RectTransform>();
        rectTransform.localPosition = new Vector3(offset.x, offset.y, 0);
        rectTransform.sizeDelta = new Vector2(1200, 600);
    }

    void Update()
    {
        // Intialize FPS Values
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
        float msec = deltaTime * 1000.0f;
        float fps = 1.0f / deltaTime;


        text.text = string.Format(
             "{0} FPS [{1} MS]" + Environment.NewLine +
             "{2} [{3}]" + Environment.NewLine +
             "{4} MB VRAM" + Environment.NewLine +
             "{5}" + Environment.NewLine +
             "{6} MB RAM" + Environment.NewLine +
             "{7}",


             Math.Round(fps),
             msec,
             SystemInfo.graphicsDeviceName,
             SystemInfo.graphicsDeviceType.ToString(),
             SystemInfo.graphicsMemorySize.ToString(),
             SystemInfo.processorType,
             SystemInfo.systemMemorySize.ToString(),
             SystemInfo.operatingSystem
         );

        rectTransform.localPosition = new Vector3(offset.x, offset.y, 0);
    }
}
