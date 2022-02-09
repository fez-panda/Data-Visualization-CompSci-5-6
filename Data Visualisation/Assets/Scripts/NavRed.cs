using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavRed : MonoBehaviour
{
    private float randomness;
    private float randomness2;
    private float randomness3;
    public GameObject prefabed;
    private Vector3 scaleChange;
    private Vector3 selfposition;
    public Transform copy;

    [SerializeField]   

    NavMeshAgent _navMeshAgent;
    // Start is called before the first frame update
    void Start()
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();

        if(_navMeshAgent == null) 
        {
            Debug.LogError("The nav mesh agent component is not attatched to " + gameObject.name);
        }
        else 
        {
            SetDestination();
        }
    }

    private void SetDestination() 
    {
        randomness = Random.Range(0, 100);
        if (randomness >= 90) {
            Vector3 targetVector = new Vector3(21f, .5f, 21f);
            _navMeshAgent.SetDestination(targetVector);
        } else if(randomness >= 80) {
            Vector3 targetVector = new Vector3(21f, .5f, 11.5f);
            _navMeshAgent.SetDestination(targetVector);
        } else if (randomness >= 70) {
            Vector3 targetVector = new Vector3(21f, .5f, 3f);
            _navMeshAgent.SetDestination(targetVector);
        } else if (randomness >= 60) {
            Vector3 targetVector = new Vector3(21f, .5f, -4.5f);
            _navMeshAgent.SetDestination(targetVector);
        } else if (randomness >= 50) {
            Vector3 targetVector = new Vector3(21f, .5f, -13f);
            _navMeshAgent.SetDestination(targetVector);
        } else {
            Vector3 targetVector = new Vector3(21f, .5f, -22f);
            _navMeshAgent.SetDestination(targetVector);
        }
    }

    void Update() {
        if (this.transform.position.x >= 20.5f) {
            Destroy(prefabed);
        };
    }
}
