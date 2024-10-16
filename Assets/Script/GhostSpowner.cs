using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GhostSpowner : MonoBehaviour
{
     [SerializeField]
    private GameObject _ghost;
    [SerializeField]
    private float _starteDelay = 4.0f;
     [SerializeField]
    private float _repatrate = 4.0f;
    private Vector3 _spowner = new Vector3(-44.0f,1.3f,0f);

      Audio audio;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpowanGhost",_starteDelay,_repatrate);
    }
     private void Awake()

    {
        audio = GameObject.FindGameObjectWithTag("audi").GetComponent<Audio>();
    }
    private void SpowanGhost()
    {
        Instantiate(_ghost,_spowner,_ghost.transform.rotation);
            audio.PlaySFX(audio.CharacterSound);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
   
}
