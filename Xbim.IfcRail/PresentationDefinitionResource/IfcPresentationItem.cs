// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using Xbim.Common.Metadata;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.IfcRail.PresentationDefinitionResource;
//## Custom using statements
//##


namespace Xbim.IfcRail.PresentationDefinitionResource
{
	[ExpressType("IfcPresentationItem", 1227)]
	// ReSharper disable once PartialTypeWithSinglePart
	public abstract partial class @IfcPresentationItem : PersistEntity, IEquatable<@IfcPresentationItem>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcPresentationItem(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}





		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			//there are no attributes defined for this entity
            throw new System.IndexOutOfRangeException("There are no attributes defined for this entity");
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcPresentationItem other)
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