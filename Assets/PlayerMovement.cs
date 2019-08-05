using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 05f;
    public VJHandler jsMovement;

    private Vector3 direction;
    private float xMin, xMax, yMin, yMax;
    public Text candy;
    public int candyCurrent;
    public int candyMax;
    public int level;
    public Text gameOver;
    public Button buttons;
    public Text stageWin;
    public GameObject joyStick;
    public int isDead = 0;
    void Update()
    {
        candy.text = "Candy: " + candyCurrent + "/" + candyMax;

        direction = jsMovement.InputDirection; //InputDirection can be used as per the need of your project

        if (direction.magnitude != 0)
        {
            if (isDead == 0)
            {
                transform.position += direction * moveSpeed;
                transform.position = new Vector3(transform.position.x, 3.54f, transform.position.z);//to restric movement of player
            }
            }
    }

    void Start()
    {

        //Initialization of boundaries
        xMax = Screen.width - 50; // I used 50 because the size of player is 100*100
        xMin = 50;
        yMax = Screen.height - 50;
        yMin = 50;
        candy.text = "Candy: " + candyCurrent + "/" + candyMax; 
    }
    public void restart()
    {
        SceneManager.LoadScene("SampleScene", LoadSceneMode.Single);

    }
    void OnTriggerEnter(Collider other)
    {
       // Debug.Log("hi");
        if (other.gameObject.tag == "Candy")
        {
         //   Debug.Log("Hi!");
            other.gameObject.SetActive(false);
            candyCurrent = candyCurrent + 1;

        }
        if (other.gameObject.tag == "Enemy")
        {
            Debug.Log("gameover!");
            isDead = 1;
            gameOver.gameObject.SetActive(true);
            buttons.gameObject.SetActive(true);
            //other.gameObject.SetActive(false);
          //  candyCurrent = candyCurrent + 1;

        }
        if (other.gameObject.tag == "Exit")
        {
            Debug.Log("gameover!");
            isDead = 1;
            //gameOver.gameObject.SetActive(true);
            buttons.gameObject.SetActive(true);
            stageWin.gameObject.SetActive(true  );
            //  candyCurrent = candyCurrent + 1;

        }
    }




}