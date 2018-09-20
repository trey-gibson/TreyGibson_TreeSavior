using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeController : MonoBehaviour {

    public List<GameObject> PrefabsToSpawn = new List<GameObject>();

    public List<Vector3> SpawnOffsets = new List<Vector3>();

    public float SpawnDelay = 0.1f;
    public float MoveSpeed = 1f;
    public float RotationSpeed = 1f;
    public float acceleration;
    public float LessDelay;
    public List<Transform> AcornList;

    private void Start()
    {
        StartCoroutine(WaitToSpawn());
    }

    IEnumerator WaitToSpawn()
    {
        SpawnObject();

        yield return new WaitForSeconds(SpawnDelay);

        StartCoroutine(WaitToSpawn());
    }


    void SpawnObject()
    {
        GameObject _newTreePiece;

        if (SpawnOffsets.Count > 0)
        {
            _newTreePiece =  Instantiate(PrefabsToSpawn[Random.Range(0, PrefabsToSpawn.Count)], transform.position + SpawnOffsets[Random.Range(0, SpawnOffsets.Count)], Quaternion.identity);
        }
        else
        {
            _newTreePiece = Instantiate(PrefabsToSpawn[Random.Range(0, PrefabsToSpawn.Count)], transform.position, Quaternion.identity);
        }

        TreeComponent _treeComponent = _newTreePiece.GetComponent<TreeComponent>();
        _treeComponent.MoveSpeed = MoveSpeed;
        _treeComponent.RotationSpeed = RotationSpeed;

    }
    private void Update()
    {
        //MoveSpeed += Time.deltaTime * acceleration;
        //SpawnDelay -= Time.deltaTime * LessDelay;
        MoveSpeed = Mathf.Clamp((MoveSpeed + (1.1f * (Time.deltaTime * acceleration))), 2, 7);
        SpawnDelay = Mathf.Clamp((SpawnDelay - (Time.deltaTime * LessDelay)), 0.095f, 7);
        //MoveSpeed = Mathf.Clamp((Time.deltaTime * LessDelay), 1, 3);
    }
}
