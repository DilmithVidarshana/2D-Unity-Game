using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControll : MonoBehaviour
{
    private Transform _player;
     [SerializeField]
     private float _xrange =40.0f;
      [SerializeField]
     private float _yrange =2.85f;
    // Start is called before the first frame update
    void Start()
    {
        _player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        camerafollwe();
    }
    private void camerafollwe()
    {
      Vector3 _tempPoss = transform.position;
      _tempPoss.x = _player.position.x;

      if(_tempPoss.x > _xrange)
      {
          _tempPoss.x = _xrange;
      }
      if(_tempPoss.x < -_xrange)
      {
          _tempPoss.x = -_xrange;
      }
      _tempPoss.y =_player.position.y + _yrange;
      transform.position = _tempPoss;
    }
}
