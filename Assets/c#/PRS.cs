using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;
using static System.Net.Mime.MediaTypeNames;
using UnityEngine.SceneManagement;

public class PRS : MonoBehaviour
{
    float speed = 5.6f;
    PlayerInput _playerInput;
    private Vector3 _velocity;
    public GameObject _shot;
    bool canshot = false;
    [SerializeField] GameObject atarihanntei;

    public SpriteRenderer playersprite;
    public Sprite[] reimu = new Sprite[3];

    AudioSource audioSource;
    public AudioClip pityu;
    public AudioClip shot;
    float span = 0.05f;
    private float Tm = 0f;
    public static bool hidann = false;

    public GameObject akahaikei;
    public Button first;
    // Start is called before the first frame update
    void Start()
    {
        _playerInput = new PlayerInput();
        _playerInput.Enable();
        audioSource = GetComponent<AudioSource>();
        akahaikei.SetActive(false);
        hidann = false;
        akahaikei.SetActive(false);
        // StartCoroutine("shotaction");
    }

    // Update is called once per frame
    void Update()
    {
        if (hidann == true)
        {
            canshot = false;
            return;
        } 
        var iti = transform.position;
          if (_playerInput.Player.teisoku.triggered)
          {
            speed = 2.5f;

            atarihanntei.SetActive(true);
        }
        if (_playerInput.Player.Noteisoku.triggered)
        {
            speed = 5.6f;

            atarihanntei.SetActive(false);
        }
        if (_playerInput.Player.shot.triggered)
        {
            canshot = true;
            StartCoroutine("shotaction");

        }
        if (_playerInput.Player.noshot.triggered)
        {
            canshot = false;
            Debug.Log(canshot);
        }

        iti += _velocity * Time.deltaTime * speed;
        iti.x = Mathf.Clamp(iti.x, -6.25f, 5.78f);
        iti.y = Mathf.Clamp(iti.y, -4.45f, 4.45f);
        transform.position = iti;
        //if (canshot)
        {
            //Tm += Time.deltaTime;
            if (Tm > span)
            {
              //  audioSource.PlayOneShot(shot);
                Tm = 0f;
            }
            
        }
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        // MoveActionÇÃì¸óÕílÇéÊìæ
        var axis = context.ReadValue<Vector2>();

        // à⁄ìÆë¨ìxÇï€éù
        _velocity = new Vector3(axis.x, axis.y ,0);
        if (axis.x < -0.1f)
        {
            playersprite.sprite = reimu[1];
        }
        else if (axis.x > 0)
        {
            playersprite.sprite = reimu[2];
        }
        else
        {
            playersprite.sprite = reimu[0];
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "danmaku" | other.gameObject.tag == "enmy")
        {
            Debug.Log("okd");
            hidann = !hidann;
            M M;
            GameObject game = GameObject.Find("timer");
            M = game.GetComponent<M>();
            M.stop = 0;
            audioSource.PlayOneShot(pityu);
            Invoke("slect", 1.0f);
          
        }
    }
    IEnumerator shotaction()
    {


        while (canshot)
        {
            Instantiate(_shot, transform.position - new Vector3(0, 1, 0), Quaternion.identity);
            yield return new WaitForSeconds(0.1f);
        }
        Debug.Log(canshot);
        //StartCoroutine("shotaction");
    }

    public void slect()
    {
        akahaikei.SetActive(true);
        //_playerInput.Player.Disable();
        //_playerInput.UI.Enable();
        first.Select();       
        //SceneManager.LoadScene("StageSlect1");
    }
    void shotSE()
    {
        audioSource.PlayOneShot(shot);
    }
    void end()
    {
        SceneManager.LoadScene("StageSlect1");
    }
    public void ito()
    {
        Invoke("end", 1.0f);
    }

}
