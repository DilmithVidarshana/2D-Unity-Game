using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerControll : MonoBehaviour
{
    [SerializeField]
    private float _MoveSpeed = 7.0f;
    private Rigidbody2D _rbody;
    private Animator _animator;
        [SerializeField]
    private float _jumpForce = 9.0f;
    private bool _isground;
       
        Audio audio;
    [SerializeField] private GameObject _gameOverPanel;

    // Start is called before the first frame update
    void Start()
    {
        _rbody = GetComponent<Rigidbody2D>();
        
    }
     private void Awake()

    {
        audio = GameObject.FindGameObjectWithTag("audi").GetComponent<Audio>();
    }
    

    // Update is called once per frame
    void Update()
    {
        playerJump();
    }
    void FixedUpdate()
    {
        PlayerMove();
    }
    private void PlayerMove()
    {
        if(Input.GetAxisRaw("Horizontal") > 0f)
        {
            _rbody.velocity = new Vector2(_MoveSpeed,_rbody.velocity.y);
            transform.localScale = new Vector3(1f,transform.localScale.y,transform.localScale.z);
            _animator.SetBool("Walk",true);
        }
        else if(Input.GetAxisRaw("Horizontal")<0f)
        {
            _rbody.velocity = new Vector2(-_MoveSpeed,_rbody.velocity.y);
            transform.localScale = new Vector3(-1f,transform.localScale.y,transform.localScale.z);
            _animator.SetBool("Walk",true);
        }
      
        else{
            _rbody.velocity = new Vector2(0f,_rbody.velocity.y);
          
        }
    }
    private void playerJump()
    {
       if(Input.GetKeyDown(KeyCode.Space) && _isground)
       {
       _rbody.AddForce(Vector2.up * _jumpForce,ForceMode2D.Impulse);
       _isground = false;
       }
    }
    private void OnCollisionEnter2D(Collision2D target)
    {
        if(target.gameObject.tag == "Ground")
        {
            _isground = true;
        }
    }
     private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "Enamy")
        {
            _gameOverPanel.SetActive(true);
            Time.timeScale = 0;
                audio.PlaySFX(audio.Dead);
        }
        
        if(target.tag == "Enamy1")
        {
            _gameOverPanel.SetActive(true);
            Time.timeScale = 0;
                audio.PlaySFX(audio.Dead);
        }
      
    }
}
