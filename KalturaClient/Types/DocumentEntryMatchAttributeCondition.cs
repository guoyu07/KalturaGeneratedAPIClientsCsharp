// ===================================================================================================
//                           _  __     _ _
//                          | |/ /__ _| | |_ _  _ _ _ __ _
//                          | ' </ _` | |  _| || | '_/ _` |
//                          |_|\_\__,_|_|\__|\_,_|_| \__,_|
//
// This file is part of the Kaltura Collaborative Media Suite which allows users
// to do with audio, video, and animation what Wiki platfroms allow them to do with
// text.
//
// Copyright (C) 2006-2018  Kaltura Inc.
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Affero General Public License as
// published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Affero General Public License for more details.
//
// You should have received a copy of the GNU Affero General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
//
// @ignore
// ===================================================================================================
using System;
using System.Xml;
using System.Collections.Generic;
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class DocumentEntryMatchAttributeCondition : SearchMatchAttributeCondition
	{
		#region Constants
		public const string ATTRIBUTE = "attribute";
		#endregion

		#region Private Fields
		private DocumentEntryMatchAttribute _Attribute = null;
		#endregion

		#region Properties
		public DocumentEntryMatchAttribute Attribute
		{
			get { return _Attribute; }
			set 
			{ 
				_Attribute = value;
				OnPropertyChanged("Attribute");
			}
		}
		#endregion

		#region CTor
		public DocumentEntryMatchAttributeCondition()
		{
		}

		public DocumentEntryMatchAttributeCondition(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "attribute":
						this._Attribute = (DocumentEntryMatchAttribute)StringEnum.Parse(typeof(DocumentEntryMatchAttribute), propertyNode.InnerText);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override Params ToParams(bool includeObjectType = true)
		{
			Params kparams = base.ToParams(includeObjectType);
			if (includeObjectType)
				kparams.AddReplace("objectType", "KalturaDocumentEntryMatchAttributeCondition");
			kparams.AddIfNotNull("attribute", this._Attribute);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ATTRIBUTE:
					return "Attribute";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

