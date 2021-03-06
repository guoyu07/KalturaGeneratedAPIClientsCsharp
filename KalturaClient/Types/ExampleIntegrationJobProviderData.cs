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
// Copyright (C) 2006-2017  Kaltura Inc.
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
	public class ExampleIntegrationJobProviderData : IntegrationJobProviderData
	{
		#region Constants
		public const string EXAMPLE_URL = "exampleUrl";
		#endregion

		#region Private Fields
		private string _ExampleUrl = null;
		#endregion

		#region Properties
		public string ExampleUrl
		{
			get { return _ExampleUrl; }
			set 
			{ 
				_ExampleUrl = value;
				OnPropertyChanged("ExampleUrl");
			}
		}
		#endregion

		#region CTor
		public ExampleIntegrationJobProviderData()
		{
		}

		public ExampleIntegrationJobProviderData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "exampleUrl":
						this._ExampleUrl = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaExampleIntegrationJobProviderData");
			kparams.AddIfNotNull("exampleUrl", this._ExampleUrl);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case EXAMPLE_URL:
					return "ExampleUrl";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

