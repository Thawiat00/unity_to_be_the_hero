using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;



// This example shows how both version of Get could be used to simplify a line of points.
public class Simplify2DLine : MonoBehaviour
{
    public List<Vector2> SimplifyLine(Vector2[] points)
    {
        // This version will only be returned to the pool if we call Release on it.
        var simplifiedPoints = CollectionPool<List<Vector2>, Vector2>.Get();
      //  var simplifiedPoints_2 = CollectionPool<List<Vector2>, Vector2>.Release();

        // Copy the points into a temp list so we can pass them into the Simplify method
        // When the pooled object leaves the scope it will be Disposed and returned to the pool automatically.
        // This version is ideal for working with temporary lists.
        using (CollectionPool<List<Vector2>, Vector2>.Get(out List<Vector2> tempList))
        {
            for (int i = 0; i < points.Length; ++i)
            {
                tempList.Add(points[i]);
            }

            LineUtility.Simplify(tempList, 1.5f, simplifiedPoints);
        }
        return simplifiedPoints;
    }

    //overview
    //if you save variable hard variable(collection) can use  CollectionPool for do task complete
    /*
    Description
    A Collection such as List, HashSet, Dictionary etc can be pooled and reused by using a CollectionPool.

    Note the CollectionPool is not thread-safe. Additional resources: DictionaryPool<T0,T1>, HashSetPool<T0>, ListPool<T0>.

     */
}
