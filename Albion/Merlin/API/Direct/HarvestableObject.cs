////////////////////////////////////////////////////////////////////////////////////
// Merlin API for Albion Online v1.0.327.94396-live
////////////////////////////////////////////////////////////////////////////////////
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by a tool.
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;

using UnityEngine;

using Albion.Common.Time;

namespace Merlin.API.Direct
{
    /* Internal type: a1k */
    public partial class HarvestableObject : StaticObject
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        
        private a1k _internal;
        
        #region Properties
        
        public a1k HarvestableObject_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        public HarvestableDescriptor GetDescriptor() => _internal.sd();
        public HarvestableChargeDescriptor GetChargeDescriptor() => _internal.sf();
        public long GetCharges() => _internal.so();
        public long GetMaxCharges() => _internal.sp();
        public GameTimeStamp GetProtectedUntil() => _internal.ss();
        public int GetRareState() => _internal.sn();
        public ItemDescriptor GetResourceDescriptor() => _internal.st();
        public HarvestableTierDescriptor GetTierDescriptor() => _internal.se();
        public long GetYield() => _internal.sq();
        public bool IsHarvestable() => _internal.sr();
        
        #endregion
        
        #region Constructor
        
        public HarvestableObject(a1k instance) : base(instance)
        {
            _internal = instance;
        }
        
        static HarvestableObject()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator a1k(HarvestableObject instance)
        {
            return instance._internal;
        }
        
        public static implicit operator HarvestableObject(a1k instance)
        {
            return new HarvestableObject(instance);
        }
        
        #endregion
    }
}
