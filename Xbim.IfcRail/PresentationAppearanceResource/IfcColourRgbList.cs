// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.IfcRail.PresentationDefinitionResource;
using Xbim.IfcRail.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.IfcRail.PresentationAppearanceResource;
//## Custom using statements
//##


namespace Xbim.IfcRail.PresentationAppearanceResource
{
	[ExpressType("IfcColourRgbList", 1125)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcColourRgbList : IfcPresentationItem, IInstantiableEntity, IEquatable<@IfcColourRgbList>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcColourRgbList(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_colourList = new ItemSet<IItemSet<IfcNormalisedRatioMeasure>>( this, 0,  1);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IItemSet<IfcNormalisedRatioMeasure>> _colourList;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.List, new int [] { 1, 3 }, new int [] { -1, 3 }, 1)]
		public IItemSet<IItemSet<IfcNormalisedRatioMeasure>> @ColourList 
		{ 
			get 
			{
				if(_activated) return _colourList;
				Activate();
				return _colourList;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					((ItemSet<IfcNormalisedRatioMeasure>)_colourList
						.InternalGetAt(nestedIndex[0]) )
						.InternalAdd((IfcNormalisedRatioMeasure)(value.RealVal));
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcColourRgbList other)
	    {
	        return this == other;
	    }
        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}