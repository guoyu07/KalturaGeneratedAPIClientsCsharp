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
	public class ProgramAsset : Asset
	{
		#region Constants
		public const string EPG_CHANNEL_ID = "epgChannelId";
		public const string EPG_ID = "epgId";
		public const string RELATED_MEDIA_ID = "relatedMediaId";
		public const string CRID = "crid";
		#endregion

		#region Private Fields
		private long _EpgChannelId = long.MinValue;
		private string _EpgId = null;
		private long _RelatedMediaId = long.MinValue;
		private string _Crid = null;
		#endregion

		#region Properties
		public long EpgChannelId
		{
			get { return _EpgChannelId; }
			set 
			{ 
				_EpgChannelId = value;
				OnPropertyChanged("EpgChannelId");
			}
		}
		public string EpgId
		{
			get { return _EpgId; }
			set 
			{ 
				_EpgId = value;
				OnPropertyChanged("EpgId");
			}
		}
		public long RelatedMediaId
		{
			get { return _RelatedMediaId; }
			set 
			{ 
				_RelatedMediaId = value;
				OnPropertyChanged("RelatedMediaId");
			}
		}
		public string Crid
		{
			get { return _Crid; }
			set 
			{ 
				_Crid = value;
				OnPropertyChanged("Crid");
			}
		}
		#endregion

		#region CTor
		public ProgramAsset()
		{
		}

		public ProgramAsset(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "epgChannelId":
						this._EpgChannelId = ParseLong(propertyNode.InnerText);
						continue;
					case "epgId":
						this._EpgId = propertyNode.InnerText;
						continue;
					case "relatedMediaId":
						this._RelatedMediaId = ParseLong(propertyNode.InnerText);
						continue;
					case "crid":
						this._Crid = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaProgramAsset");
			kparams.AddIfNotNull("epgChannelId", this._EpgChannelId);
			kparams.AddIfNotNull("epgId", this._EpgId);
			kparams.AddIfNotNull("relatedMediaId", this._RelatedMediaId);
			kparams.AddIfNotNull("crid", this._Crid);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case EPG_CHANNEL_ID:
					return "EpgChannelId";
				case EPG_ID:
					return "EpgId";
				case RELATED_MEDIA_ID:
					return "RelatedMediaId";
				case CRID:
					return "Crid";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

