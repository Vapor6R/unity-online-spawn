using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Realtime;
using Photon.Pun;

public class GameManager : MonoBehaviourPunCallbacks
{
public gameObject playerPrefab;
void Start()
{
PhotonNetwork.instantiate(this.playerPrefab.name,new vector3(0,1,0), Quaternion.indentity, )
}
public void OnPlayerEnterRoom(Player other)
{
print(other.Nickname + " has connected!");
}
public void OnPlayerleftRoom(Player other)
{
print(other.Nickname + " has disconnected!");
}
public void OnleftRoom(Player other)
{
SceneManager.LoadScene("Lobby");
}
public void LeaveRoom()
{
PhotonNetwork.LeaveRoom();
}
