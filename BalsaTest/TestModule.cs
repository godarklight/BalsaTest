using System;
using Modules;
using UnityEngine;

namespace BalsaTest
{
    public class TestModule : PartModule
    {
        public override void OnModuleSpawn()
        {
            Debug.Log("[TestModule] Spawned");
        }
    }
}
