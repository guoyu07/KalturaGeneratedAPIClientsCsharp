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
// Copyright (C) 2006-2015  Kaltura Inc.
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
	public class KalturaScheduledTaskProfileBaseFilter : KalturaFilter
	{
		#region Private Fields
		private int _IdEqual = Int32.MinValue;
		private string _IdIn = null;
		private int _PartnerIdEqual = Int32.MinValue;
		private string _PartnerIdIn = null;
		private string _SystemNameEqual = null;
		private string _SystemNameIn = null;
		private KalturaScheduledTaskProfileStatus _StatusEqual = (KalturaScheduledTaskProfileStatus)Int32.MinValue;
		private string _StatusIn = null;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private int _LastExecutionStartedAtGreaterThanOrEqual = Int32.MinValue;
		private int _LastExecutionStartedAtLessThanOrEqual = Int32.MinValue;
		#endregion

		#region Properties
		public int IdEqual
		{
			get { return _IdEqual; }
			set 
			{ 
				_IdEqual = value;
				OnPropertyChanged("IdEqual");
			}
		}
		public string IdIn
		{
			get { return _IdIn; }
			set 
			{ 
				_IdIn = value;
				OnPropertyChanged("IdIn");
			}
		}
		public int PartnerIdEqual
		{
			get { return _PartnerIdEqual; }
			set 
			{ 
				_PartnerIdEqual = value;
				OnPropertyChanged("PartnerIdEqual");
			}
		}
		public string PartnerIdIn
		{
			get { return _PartnerIdIn; }
			set 
			{ 
				_PartnerIdIn = value;
				OnPropertyChanged("PartnerIdIn");
			}
		}
		public string SystemNameEqual
		{
			get { return _SystemNameEqual; }
			set 
			{ 
				_SystemNameEqual = value;
				OnPropertyChanged("SystemNameEqual");
			}
		}
		public string SystemNameIn
		{
			get { return _SystemNameIn; }
			set 
			{ 
				_SystemNameIn = value;
				OnPropertyChanged("SystemNameIn");
			}
		}
		public KalturaScheduledTaskProfileStatus StatusEqual
		{
			get { return _StatusEqual; }
			set 
			{ 
				_StatusEqual = value;
				OnPropertyChanged("StatusEqual");
			}
		}
		public string StatusIn
		{
			get { return _StatusIn; }
			set 
			{ 
				_StatusIn = value;
				OnPropertyChanged("StatusIn");
			}
		}
		public int CreatedAtGreaterThanOrEqual
		{
			get { return _CreatedAtGreaterThanOrEqual; }
			set 
			{ 
				_CreatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("CreatedAtGreaterThanOrEqual");
			}
		}
		public int CreatedAtLessThanOrEqual
		{
			get { return _CreatedAtLessThanOrEqual; }
			set 
			{ 
				_CreatedAtLessThanOrEqual = value;
				OnPropertyChanged("CreatedAtLessThanOrEqual");
			}
		}
		public int UpdatedAtGreaterThanOrEqual
		{
			get { return _UpdatedAtGreaterThanOrEqual; }
			set 
			{ 
				_UpdatedAtGreaterThanOrEqual = value;
				OnPropertyChanged("UpdatedAtGreaterThanOrEqual");
			}
		}
		public int UpdatedAtLessThanOrEqual
		{
			get { return _UpdatedAtLessThanOrEqual; }
			set 
			{ 
				_UpdatedAtLessThanOrEqual = value;
				OnPropertyChanged("UpdatedAtLessThanOrEqual");
			}
		}
		public int LastExecutionStartedAtGreaterThanOrEqual
		{
			get { return _LastExecutionStartedAtGreaterThanOrEqual; }
			set 
			{ 
				_LastExecutionStartedAtGreaterThanOrEqual = value;
				OnPropertyChanged("LastExecutionStartedAtGreaterThanOrEqual");
			}
		}
		public int LastExecutionStartedAtLessThanOrEqual
		{
			get { return _LastExecutionStartedAtLessThanOrEqual; }
			set 
			{ 
				_LastExecutionStartedAtLessThanOrEqual = value;
				OnPropertyChanged("LastExecutionStartedAtLessThanOrEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaScheduledTaskProfileBaseFilter()
		{
		}

		public KalturaScheduledTaskProfileBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "idEqual":
						this.IdEqual = ParseInt(txt);
						continue;
					case "idIn":
						this.IdIn = txt;
						continue;
					case "partnerIdEqual":
						this.PartnerIdEqual = ParseInt(txt);
						continue;
					case "partnerIdIn":
						this.PartnerIdIn = txt;
						continue;
					case "systemNameEqual":
						this.SystemNameEqual = txt;
						continue;
					case "systemNameIn":
						this.SystemNameIn = txt;
						continue;
					case "statusEqual":
						this.StatusEqual = (KalturaScheduledTaskProfileStatus)ParseEnum(typeof(KalturaScheduledTaskProfileStatus), txt);
						continue;
					case "statusIn":
						this.StatusIn = txt;
						continue;
					case "createdAtGreaterThanOrEqual":
						this.CreatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "createdAtLessThanOrEqual":
						this.CreatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtGreaterThanOrEqual":
						this.UpdatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtLessThanOrEqual":
						this.UpdatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "lastExecutionStartedAtGreaterThanOrEqual":
						this.LastExecutionStartedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "lastExecutionStartedAtLessThanOrEqual":
						this.LastExecutionStartedAtLessThanOrEqual = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaScheduledTaskProfileBaseFilter");
			kparams.AddIntIfNotNull("idEqual", this.IdEqual);
			kparams.AddStringIfNotNull("idIn", this.IdIn);
			kparams.AddIntIfNotNull("partnerIdEqual", this.PartnerIdEqual);
			kparams.AddStringIfNotNull("partnerIdIn", this.PartnerIdIn);
			kparams.AddStringIfNotNull("systemNameEqual", this.SystemNameEqual);
			kparams.AddStringIfNotNull("systemNameIn", this.SystemNameIn);
			kparams.AddEnumIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddStringIfNotNull("statusIn", this.StatusIn);
			kparams.AddIntIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtGreaterThanOrEqual", this.UpdatedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("updatedAtLessThanOrEqual", this.UpdatedAtLessThanOrEqual);
			kparams.AddIntIfNotNull("lastExecutionStartedAtGreaterThanOrEqual", this.LastExecutionStartedAtGreaterThanOrEqual);
			kparams.AddIntIfNotNull("lastExecutionStartedAtLessThanOrEqual", this.LastExecutionStartedAtLessThanOrEqual);
			return kparams;
		}
		#endregion
	}
}
