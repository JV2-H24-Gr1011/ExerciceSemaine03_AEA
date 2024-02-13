using UnityEngine;
public class SpawnOnPositions : MonoBehaviour
{

    [SerializeField]

    private Vector3 zoneSize2;

    [SerializeField]
    private GameObject cubePrefab2;

    [SerializeField]
    private Transform[] spawnPoints;
    void Update()
    {
        
    }
void Spawn2()
{
Transform randomPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

GameObject instantiated = Instantiate(cubePrefab2);
instantiated.transform.position = randomPoint.position;
}
    void Start(){
        InvokeRepeating("Spawn2", 0f, 0.5f);
    }

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, zoneSize2);
    }
}



