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
	public class ReportTable : ObjectBase
	{
		#region Constants
		public const string HEADER = "header";
		public const string DATA = "data";
		public const string TOTAL_COUNT = "totalCount";
		#endregion

		#region Private Fields
		private string _Header = null;
		private string _Data = null;
		private int _TotalCount = Int32.MinValue;
		#endregion

		#region Properties
		public string Header
		{
			get { return _Header; }
		}
		public string Data
		{
			get { return _Data; }
		}
		public int TotalCount
		{
			get { return _TotalCount; }
		}
		#endregion

		#region CTor
		public ReportTable()
		{
		}

		public ReportTable(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "header":
						this._Header = propertyNode.InnerText;
						continue;
					case "data":
						this._Data = propertyNode.InnerText;
						continue;
					case "totalCount":
						this._TotalCount = ParseInt(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaReportTable");
			kparams.AddIfNotNull("header", this._Header);
			kparams.AddIfNotNull("data", this._Data);
			kparams.AddIfNotNull("totalCount", this._TotalCount);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case HEADER:
					return "Header";
				case DATA:
					return "Data";
				case TOTAL_COUNT:
					return "TotalCount";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

