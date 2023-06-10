using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class PRS : MonoBehaviour
{
    float speed = 3.8f;
    PlayerInput _playerInput;
    private Vector3 _velocity;
    public GameObject _shot;
    bool canshot = false;

    public SpriteRenderer playersprite;
    public Sprite[] reimu = new Sprite[3];
    // Start is called before the first frame update
    void Start()
    {
     
       /// StartCoroutine("shotaction");
    }

    // Update is called once per frame
    void Update()
    {
        /*  if (_playerInput.Player.Move.triggered)
          {
              Debug.Log(_playerInput.Player.Move);
          }*/

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            speed = 2.1f;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            speed = 3.8f;
        }
        transform.position += _velocity * Time.deltaTime;
    }
    public void OnMove(InputAction.CallbackContext context)
    {
        // MoveAction‚Ì“ü—Í’l‚ğæ“¾
        var axis = context.ReadValue<Vector2>();

        // ˆÚ“®‘¬“x‚ğ•Û
        _velocity = new Vector3(axis.x, 0, axis.y);
        if (axis.x < 0)
        {
            playersprite.sprite = reimu[1];
        }
        if (axis.x > 0)
        {
            playersprite.sprite = reimu[2];
        }
        if (axis.y > 0)
        {
            playersprite.sprite = reimu[0];
        }
        if (axis.y < 0)
        {
            playersprite.sprite = reimu[0];
        }
        if (axis.y == 0&& axis.x == 0)
        {
            playersprite.sprite = reimu[0];
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "danmaku")
        {

        }
    }
    IEnumerator shotaction()
    {
        while (canshot)
        {
            Instantiate(_shot, transform.position - new Vector3(0, 1, 0),Quaternion.identity);
            yield return new WaitForSeconds(0.5f); }
    }
}
