using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicScript : MonoBehaviour
{
    public AudioSource win;
    public AudioSource lose;

    private void Start()
    {
        if (ScoreManager.Instance.GetScore() != 100) { lose.Play(); }
        else { win.Play(); }
    }
}
