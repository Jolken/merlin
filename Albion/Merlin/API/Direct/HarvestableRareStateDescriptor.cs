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
    /* Internal type: hn.b.a */
    public partial class HarvestableRareStateDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        
        private hn.b.a _internal;
        
        #region Properties
        
        public hn.b.a HarvestableRareStateDescriptor_Internal => _internal;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public HarvestableRareStateDescriptor(hn.b.a instance)
        {
            _internal = instance;
        }
        
        static HarvestableRareStateDescriptor()
        {
            
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator hn.b.a(HarvestableRareStateDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator HarvestableRareStateDescriptor(hn.b.a instance)
        {
            return new HarvestableRareStateDescriptor(instance);
        }
        
        #endregion
    }
}
