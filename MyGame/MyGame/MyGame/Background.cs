using System;
using System.Collections.Generic;
using System.Text;
using Urho;

namespace MyGame
{
    public class Background : Component
    {
        //Node tile;

        //const float BackgroundRotationX = 45f;
        //const float BackgroundRotationY = 15f;
        //const float BackgroundScale = 40f;
        //const float BackgroundSpeed = 0.05f;
        //const float FlightHeight = 10f;

        //public void Start()
        //{
        //    tile = CreateTile();
        //}

        //Node CreateTile()
        //{
        //    var cache = Application.ResourceCache;
        //    Node tile = Node.CreateChild();
        //    var planeNode = tile.CreateChild();
        //    planeNode.Scale = new Vector3(BackgroundScale, 0.0001f, BackgroundScale);
        //    var planeObject = planeNode.CreateComponent<StaticModel>();
        //    planeObject.Model = cache.GetModel(Assets.Models.Plane);
        //    //planeObject.SetMaterial(cache.GetMaterial(Assets.Materials.Grass));
        //    planeObject.SetMaterial(cache.GetMaterial("Assets/Materials/Grass.xml"));

        //    // area for trees:
        //    var sizeZ = BackgroundScale / 2.1f;
        //    var sizeX = BackgroundScale / 3.8f;

        //    Node treeNode = tile.CreateChild();
        //    treeNode.Rotate(new Quaternion(0, RandomHelper.NextRandom(0, 5) * 90, 0), TransformSpace.Local);
        //    treeNode.Scale = new Vector3(0.3f, 0.4f, 0.3f);
        //    var treeGroup = treeNode.CreateComponent<StaticModel>();
        //    treeGroup.Model = cache.GetModel(Assets.Models.Tree);
        //    treeGroup.SetMaterial(cache.GetMaterial(Assets.Materials.Pyramid));
        //    //treeGroup.SetMaterial(ResourceCache.GetModel("Models/Pyramid.mdl"));

        //    for (float i = -sizeX; i < sizeX; i += 3.2f)
        //    {
        //        for (float j = -sizeZ; j < sizeZ; j += 3.2f)
        //        {
        //            var clonedTreeNode = treeNode.Clone(CreateMode.Local);
        //            clonedTreeNode.Position = new Vector3(i + RandomHelper.NextRandom(-0.3f, 0.3f), 0, j);
        //        }
        //    }

        //    treeNode.Remove();

        //    tile.Rotate(new Quaternion(270 + BackgroundRotationX, 0, 0), TransformSpace.Local);
        //    tile.RotateAround(new Vector3(0, 0, 0), new Quaternion(0, BackgroundRotationY, 0), TransformSpace.Local);
        //    var tilePosX = BackgroundScale * (float)Math.Sin(MathHelper.DegreesToRadians(90 - BackgroundRotationX));
        //    var tilePosY = BackgroundScale * (float)Math.Sin(MathHelper.DegreesToRadians(BackgroundRotationX));
        //    tile.Position = new Vector3(0, 0, 0 + FlightHeight);
        //    return tile;
        //}
    }
}
