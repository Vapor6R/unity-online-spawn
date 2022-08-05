using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
public class spawn : MonoBehaviour
{
    public GameObject playerPrefabs;
	public Transform[] spawnPoints;
    private void Start()
    {
        int randomNumber = Random.Range(0, spawnPoints.Length);
		Transform spawnPoint = spawnPoints[randomNumber];
		PhotonNetwork.Instantiate(playerPrefabs.name, spawnPoint.position, Quaternion.identity);
    }

}
