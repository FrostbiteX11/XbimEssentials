// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.IfcRail.GeometryResource;
using Xbim.IfcRail.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.IfcRail.GeometricModelResource;
//## Custom using statements
//##


namespace Xbim.IfcRail.GeometricModelResource
{
	[ExpressType("IfcSweptDiskSolid", 1135)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSweptDiskSolid : IfcSolidModel, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcSweptDiskSolid>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSweptDiskSolid(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcCurve _directrix;
		private IfcPositiveLengthMeasure _radius;
		private IfcPositiveLengthMeasure? _innerRadius;
		private IfcParameterValue? _startParam;
		private IfcParameterValue? _endParam;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 3)]
		public IfcCurve @Directrix 
		{ 
			get 
			{
				if(_activated) return _directrix;
				Activate();
				return _directrix;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _directrix = v, _directrix, value,  "Directrix", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcPositiveLengthMeasure @Radius 
		{ 
			get 
			{
				if(_activated) return _radius;
				Activate();
				return _radius;
			} 
			set
			{
				SetValue( v =>  _radius = v, _radius, value,  "Radius", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcPositiveLengthMeasure? @InnerRadius 
		{ 
			get 
			{
				if(_activated) return _innerRadius;
				Activate();
				return _innerRadius;
			} 
			set
			{
				SetValue( v =>  _innerRadius = v, _innerRadius, value,  "InnerRadius", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcParameterValue? @StartParam 
		{ 
			get 
			{
				if(_activated) return _startParam;
				Activate();
				return _startParam;
			} 
			set
			{
				SetValue( v =>  _startParam = v, _startParam, value,  "StartParam", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 7)]
		public IfcParameterValue? @EndParam 
		{ 
			get 
			{
				if(_activated) return _endParam;
				Activate();
				return _endParam;
			} 
			set
			{
				SetValue( v =>  _endParam = v, _endParam, value,  "EndParam", 5);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_directrix = (IfcCurve)(value.EntityVal);
					return;
				case 1: 
					_radius = value.RealVal;
					return;
				case 2: 
					_innerRadius = value.RealVal;
					return;
				case 3: 
					_startParam = value.RealVal;
					return;
				case 4: 
					_endParam = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSweptDiskSolid other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Directrix != null)
					yield return @Directrix;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}