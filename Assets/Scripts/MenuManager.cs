using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.iOS;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject soText;
    void Start()
    {
        soText.GetComponent<UnityEngine.UI.Text>().text = SystemInfo.operatingSystem;
        Debug.Log(SystemInfo.processorCount);
        Debug.Log(SystemInfo.processorFrequency);
        Debug.Log(SystemInfo.processorType);
        Debug.Log(SystemInfo.graphicsMemorySize);
        Debug.Log(SystemInfo.graphicsDeviceName);
        Debug.Log(SystemInfo.operatingSystem);
    }

    void Update()
    {
        
    }
    
    //Se hacen publicos para que el boton pueda acceder a los metodos correspontiendes.
    public void StartGame()
    {

    }

    public void ShowOptions()
    {

    }

    public void ExitGame()
    {

    }
}
