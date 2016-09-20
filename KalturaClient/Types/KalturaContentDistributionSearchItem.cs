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
	public class KalturaContentDistributionSearchItem : KalturaSearchItem
	{
		#region Private Fields
		private bool? _NoDistributionProfiles = null;
		private int _DistributionProfileId = Int32.MinValue;
		private KalturaEntryDistributionSunStatus _DistributionSunStatus = (KalturaEntryDistributionSunStatus)Int32.MinValue;
		private KalturaEntryDistributionFlag _EntryDistributionFlag = (KalturaEntryDistributionFlag)Int32.MinValue;
		private KalturaEntryDistributionStatus _EntryDistributionStatus = (KalturaEntryDistributionStatus)Int32.MinValue;
		private bool? _HasEntryDistributionValidationErrors = null;
		private string _EntryDistributionValidationErrors = null;
		#endregion

		#region Properties
		public bool? NoDistributionProfiles
		{
			get { return _NoDistributionProfiles; }
			set 
			{ 
				_NoDistributionProfiles = value;
				OnPropertyChanged("NoDistributionProfiles");
			}
		}
		public int DistributionProfileId
		{
			get { return _DistributionProfileId; }
			set 
			{ 
				_DistributionProfileId = value;
				OnPropertyChanged("DistributionProfileId");
			}
		}
		public KalturaEntryDistributionSunStatus DistributionSunStatus
		{
			get { return _DistributionSunStatus; }
			set 
			{ 
				_DistributionSunStatus = value;
				OnPropertyChanged("DistributionSunStatus");
			}
		}
		public KalturaEntryDistributionFlag EntryDistributionFlag
		{
			get { return _EntryDistributionFlag; }
			set 
			{ 
				_EntryDistributionFlag = value;
				OnPropertyChanged("EntryDistributionFlag");
			}
		}
		public KalturaEntryDistributionStatus EntryDistributionStatus
		{
			get { return _EntryDistributionStatus; }
			set 
			{ 
				_EntryDistributionStatus = value;
				OnPropertyChanged("EntryDistributionStatus");
			}
		}
		public bool? HasEntryDistributionValidationErrors
		{
			get { return _HasEntryDistributionValidationErrors; }
			set 
			{ 
				_HasEntryDistributionValidationErrors = value;
				OnPropertyChanged("HasEntryDistributionValidationErrors");
			}
		}
		public string EntryDistributionValidationErrors
		{
			get { return _EntryDistributionValidationErrors; }
			set 
			{ 
				_EntryDistributionValidationErrors = value;
				OnPropertyChanged("EntryDistributionValidationErrors");
			}
		}
		#endregion

		#region CTor
		public KalturaContentDistributionSearchItem()
		{
		}

		public KalturaContentDistributionSearchItem(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "noDistributionProfiles":
						this._NoDistributionProfiles = ParseBool(txt);
						continue;
					case "distributionProfileId":
						this._DistributionProfileId = ParseInt(txt);
						continue;
					case "distributionSunStatus":
						this._DistributionSunStatus = (KalturaEntryDistributionSunStatus)ParseEnum(typeof(KalturaEntryDistributionSunStatus), txt);
						continue;
					case "entryDistributionFlag":
						this._EntryDistributionFlag = (KalturaEntryDistributionFlag)ParseEnum(typeof(KalturaEntryDistributionFlag), txt);
						continue;
					case "entryDistributionStatus":
						this._EntryDistributionStatus = (KalturaEntryDistributionStatus)ParseEnum(typeof(KalturaEntryDistributionStatus), txt);
						continue;
					case "hasEntryDistributionValidationErrors":
						this._HasEntryDistributionValidationErrors = ParseBool(txt);
						continue;
					case "entryDistributionValidationErrors":
						this._EntryDistributionValidationErrors = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaContentDistributionSearchItem");
			kparams.AddIfNotNull("noDistributionProfiles", this.NoDistributionProfiles);
			kparams.AddIfNotNull("distributionProfileId", this.DistributionProfileId);
			kparams.AddIfNotNull("distributionSunStatus", this.DistributionSunStatus);
			kparams.AddIfNotNull("entryDistributionFlag", this.EntryDistributionFlag);
			kparams.AddIfNotNull("entryDistributionStatus", this.EntryDistributionStatus);
			kparams.AddIfNotNull("hasEntryDistributionValidationErrors", this.HasEntryDistributionValidationErrors);
			kparams.AddIfNotNull("entryDistributionValidationErrors", this.EntryDistributionValidationErrors);
			return kparams;
		}
		#endregion
	}
}

