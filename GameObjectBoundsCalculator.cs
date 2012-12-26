using UnityEngine;
using System.Collections;

public class GameObjectBoundsCalculator {
  public Bounds Calculate(GameObject gameObject) {
    Bounds bounds = new Bounds(Vector3.zero, Vector3.zero);
    Collider[] colliders = gameObject.GetComponentsInChildren<Collider>();

    foreach (Collider collider in colliders) {
      bounds.Encapsulate(collider.bounds);
    }

    return bounds;
  }
}

