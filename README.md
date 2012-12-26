Bounds calculators

```
    Bounds bounds = new GameObjectBoundsCalculator().Calculate(gameObject);
    # => Center: (0.0, 0.8, 0.0), Extents: (0.5, 0.8, 0.5)

    bounds.size
    # => (1.0, 1.6, 1.0)
```

The scripts come in two flavors:

* GameObjectBoundsCalculator for regular instantiated GameObjects
* PrefabBoundsCalculator for prefabs

They both use Collider bounds for their calculations.  If that's not what you
want, you could modify GameObjectsBoundsCalculator to use one of these:

* Renderer.bounds: http://docs.unity3d.com/Documentation/ScriptReference/Renderer-bounds.html
* Mesh.bounds: http://docs.unity3d.com/Documentation/ScriptReference/Mesh-bounds.html

PrefabBoundsCalculator is a little special.  There appears to be no way to get
the bounds of a Prefab without instantiating it, so this class does the naive
thing by instantiating it briefly, grabbing the bounds, then deleting it.  I was
able to use this without unforseen side-effects, but you know, I have no idea
what kind of city-sized meshes you guys out there are building.

Contact me if you've got any questions, bugs or contract work to throw my way.

Cheers.
