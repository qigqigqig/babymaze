using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    public GameObject joystick;
    RectTransform m_RectTransform;
    private bool swapper = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void restart()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);

    }
    public void swap()
    {
        if (swapper == false)
        {
            m_RectTransform = joystick.GetComponent<RectTransform>();
            m_RectTransform.anchorMin = new Vector2(1, 0);
            m_RectTransform.anchorMax = new Vector2(1, 0);
            m_RectTransform.anchoredPosition = new Vector3(-106, 120.4f);
            swapper = true;
        }
        else if (swapper == true)
        {
            m_RectTransform = joystick.GetComponent<RectTransform>();
            m_RectTransform.anchorMin = new Vector2(0, 0);
            m_RectTransform.anchorMax = new Vector2(0, 0);
            m_RectTransform.anchoredPosition = new Vector3(118.5f, 120.4f);
            swapper = false;
        }
    }
}
