using System.Collections;
using UnityEngine;
using Random = UnityEngine.Random;

public class BlockSpawner : MonoBehaviour
{
    [SerializeField] private BlockMover[] _blockTemplates;

    [SerializeField] private SpawnPoint[] _spawnPoints;
    
    [SerializeField] private float _minTimeToSpawn;
    [SerializeField] private float _maxTimeToSpawn;

    private void Start() => StartCoroutine(Timer());

    private IEnumerator Timer()
    {
        while (true) //if gamePaused
        {
            SpawnBlocks();
            
            float timeToWait = Random.Range(_minTimeToSpawn, _maxTimeToSpawn);
            
            yield return new WaitForSeconds(timeToWait);
        }
    }

    private void SpawnBlocks()
    {
        foreach (var spawnPoint in _spawnPoints)
        {
            int randomBlockIndex = Random.Range(0, _blockTemplates.Length);
            BlockMover block = Instantiate(_blockTemplates[randomBlockIndex], spawnPoint.transform.position, Quaternion.identity);
        }
    }
}
