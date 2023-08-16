using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject prefab;
    public float spawnRate = 1f;
    public float minHeight = -1;
    public float maxhHeight = 1f;

    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate, spawnRate);
    }

    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }

    private void Spawn()
    {
        GameObject pipes = Instantiate(prefab, transform.position, Quaternion.identity);
        pipes.transform.position +=  Vector3.up * Random.Range(minHeight, maxhHeight); 
    }

}
