﻿using Mogre;
using Mogre.PhysX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AMOFGameEngine.Game
{
    public class Crossbow : Item
    {
        public Crossbow(string desc, string meshName, Scene physicsScene, Camera cam) :
            base(desc, meshName, ItemType.IT_CROSSBOW, ItemHaveAttachOption.IHAO_BACK_FROM_LEFT_TO_RIGHT, ItemUseAttachOption.IAO_LEFT_HAND, physicsScene, cam)
        {

        }

        public override Type Ammo
        {
            get
            {
                return typeof(Bolt);
            }
        }

        public override int Range
        {
            get
            {
                return 1200;
            }
        }

        public override double Damage
        {
            get
            {
                return 25;
            }
        }
    }
}
