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
using Xbim.IfcRail.PresentationAppearanceResource;
//## Custom using statements
//##


namespace Xbim.IfcRail.PresentationAppearanceResource
{
	[ExpressType("IfcTextStyleFontModel", 503)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcTextStyleFontModel : IfcPreDefinedTextFont, IInstantiableEntity, IEquatable<@IfcTextStyleFontModel>
	{

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcTextStyleFontModel(IModel model, int label, bool activated) : base(model, label, activated)  
		{
			_fontFamily = new ItemSet<IfcTextFontName>( this, 0,  2);
		}

		#region Explicit attribute fields
		private readonly ItemSet<IfcTextFontName> _fontFamily;
		private IfcFontStyle? _fontStyle;
		private IfcFontVariant? _fontVariant;
		private IfcFontWeight? _fontWeight;
		private IfcSizeSelect _fontSize;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, new int [] { 1 }, new int [] { -1 }, 2)]
		public IItemSet<IfcTextFontName> @FontFamily 
		{ 
			get 
			{
				if(_activated) return _fontFamily;
				Activate();
				return _fontFamily;
			} 
		}	
		[EntityAttribute(3, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 3)]
		public IfcFontStyle? @FontStyle 
		{ 
			get 
			{
				if(_activated) return _fontStyle;
				Activate();
				return _fontStyle;
			} 
			set
			{
				SetValue( v =>  _fontStyle = v, _fontStyle, value,  "FontStyle", 3);
			} 
		}	
		[EntityAttribute(4, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 4)]
		public IfcFontVariant? @FontVariant 
		{ 
			get 
			{
				if(_activated) return _fontVariant;
				Activate();
				return _fontVariant;
			} 
			set
			{
				SetValue( v =>  _fontVariant = v, _fontVariant, value,  "FontVariant", 4);
			} 
		}	
		[EntityAttribute(5, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, null, null, 5)]
		public IfcFontWeight? @FontWeight 
		{ 
			get 
			{
				if(_activated) return _fontWeight;
				Activate();
				return _fontWeight;
			} 
			set
			{
				SetValue( v =>  _fontWeight = v, _fontWeight, value,  "FontWeight", 5);
			} 
		}	
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, null, null, 6)]
		public IfcSizeSelect @FontSize 
		{ 
			get 
			{
				if(_activated) return _fontSize;
				Activate();
				return _fontSize;
			} 
			set
			{
				SetValue( v =>  _fontSize = v, _fontSize, value,  "FontSize", 6);
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
					_fontFamily.InternalAdd(value.StringVal);
					return;
				case 2: 
					_fontStyle = value.StringVal;
					return;
				case 3: 
					_fontVariant = value.StringVal;
					return;
				case 4: 
					_fontWeight = value.StringVal;
					return;
				case 5: 
					_fontSize = (IfcSizeSelect)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcTextStyleFontModel other)
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