﻿using GameObjects;
using GameObjects.Influences;
using System;


using System.Runtime.Serialization;namespace GameObjects.Influences.InfluenceKindPack
{
    
    [DataContract]public class InfluenceKind630 : InfluenceKind
    {
        private float increment;


        public override void ApplyInfluenceKind(Troop troop)
        {
            troop.IncrementOffenceRate += this.increment;
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.increment = float.Parse(parameter);
            }
            catch
            {
            }
        }

        public override void PurifyInfluenceKind(Troop troop)
        {
            troop.IncrementOffenceRate -= this.increment;
        }
    }
}

