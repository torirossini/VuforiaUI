using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject[] panels;
    private GameObject currentPanel;


	// Use this for initialization
	void Start ()
    {
        currentPanel = panels[0];
        for (int i = 0; i<panels.Length; i++)
        {
            if (i != 0)
            {
                panels[i].SetActive(false);
            }
        }
        
	}
	
	// Update is called once per frame
	void Update ()
    {

	}
    public void SwitchScenes(int panelIndex)
    {
        currentPanel.SetActive(false);
        panels[panelIndex].SetActive(true);
        currentPanel = panels[panelIndex];
        Debug.Log(currentPanel);
        Debug.Log(currentPanel.activeInHierarchy);
    }
}
