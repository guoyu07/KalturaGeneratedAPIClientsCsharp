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
	public class KalturaAssetParamsOutput : KalturaAssetParams
	{
		#region Private Fields
		private int _AssetParamsId = Int32.MinValue;
		private string _AssetParamsVersion = null;
		private string _AssetId = null;
		private string _AssetVersion = null;
		private int _ReadyBehavior = Int32.MinValue;
		private KalturaContainerFormat _Format = null;
		#endregion

		#region Properties
		public int AssetParamsId
		{
			get { return _AssetParamsId; }
			set 
			{ 
				_AssetParamsId = value;
				OnPropertyChanged("AssetParamsId");
			}
		}
		public string AssetParamsVersion
		{
			get { return _AssetParamsVersion; }
			set 
			{ 
				_AssetParamsVersion = value;
				OnPropertyChanged("AssetParamsVersion");
			}
		}
		public string AssetId
		{
			get { return _AssetId; }
			set 
			{ 
				_AssetId = value;
				OnPropertyChanged("AssetId");
			}
		}
		public string AssetVersion
		{
			get { return _AssetVersion; }
			set 
			{ 
				_AssetVersion = value;
				OnPropertyChanged("AssetVersion");
			}
		}
		public int ReadyBehavior
		{
			get { return _ReadyBehavior; }
			set 
			{ 
				_ReadyBehavior = value;
				OnPropertyChanged("ReadyBehavior");
			}
		}
		public KalturaContainerFormat Format
		{
			get { return _Format; }
			set 
			{ 
				_Format = value;
				OnPropertyChanged("Format");
			}
		}
		#endregion

		#region CTor
		public KalturaAssetParamsOutput()
		{
		}

		public KalturaAssetParamsOutput(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "assetParamsId":
						this._AssetParamsId = ParseInt(txt);
						continue;
					case "assetParamsVersion":
						this._AssetParamsVersion = txt;
						continue;
					case "assetId":
						this._AssetId = txt;
						continue;
					case "assetVersion":
						this._AssetVersion = txt;
						continue;
					case "readyBehavior":
						this._ReadyBehavior = ParseInt(txt);
						continue;
					case "format":
						this._Format = (KalturaContainerFormat)KalturaStringEnum.Parse(typeof(KalturaContainerFormat), txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaAssetParamsOutput");
			kparams.AddIfNotNull("assetParamsId", this.AssetParamsId);
			kparams.AddIfNotNull("assetParamsVersion", this.AssetParamsVersion);
			kparams.AddIfNotNull("assetId", this.AssetId);
			kparams.AddIfNotNull("assetVersion", this.AssetVersion);
			kparams.AddIfNotNull("readyBehavior", this.ReadyBehavior);
			kparams.AddIfNotNull("format", this.Format);
			return kparams;
		}
		#endregion
	}
}

