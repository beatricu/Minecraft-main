﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class VoxelData {

	public static readonly int ChunkWidth = 16;
	public static readonly int ChunkHeight = 128;
    public static readonly int WorldSizeInChunks = 100;

    // valori lumina
    public static float minLightLevel = 0.1f;
    public static float maxLightLevel = 0.9f;
    public static float lightFalloff = 0.08f;

    public static int WorldSizeInVoxels {

        get { return WorldSizeInChunks * ChunkWidth; }

    }


    public static readonly int TextureAtlasSizeInBlocks = 16;
    public static float NormalizedBlockTextureSize {

        get { return 1f / (float)TextureAtlasSizeInBlocks; }

    }

	public static readonly Vector3[] voxelVerts = new Vector3[8] {

		new Vector3(0.0f, 0.0f, 0.0f),
		new Vector3(1.0f, 0.0f, 0.0f),
		new Vector3(1.0f, 1.0f, 0.0f),
		new Vector3(0.0f, 1.0f, 0.0f),
		new Vector3(0.0f, 0.0f, 1.0f),
		new Vector3(1.0f, 0.0f, 1.0f),
		new Vector3(1.0f, 1.0f, 1.0f),
		new Vector3(0.0f, 1.0f, 1.0f),

	};

	public static readonly Vector3[] faceChecks = new Vector3[6] {

		new Vector3(0.0f, 0.0f, -1.0f),
		new Vector3(0.0f, 0.0f, 1.0f),
		new Vector3(0.0f, 1.0f, 0.0f),
		new Vector3(0.0f, -1.0f, 0.0f),
		new Vector3(-1.0f, 0.0f, 0.0f),
		new Vector3(1.0f, 0.0f, 0.0f)

	};

	public static readonly int[,] voxelTris = new int[6,4] {

        // Spate, Fata, Sus, Jos, Stanga

        {0, 3, 1, 2}, // fata din spate
        {5, 6, 4, 7}, // fata din fata
        {3, 7, 2, 6}, // fata de sus
        {1, 5, 0, 4}, // fata de jos
        {4, 7, 0, 3}, // fata din stanga
        {1, 2, 5, 6} // fata din dreapta

    };

    public static readonly Vector2[] voxelUvs = new Vector2[4] {

        new Vector2(0.0f, 0.0f),
        new Vector2(0.0f, 1.0f),
        new Vector2(1.0f, 0.0f),
        new Vector2(1.0f, 1.0f)

    };

}
