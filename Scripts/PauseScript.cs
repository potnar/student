using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PauseScript : MonoBehaviour
{
    public GameObject pauseBackground;
    public GameObject pause;
    public Toggle pauseToggle;
    private void Start()
    {
        pauseBackground.gameObject.SetActive(false);
    }
    // Update is called once per frame
    public void Pause()
    {
        if (pauseToggle.isOn)
        {
            pauseBackground.gameObject.SetActive(false);
            Time.timeScale = 1f;
        }else
        {
            pauseBackground.gameObject.SetActive(true);
            Time.timeScale = 0f;
        }
    }
}
