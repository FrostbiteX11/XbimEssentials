// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.IfcRail.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.IfcRail.SharedFacilitiesElements;
//## Custom using statements
//##


namespace Xbim.IfcRail.SharedFacilitiesElements
{
	[ExpressType("IfcOccupant", 641)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcOccupant : IfcActor, IInstantiableEntity, IContainsEntityReferences, IEquatable<@IfcOccupant>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcOccupant(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcOccupantTypeEnum? _predefinedType;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.Enum, EntityAttributeType.None, null, null, 19)]
		public IfcOccupantTypeEnum? @PredefinedType 
		{ 
			get 
			{
				if(_activated) return _predefinedType;
				Activate();
				return _predefinedType;
			} 
			set
			{
				SetValue( v =>  _predefinedType = v, _predefinedType, value,  "PredefinedType", 7);
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
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
                    _predefinedType = (IfcOccupantTypeEnum) System.Enum.Parse(typeof (IfcOccupantTypeEnum), value.EnumVal, true);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcOccupant other)
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
				if (@TheActor != null)
					yield return @TheActor;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}