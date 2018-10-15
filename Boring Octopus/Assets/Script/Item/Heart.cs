﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heart : MonoBehaviour {
    //SE
    public AudioClip pickUpSE;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            AudioSource.PlayClipAtPoint(pickUpSE, new Vector3(0, 0, 0), AudioManager.seVolume);
            GameObject.Find("Manager").GetComponent<StateManager>().ChangeHP(1);
            Destroy(gameObject);
        }
    }
}
