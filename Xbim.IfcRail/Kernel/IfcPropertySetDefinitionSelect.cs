// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Common;
//## Custom using statements
using System.Collections.Generic;
using Xbim.Ifc4.Interfaces;
//##

namespace Xbim.IfcRail.Kernel
{
    // ReSharper disable once InconsistentNaming
    // ReSharper disable once PartialTypeWithSinglePart
	public partial interface IfcPropertySetDefinitionSelect : IExpressSelectType
	{
		#region Custom code for a select
		//## Custom code for a select
        IEnumerable<IIfcPropertySetDefinition> PropertySetDefinitions { get; }
        //##
		#endregion
	}
}

