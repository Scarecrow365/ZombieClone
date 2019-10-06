using System.Collections;
using UnityEngine;

public class ZombieSpawn : MonoBehaviour
{

    [SerializeField] private GameObject[] _zombiePrefab;
    [SerializeField] private float _maxRepeatRate;

    void Start()
    {
        StartCoroutine("Timer");
    }

    void CreateZombie()
    {
        GameObject zombie = _zombiePrefab[Random.Range(0, _zombiePrefab.Length)];
        Instantiate(zombie, transform.position, zombie.transform.rotation);
    }

    public IEnumerator Timer()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(0.5f, _maxRepeatRate));
            CreateZombie();
        }
    }
}
