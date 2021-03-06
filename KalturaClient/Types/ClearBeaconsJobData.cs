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
	public class ClearBeaconsJobData : JobData
	{
		#region Constants
		public const string OBJECT_ID = "objectId";
		public const string RELATED_OBJECT_TYPE = "relatedObjectType";
		#endregion

		#region Private Fields
		private string _ObjectId = null;
		private int _RelatedObjectType = Int32.MinValue;
		#endregion

		#region Properties
		public string ObjectId
		{
			get { return _ObjectId; }
		}
		public int RelatedObjectType
		{
			get { return _RelatedObjectType; }
			set 
			{ 
				_RelatedObjectType = value;
				OnPropertyChanged("RelatedObjectType");
			}
		}
		#endregion

		#region CTor
		public ClearBeaconsJobData()
		{
		}

		public ClearBeaconsJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "objectId":
						this._ObjectId = propertyNode.InnerText;
						continue;
					case "relatedObjectType":
						this._RelatedObjectType = ParseInt(propertyNode.InnerText);
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
				kparams.AddReplace("objectType", "KalturaClearBeaconsJobData");
			kparams.AddIfNotNull("objectId", this._ObjectId);
			kparams.AddIfNotNull("relatedObjectType", this._RelatedObjectType);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case OBJECT_ID:
					return "ObjectId";
				case RELATED_OBJECT_TYPE:
					return "RelatedObjectType";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

