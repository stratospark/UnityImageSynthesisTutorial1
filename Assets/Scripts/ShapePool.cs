using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ShapeLabel { Cube, Sphere, Cylinder };

public class Shape {
    public ShapeLabel label;
    public GameObject obj;
}

public class ShapePool : ScriptableObject
{
    private GameObject[] prefabs;
    private Dictionary<ShapeLabel, List<Shape>> pools;
    private List<Shape> active;

    public static ShapePool Create(GameObject[] prefabs) {
        var p = ScriptableObject.CreateInstance<ShapePool>();
        p.prefabs = prefabs;
        p.pools = new Dictionary<ShapeLabel, List<Shape>>();
        for (int i = 0; i < prefabs.Length; i++) {
            p.pools[(ShapeLabel)i] = new List<Shape>();
        }
        p.active = new List<Shape>();
        return p;
    }

    public Shape Get(ShapeLabel label) {
        var pool = pools[label];
        int lastIndex = pool.Count - 1;
        Shape retShape;
        if (lastIndex <= 0) {
            var obj = Instantiate(prefabs[(int)label]);
            retShape = new Shape() { label = label, obj = obj };
        } else {
            retShape = pool[lastIndex];
            retShape.obj.SetActive(true);
            pool.RemoveAt(lastIndex);
        }
        active.Add(retShape);
        return retShape;
    }

    public void ReclaimAll() {
        foreach (var shape in active) {
            shape.obj.SetActive(false);
            pools[shape.label].Add(shape);
        }
        active.Clear();
    }
}
