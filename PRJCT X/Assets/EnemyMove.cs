using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMove : MonoBehaviour
{

    [SerializeField]
    Transform _destination;
    NavMeshAgent _NavMeshAgent;
    // Start is called before the first frame update
    void Start()
    {
        _NavMeshAgent = this.GetComponent<NavMeshAgent>();

        if(_NavMeshAgent == null)
        {
            Debug.LogError(" the nav mesh agent component is not attaced to " + gameObject.name);
        }
        else
        {
            SetDestination();
        }

    }

        private void SetDestination()
        {
            if(_destination != null)
            {
                Vector3 targetVector = _destination.transform.position;
                _NavMeshAgent.SetDestination(targetVector);


            }
        }



    // Update is called once per frame
    void Update()
    {
        
    }
}
