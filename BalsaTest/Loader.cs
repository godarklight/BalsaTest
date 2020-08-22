using System;
using BalsaCore;
namespace BalsaTest
{
    //Without this file Balsa craps out on the load
    [BalsaAddon]
    public class Loader
    {
        [BalsaAddonInit]
        public static void BalsaInit()
        {

        }

        [BalsaAddonFinalize]
        public static void BalsaFinalize()
        {

        }
    }
}
