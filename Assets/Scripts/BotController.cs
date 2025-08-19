using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotController : MonoBehaviour
{
  [SerializeField] private float botSpeed = 10f;
  // Start is called before the first frame update
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {
    transform.Translate(Vector3.forward *  botSpeed * Time.deltaTime);
  }
}
