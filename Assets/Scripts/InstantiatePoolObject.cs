using System.Collections.Generic;
using UnityEngine;

public class InstantiatePoolObject : MonoBehaviour
{
    [SerializeField]
    private GameObject _prefab;
    [SerializeField]
    private Transform _parent;
    private List<GameObject> _pool = new List<GameObject>();
    private GameObject GetObject()
    {
        foreach (var obj in _pool)
        {
            if (!obj.activeInHierarchy)
            {
                return obj;
            }
        }
        var newObj = Instantiate(_prefab);
        _pool.Add(newObj);
        return newObj;
    }
    public void InstantiateObject(Transform target)
    {
        var obj = GetObject();
        SetObjecPosition(obj, target.position, target.rotation);

    }
    public void InstantiateObject(Vector3 position)
    {
        var obj = GetObject();
        SetObjecPosition(obj, position, Quaternion.identity);

    }
    public void SetObjecPosition(GameObject obj, Vector3 position, Quaternion rotation)
    {
        if (_parent != null)
        {
            obj.transform.SetParent(_parent);
            obj.transform.SetLocalPositionAndRotation(position, rotation);

        }
        else
        {
            obj.transform.SetPositionAndRotation(position, rotation);
        }
        obj.SetActive(true);



    }
    public void DeactivateAllObjects()
    {
        foreach (var obj in _pool)
        {
            obj.SetActive(false);
        }
    }



    
}
