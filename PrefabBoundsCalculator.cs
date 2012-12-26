using UnityEngine;
using System.Collections;

public class PrefabBoundsCalculator {
  private GameObjectBoundsCalculator gameObjectBoundsCalculator;

  public PrefabBoundsCalculator() {
    gameObjectBoundsCalculator = new GameObjectBoundsCalculator();
  }

  public Bounds Calculate(GameObject gameObject) {
    GameObject instance = GameObject.Instantiate(gameObject, Vector3.zero, Quaternion.identity) as GameObject;
    Bounds bounds = gameObjectBoundsCalculator.Calculate(instance);
    GameObject.Destroy(instance);
    return bounds;
  }
}

