﻿using System.Runtime.InteropServices;
using SharpDX;

namespace WoWEditor6.IO.Files.Terrain
{
    [StructLayout(LayoutKind.Sequential)]
    struct AdtVertex
    {
        public Vector3 Position;
        public Vector3 Normal;
        public Vector2 TexCoord;
        public Vector2 TexCoordAlpha;
        public uint Color;
    }

    [StructLayout(LayoutKind.Sequential)]
    struct Modf
    {
        public readonly int Mwid;
        public readonly int UniqueId;
        public readonly Vector3 Position;
        public readonly Vector3 Rotation;
        public readonly Vector3 BboxMax;
        public readonly Vector3 BboxMin;
        public readonly ushort Flags;
        public readonly short DoodadSet;
        public readonly short NameSet;
        private readonly short padding;
    }
}