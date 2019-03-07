// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.IfcRail.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.IfcRail.TopologyResource;
//## Custom using statements
//##


namespace Xbim.IfcRail.TopologyResource
{
	[ExpressType("IfcOrientedEdge", 596)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOrientedEdge : IfcEdge, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcOrientedEdge>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcOrientedEdge(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcEdge _edgeElement;
		private IfcBoolean _orientation;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(3, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 5)]
		public IfcEdge @EdgeElement 
		{ 
			get 
			{
				if(_activated) return _edgeElement;
				Activate();
				return _edgeElement;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _edgeElement = v, _edgeElement, value,  "EdgeElement", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 6)]
		public IfcBoolean @Orientation 
		{ 
			get 
			{
				if(_activated) return _orientation;
				Activate();
				return _orientation;
			} 
			set
			{
				SetValue( v =>  _orientation = v, _orientation, value,  "Orientation", 4);
			} 
		}	
		#endregion

		#region Overriding attributes
		[EntityAttribute(1, EntityAttributeState.DerivedOverride, EntityAttributeType.Class, EntityAttributeType.None, null, null, 0)]
		public override IfcVertex @EdgeStart 
		{
			get 
			{
				//## Overriding derived attribute EdgeStart getter
			    return Orientation
			        ? EdgeElement.EdgeStart
			        : EdgeElement.EdgeEnd;

			    //##
			}
			set 
			{ 
				throw new System.Exception("It is not possible to set a value of derived property EdgeStart in IfcOrientedEdge"); 
			}
		}
		[EntityAttribute(2, EntityAttributeState.DerivedOverride, EntityAttributeType.Class, EntityAttributeType.None, null, null, 0)]
		public override IfcVertex @EdgeEnd 
		{
			get 
			{
				//## Overriding derived attribute EdgeEnd getter
                return Orientation
                    ? EdgeElement.EdgeEnd
                    : EdgeElement.EdgeStart;
				//##
			}
			set 
			{ 
				throw new System.Exception("It is not possible to set a value of derived property EdgeEnd in IfcOrientedEdge"); 
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 2: 
					_edgeElement = (IfcEdge)(value.EntityVal);
					return;
				case 3: 
					_orientation = value.BooleanVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcOrientedEdge other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@EdgeStart != null)
					yield return @EdgeStart;
				if (@EdgeEnd != null)
					yield return @EdgeEnd;
				if (@EdgeElement != null)
					yield return @EdgeElement;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}