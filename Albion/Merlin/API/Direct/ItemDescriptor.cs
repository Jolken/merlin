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
    /* Internal type: bp */
    public partial class ItemDescriptor
    {
        private static List<MethodInfo> _methodReflectionPool = new List<MethodInfo>();
        private static List<PropertyInfo> _propertyReflectionPool = new List<PropertyInfo>();
        
        private bp _internal;
        
        #region Properties
        
        public bp ItemDescriptor_Internal => _internal;
        public string Description => _internal.ag;
        public string DescriptionTag
        {
            get => (string)_propertyReflectionPool[0].GetValue(_internal, null);
            set => _propertyReflectionPool[0].SetValue(_internal, (string)value, null);
        }
        public string Name => _internal.e;
        public string NameTag
        {
            get => (string)_propertyReflectionPool[1].GetValue(_internal, null);
            set => _propertyReflectionPool[1].SetValue(_internal, (string)value, null);
        }
        public string ResourceType => _internal.u;
        public int Tier => _internal.f;
        
        #endregion
        
        #region Fields
        
        
        #endregion
        
        #region Methods
        
        
        #endregion
        
        #region Constructor
        
        public ItemDescriptor(bp instance)
        {
            _internal = instance;
        }
        
        static ItemDescriptor()
        {
            _propertyReflectionPool.Add(typeof(bp).GetProperty("an", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance));
            _propertyReflectionPool.Add(typeof(bp).GetProperty("am", BindingFlags.NonPublic | BindingFlags.Static | BindingFlags.Instance));
        }
        
        #endregion
        
        #region Conversion
        
        public static implicit operator bp(ItemDescriptor instance)
        {
            return instance._internal;
        }
        
        public static implicit operator ItemDescriptor(bp instance)
        {
            return new ItemDescriptor(instance);
        }
        
        #endregion
    }
}
