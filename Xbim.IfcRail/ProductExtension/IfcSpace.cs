// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.IfcRail.MeasureResource;
using Xbim.IfcRail.SharedBldgElements;
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
	[ExpressType("IfcSpace", 454)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcSpace : IfcSpatialStructureElement, IInstantiableEntity, IfcSpaceBoundarySelect, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcSpace>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcSpace(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcSpaceTypeEnum? _predefinedType;
		private IfcLengthMeasure? _elevationWithFlooring;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 26)]
		public IfcSpaceTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(_activated) return _predefinedType;
				Activate();
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 27)]
		public IfcLengthMeasure? @ElevationWithFlooring 
		{ 
			get 
			{
				if(_activated) return _elevationWithFlooring;
				Activate();
				return _elevationWithFlooring;
			} 
			set
			{
				SetValue( v =>  _elevationWithFlooring = v, _elevationWithFlooring, value,  "ElevationWithFlooring", 11);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("RelatingSpace")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 28)]
		public IEnumerable<IfcRelCoversSpaces> @HasCoverings 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelCoversSpaces>(e => Equals(e.RelatingSpace), "RelatingSpace", this);
			} 
		}
		[InverseProperty("RelatingSpace")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 29)]
		public IEnumerable<IfcRelSpaceBoundary> @BoundedBy 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelSpaceBoundary>(e => Equals(e.RelatingSpace), "RelatingSpace", this);
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
                    _predefinedType = (IfcSpaceTypeEnum) System.Enum.Parse(typeof (IfcSpaceTypeEnum), value.EnumVal, true);
					return;
				case 10: 
					_elevationWithFlooring = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcSpace other)
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