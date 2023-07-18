using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ZombieMovement : MonoBehaviour {

    private GameObject player;
    // [SerializeField] Rigidbody rb;
    public NavMeshAgent agent;

    public GameObject jumpscare;

    // [SerializeField] private int damage = 5;

    // [SerializeField] private EnemyData data;

    void Start() {
        player = GameObject.FindWithTag("Player");
        jumpscare.SetActive(false);
    }

    void Update() {
        Swarm();
    }

    void Swarm() {
        agent.enabled = true;
        agent.SetDestination(player.transform.position);
    }

    void OnTriggerEnter(Collider col) {
        agent.enabled = false;
        if(col.gameObject.name == "Player") {
            StartCoroutine(activateJumpscare());
        }
    }

    IEnumerator activateJumpscare() {
            jumpscare.SetActive(true);
            Debug.Log("Jumpscare");
            yield return new WaitForSeconds(3.24f);
            SceneManager.LoadScene(0);
    }

}
