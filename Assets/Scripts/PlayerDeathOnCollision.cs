using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeathOnCollision : MonoBehaviour {
	
    void OnTriggerEnter(Collider other) {
        // I don't think that's how it works
        //string sWhoDied = other.GetComponent(name).ToString();
        //string sHowTheyDied = gameObject.GetComponent(name).ToString();
        // return to closest respawn area 
        // Maybe have a respawnarea give a player a vec3 location where 
        // it can respawn on trigger enter (or exit)
        // have the starting locations be respawnAreas
    }
}
