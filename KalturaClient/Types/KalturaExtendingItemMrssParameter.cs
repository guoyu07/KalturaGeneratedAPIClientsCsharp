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
// Copyright (C) 2006-2016  Kaltura Inc.
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

namespace Kaltura
{
	public class KalturaExtendingItemMrssParameter : KalturaObjectBase
	{
		#region Private Fields
		private string _Xpath = null;
		private KalturaObjectIdentifier _Identifier;
		private KalturaMrssExtensionMode _ExtensionMode = (KalturaMrssExtensionMode)Int32.MinValue;
		#endregion

		#region Properties
		public string Xpath
		{
			get { return _Xpath; }
			set 
			{ 
				_Xpath = value;
				OnPropertyChanged("Xpath");
			}
		}
		public KalturaObjectIdentifier Identifier
		{
			get { return _Identifier; }
			set 
			{ 
				_Identifier = value;
				OnPropertyChanged("Identifier");
			}
		}
		public KalturaMrssExtensionMode ExtensionMode
		{
			get { return _ExtensionMode; }
			set 
			{ 
				_ExtensionMode = value;
				OnPropertyChanged("ExtensionMode");
			}
		}
		#endregion

		#region CTor
		public KalturaExtendingItemMrssParameter()
		{
		}

		public KalturaExtendingItemMrssParameter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "xpath":
						this._Xpath = txt;
						continue;
					case "identifier":
						this._Identifier = (KalturaObjectIdentifier)KalturaObjectFactory.Create(propertyNode, "KalturaObjectIdentifier");
						continue;
					case "extensionMode":
						this._ExtensionMode = (KalturaMrssExtensionMode)ParseEnum(typeof(KalturaMrssExtensionMode), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaExtendingItemMrssParameter");
			kparams.AddIfNotNull("xpath", this.Xpath);
			kparams.AddIfNotNull("identifier", this.Identifier);
			kparams.AddIfNotNull("extensionMode", this.ExtensionMode);
			return kparams;
		}
		#endregion
	}
}

