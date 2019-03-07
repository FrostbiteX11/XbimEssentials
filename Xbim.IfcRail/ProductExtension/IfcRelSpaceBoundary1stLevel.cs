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
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.IfcRail.ProductExtension;
//## Custom using statements
//##


namespace Xbim.IfcRail.ProductExtension
{
	[ExpressType("IfcRelSpaceBoundary1stLevel", 1253)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelSpaceBoundary1stLevel : IfcRelSpaceBoundary, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelSpaceBoundary1stLevel>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelSpaceBoundary1stLevel(IModel model, int label, bool activated) : base(model, label, activated)  
		{
		}

		#region Explicit attribute fields
		private IfcRelSpaceBoundary1stLevel _parentBoundary;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, null, null, 10)]
		public IfcRelSpaceBoundary1stLevel @ParentBoundary 
		{ 
			get 
			{
				if(_activated) return _parentBoundary;
				Activate();
				return _parentBoundary;
			} 
			set
			{
				if (value != null && !(ReferenceEquals(Model, value.Model)))
					throw new XbimException("Cross model entity assignment.");
				SetValue( v =>  _parentBoundary = v, _parentBoundary, value,  "ParentBoundary", 10);
			} 
		}	
		#endregion



		#region Inverse attributes
		[InverseProperty("ParentBoundary")]
		[EntityAttribute(-1, EntityAttributeState.Mandatory, EntityAttributeType.Set, EntityAttributeType.Class, new int [] { 0 }, new int [] { -1 }, 11)]
		public IEnumerable<IfcRelSpaceBoundary1stLevel> @InnerBoundaries 
		{ 
			get 
			{
				return Model.Instances.Where<IfcRelSpaceBoundary1stLevel>(e => Equals(e.ParentBoundary), "ParentBoundary", this);
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
					_parentBoundary = (IfcRelSpaceBoundary1stLevel)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelSpaceBoundary1stLevel other)
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
				if (@RelatingSpace != null)
					yield return @RelatingSpace;
				if (@RelatedBuildingElement != null)
					yield return @RelatedBuildingElement;
				if (@ConnectionGeometry != null)
					yield return @ConnectionGeometry;
				if (@ParentBoundary != null)
					yield return @ParentBoundary;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				if (@RelatingSpace != null)
					yield return @RelatingSpace;
				if (@RelatedBuildingElement != null)
					yield return @RelatedBuildingElement;
				if (@ParentBoundary != null)
					yield return @ParentBoundary;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}