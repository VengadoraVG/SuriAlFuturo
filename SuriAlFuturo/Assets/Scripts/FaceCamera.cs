using UnityEngine;
using System.Collections;

public class FaceCamera : MonoBehaviour {
    public GameObject _camera;

    void Start () {
        _camera = GameObject.FindGameObjectWithTag(Tag.MainCamera);
    }

    void Update () {
        transform.forward = _camera.transform.forward;
    }
}
