using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterTwo : MonoBehaviour
{
    [SerializeField]
    private GameObject _monstertwo;
      [SerializeField]
      private float _startDelay = 4.0f;
      [SerializeField]
      private float _repeat = 4.0f;
      private Vector3 _spowner = new Vector3(38.0f,-0.4f,0f);
        Audio audio;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("monstertwo",_startDelay,_repeat);
    }
    private void Awake()

    {
        audio = GameObject.FindGameObjectWithTag("audi").GetComponent<Audio>();
    }
    private void monstertwo()
    {
        Instantiate(_monstertwo,_spowner,_monstertwo.transform.rotation);
            audio.PlaySFX(audio.CharacterSound);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
