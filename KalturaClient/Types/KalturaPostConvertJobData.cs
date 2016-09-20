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
	public class KalturaPostConvertJobData : KalturaConvartableJobData
	{
		#region Private Fields
		private string _FlavorAssetId = null;
		private bool? _CreateThumb = null;
		private string _ThumbPath = null;
		private int _ThumbOffset = Int32.MinValue;
		private int _ThumbHeight = Int32.MinValue;
		private int _ThumbBitrate = Int32.MinValue;
		private string _CustomData = null;
		#endregion

		#region Properties
		public string FlavorAssetId
		{
			get { return _FlavorAssetId; }
			set 
			{ 
				_FlavorAssetId = value;
				OnPropertyChanged("FlavorAssetId");
			}
		}
		public bool? CreateThumb
		{
			get { return _CreateThumb; }
			set 
			{ 
				_CreateThumb = value;
				OnPropertyChanged("CreateThumb");
			}
		}
		public string ThumbPath
		{
			get { return _ThumbPath; }
			set 
			{ 
				_ThumbPath = value;
				OnPropertyChanged("ThumbPath");
			}
		}
		public int ThumbOffset
		{
			get { return _ThumbOffset; }
			set 
			{ 
				_ThumbOffset = value;
				OnPropertyChanged("ThumbOffset");
			}
		}
		public int ThumbHeight
		{
			get { return _ThumbHeight; }
			set 
			{ 
				_ThumbHeight = value;
				OnPropertyChanged("ThumbHeight");
			}
		}
		public int ThumbBitrate
		{
			get { return _ThumbBitrate; }
			set 
			{ 
				_ThumbBitrate = value;
				OnPropertyChanged("ThumbBitrate");
			}
		}
		public string CustomData
		{
			get { return _CustomData; }
			set 
			{ 
				_CustomData = value;
				OnPropertyChanged("CustomData");
			}
		}
		#endregion

		#region CTor
		public KalturaPostConvertJobData()
		{
		}

		public KalturaPostConvertJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "flavorAssetId":
						this._FlavorAssetId = txt;
						continue;
					case "createThumb":
						this._CreateThumb = ParseBool(txt);
						continue;
					case "thumbPath":
						this._ThumbPath = txt;
						continue;
					case "thumbOffset":
						this._ThumbOffset = ParseInt(txt);
						continue;
					case "thumbHeight":
						this._ThumbHeight = ParseInt(txt);
						continue;
					case "thumbBitrate":
						this._ThumbBitrate = ParseInt(txt);
						continue;
					case "customData":
						this._CustomData = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaPostConvertJobData");
			kparams.AddIfNotNull("flavorAssetId", this.FlavorAssetId);
			kparams.AddIfNotNull("createThumb", this.CreateThumb);
			kparams.AddIfNotNull("thumbPath", this.ThumbPath);
			kparams.AddIfNotNull("thumbOffset", this.ThumbOffset);
			kparams.AddIfNotNull("thumbHeight", this.ThumbHeight);
			kparams.AddIfNotNull("thumbBitrate", this.ThumbBitrate);
			kparams.AddIfNotNull("customData", this.CustomData);
			return kparams;
		}
		#endregion
	}
}

