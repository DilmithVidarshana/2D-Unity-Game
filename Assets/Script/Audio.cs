using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
      [SerializeField] AudioSource musicSource;
      [SerializeField] AudioSource SFXSource;

  public AudioClip background;
  public AudioClip Dead;
  public AudioClip CharacterSound;

    private void Start()
    {
      
    }

    // Update is called once per frame
    public void PlaySFX(AudioClip clip)

    {
       SFXSource.PlayOneShot(clip);
    }
}
