using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeepInCenter : MonoBehaviour {

    [SerializeField] private Transform parent;

    private void LateUpdate() {
        transform.position = parent.position;
    }
}