using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
  [SerializeField] private KeyCode camKey;

  public GameObject player;

  private Vector3 thirdPlayerOffset = new Vector3(0, 4, -6);
  private Vector3 firstPersonOffset = new Vector3(0, 2.1f, 1.2f);
  private int camMode;
  private Vector3 offset;

  // Start is called before the first frame update
  void Start()
  {

  }

  private void Update()
  {
    if (Input.GetKeyDown(camKey))
      camMode++;
    switch(camMode)
    {
      case 0:
        offset = thirdPlayerOffset;
        break;
      case 1:
        offset = firstPersonOffset;
        break;
      default:
        camMode = 0;
        break;
    }
  }

  // Update is called once per frame
  void LateUpdate()
  {
    // Offset the camera behind the player by adding to the player's position
    transform.position = player.transform.position + offset;

  }
}
