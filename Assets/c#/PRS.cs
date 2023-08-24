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
    // Start is called before the first frame update
    void Start()
    {
        _playerInput = new PlayerInput();
        _playerInput.Enable();
        
     
       // StartCoroutine("shotaction");
    }

    // Update is called once per frame
    void Update()
    {
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

        transform.position += _velocity * Time.deltaTime * speed;
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        // MoveActionÇÃì¸óÕílÇéÊìæ
        var axis = context.ReadValue<Vector2>();

        // à⁄ìÆë¨ìxÇï€éù
        _velocity = new Vector3(axis.x, axis.y ,0);
        if (axis.x < 0)
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
            SceneManager.LoadScene("StageSlect1");
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
}
