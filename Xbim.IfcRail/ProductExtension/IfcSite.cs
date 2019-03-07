// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.IfcRail.MeasureResource;
using Xbim.IfcRail.ActorResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.IfcRail.ProductExtension;
//## Custom using statements
//##


namespace Xbim.IfcRail.ProductExtension
{
	[ExpressType("IfcSite", 349)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSite : IfcSpatialStructureElement, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcSite>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSite(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcCompoundPlaneAngleMeasure? _refLatitude;
		private IfcCompoundPlaneAngleMeasure? _refLongitude;
		private IfcLengthMeasure? _refElevation;
		private IfcLabel? _landTitleNumber;
		private IfcPostalAddress _siteAddress;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 26)]
		public IfcCompoundPlaneAngleMeasure? @RefLatitude 
		{ 
			get 
			{
				if(_activated) return _refLatitude;
				Activate();
				return _refLatitude;
			} 
			set
			{
				SetValue( v =>  _refLatitude = v, _refLatitude, value,  "RefLatitude", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 27)]
		public IfcCompoundPlaneAngleMeasure? @RefLongitude 
		{ 
			get 
			{
				if(_activated) return _refLongitude;
				Activate();
				return _refLongitude;
			} 
			set
			{
				SetValue( v =>  _refLongitude = v, _refLongitude, value,  "RefLongitude", 11);
			} 
		}	
		[EntityAttribute(12, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 28)]
		public IfcLengthMeasure? @RefElevation 
		{ 
			get 
			{
				if(_activated) return _refElevation;
				Activate();
				return _refElevation;
			} 
			set
			{
				SetValue( v =>  _refElevation = v, _refElevation, value,  "RefElevation", 12);
			} 
		}	
		[EntityAttribute(13, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 29)]
		public IfcLabel? @LandTitleNumber 
		{ 
			get 
			{
				if(_activated) return _landTitleNumber;
				Activate();
				return _landTitleNumber;
			} 
			set
			{
				SetValue( v =>  _landTitleNumber = v, _landTitleNumber, value,  "LandTitleNumber", 13);
			} 
		}	
		[EntityAttribute(14, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 30)]
		public IfcPostalAddress @SiteAddress 
		{ 
			get 
			{
				if(_activated) return _siteAddress;
				Activate();
				return _siteAddress;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _siteAddress = v, _siteAddress, value,  "SiteAddress", 14);
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
				case 6: 
				case 7: 
				case 8: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 9: 
					if (!_refLatitude.HasValue) _refLatitude = new IfcCompoundPlaneAngleMeasure();
			        var refLatitude = _refLatitude.Value;
					IfcCompoundPlaneAngleMeasure.Add(ref refLatitude, value.IntegerVal);
					_refLatitude = refLatitude;
					return;
				case 10: 
					if (!_refLongitude.HasValue) _refLongitude = new IfcCompoundPlaneAngleMeasure();
			        var refLongitude = _refLongitude.Value;
					IfcCompoundPlaneAngleMeasure.Add(ref refLongitude, value.IntegerVal);
					_refLongitude = refLongitude;
					return;
				case 11: 
					_refElevation = value.RealVal;
					return;
				case 12: 
					_landTitleNumber = value.StringVal;
					return;
				case 13: 
					_siteAddress = (IfcPostalAddress)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSite other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				if (@ObjectPlacement != null)
					yield return @ObjectPlacement;
				if (@Representation != null)
					yield return @Representation;
				if (@SiteAddress != null)
					yield return @SiteAddress;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@ObjectPlacement != null)
					yield return @ObjectPlacement;
				if (@Representation != null)
					yield return @Representation;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}