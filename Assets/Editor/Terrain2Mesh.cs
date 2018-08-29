using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

/// <summary>
/// 将高度图转换为mesh 并切割
/// </summary>
public class Terrain2Mesh
{

    [MenuItem("Terrain/Height2Mesh")]
    static void Height2Mesh()
    {
        Terrain terrain = GameObject.FindObjectOfType<Terrain>();
        if (terrain == null)
        {
            Debug.LogError("找不到地形!");
            return;
        }
        TerrainData terrainData = terrain.terrainData;
        Vector3 size = terrainData.size;
        Debug.Log(size+" "+terrainData.heightmapHeight);

        int grid = Mathf.CeilToInt(size.x);
        for (int i = 0; i < grid; i++)
        {
            for (int j = 0; j < grid; j++)
            {

            }
        }
    }
	
}
