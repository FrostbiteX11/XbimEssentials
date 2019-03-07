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
using Xbim.IfcRail.PresentationAppearanceResource;
//## Custom using statements
//##


namespace Xbim.IfcRail.PresentationAppearanceResource
{
	[ExpressType("IfcTextureCoordinateGenerator", 733)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextureCoordinateGenerator : IfcTextureCoordinate, IInstantiableEntity, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcTextureCoordinateGenerator>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextureCoordinateGenerator(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_parameter = new OptionalItemSet<IfcReal>( this, 0,  3);
		}

		#region Explicit attribute fields
		private IfcLabel _mode;
		private readonly OptionalItemSet<IfcReal> _parameter;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, null, null, 2)]
		public IfcLabel @Mode 
		{ 
			get 
			{
				if(_activated) return _mode;
				Activate();
				return _mode;
			} 
			set
			{
				SetValue( v =>  _mode = v, _mode, value,  "Mode", 2);
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, new int [] { 1 }, new int [] { -1 }, 3)]
		public IOptionalItemSet<IfcReal> @Parameter 
		{ 
			get 
			{
				if(_activated) return _parameter;
				Activate();
				return _parameter;
			} 
		}	
		#endregion




		#region IPersist implementation
		public override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 1: 
					_mode = value.StringVal;
					return;
				case 2: 
					_parameter.InternalAdd(value.RealVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTextureCoordinateGenerator other)
	    {
	        return this == other;
	    }
        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				foreach(var entity in @Maps)
					yield return entity;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @Maps)
					yield return entity;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}