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
	public class YahooDistributionJobProviderData : ConfigurableDistributionJobProviderData
	{
		#region Constants
		public const string SMALL_THUMB_PATH = "smallThumbPath";
		public const string LARGE_THUMB_PATH = "largeThumbPath";
		public const string VIDEO_ASSET_FILE_PATH = "videoAssetFilePath";
		#endregion

		#region Private Fields
		private string _SmallThumbPath = null;
		private string _LargeThumbPath = null;
		private string _VideoAssetFilePath = null;
		#endregion

		#region Properties
		public string SmallThumbPath
		{
			get { return _SmallThumbPath; }
			set 
			{ 
				_SmallThumbPath = value;
				OnPropertyChanged("SmallThumbPath");
			}
		}
		public string LargeThumbPath
		{
			get { return _LargeThumbPath; }
			set 
			{ 
				_LargeThumbPath = value;
				OnPropertyChanged("LargeThumbPath");
			}
		}
		public string VideoAssetFilePath
		{
			get { return _VideoAssetFilePath; }
			set 
			{ 
				_VideoAssetFilePath = value;
				OnPropertyChanged("VideoAssetFilePath");
			}
		}
		#endregion

		#region CTor
		public YahooDistributionJobProviderData()
		{
		}

		public YahooDistributionJobProviderData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "smallThumbPath":
						this._SmallThumbPath = propertyNode.InnerText;
						continue;
					case "largeThumbPath":
						this._LargeThumbPath = propertyNode.InnerText;
						continue;
					case "videoAssetFilePath":
						this._VideoAssetFilePath = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaYahooDistributionJobProviderData");
			kparams.AddIfNotNull("smallThumbPath", this._SmallThumbPath);
			kparams.AddIfNotNull("largeThumbPath", this._LargeThumbPath);
			kparams.AddIfNotNull("videoAssetFilePath", this._VideoAssetFilePath);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case SMALL_THUMB_PATH:
					return "SmallThumbPath";
				case LARGE_THUMB_PATH:
					return "LargeThumbPath";
				case VIDEO_ASSET_FILE_PATH:
					return "VideoAssetFilePath";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

