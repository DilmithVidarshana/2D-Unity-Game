using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster1 : MonoBehaviour
{  [SerializeField]
    private GameObject _moonster1;
    [SerializeField]
    private float _StartDelay = 2.5f;
    [SerializeField]
    private float _repeate =2.5f;
    private Vector3 _spowner = new Vector3(-42f,-1.5f,0f);
     Audio audio;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MonsterOne",_StartDelay,_repeate);
    }
    private void Awake()

    {
        audio = GameObject.FindGameObjectWithTag("audi").GetComponent<Audio>();
    }
    private void MonsterOne()
    {
        Instantiate(_moonster1,_spowner,_moonster1.transform.rotation);
         audio.PlaySFX(audio.CharacterSound);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    
}
