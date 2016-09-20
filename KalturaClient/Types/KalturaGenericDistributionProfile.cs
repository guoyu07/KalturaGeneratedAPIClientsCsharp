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
	public class KalturaGenericDistributionProfile : KalturaDistributionProfile
	{
		#region Private Fields
		private int _GenericProviderId = Int32.MinValue;
		private KalturaGenericDistributionProfileAction _SubmitAction;
		private KalturaGenericDistributionProfileAction _UpdateAction;
		private KalturaGenericDistributionProfileAction _DeleteAction;
		private KalturaGenericDistributionProfileAction _FetchReportAction;
		private string _UpdateRequiredEntryFields = null;
		private string _UpdateRequiredMetadataXPaths = null;
		#endregion

		#region Properties
		public int GenericProviderId
		{
			get { return _GenericProviderId; }
			set 
			{ 
				_GenericProviderId = value;
				OnPropertyChanged("GenericProviderId");
			}
		}
		public KalturaGenericDistributionProfileAction SubmitAction
		{
			get { return _SubmitAction; }
			set 
			{ 
				_SubmitAction = value;
				OnPropertyChanged("SubmitAction");
			}
		}
		public KalturaGenericDistributionProfileAction UpdateAction
		{
			get { return _UpdateAction; }
			set 
			{ 
				_UpdateAction = value;
				OnPropertyChanged("UpdateAction");
			}
		}
		public KalturaGenericDistributionProfileAction DeleteAction
		{
			get { return _DeleteAction; }
			set 
			{ 
				_DeleteAction = value;
				OnPropertyChanged("DeleteAction");
			}
		}
		public KalturaGenericDistributionProfileAction FetchReportAction
		{
			get { return _FetchReportAction; }
			set 
			{ 
				_FetchReportAction = value;
				OnPropertyChanged("FetchReportAction");
			}
		}
		public string UpdateRequiredEntryFields
		{
			get { return _UpdateRequiredEntryFields; }
			set 
			{ 
				_UpdateRequiredEntryFields = value;
				OnPropertyChanged("UpdateRequiredEntryFields");
			}
		}
		public string UpdateRequiredMetadataXPaths
		{
			get { return _UpdateRequiredMetadataXPaths; }
			set 
			{ 
				_UpdateRequiredMetadataXPaths = value;
				OnPropertyChanged("UpdateRequiredMetadataXPaths");
			}
		}
		#endregion

		#region CTor
		public KalturaGenericDistributionProfile()
		{
		}

		public KalturaGenericDistributionProfile(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "genericProviderId":
						this._GenericProviderId = ParseInt(txt);
						continue;
					case "submitAction":
						this._SubmitAction = (KalturaGenericDistributionProfileAction)KalturaObjectFactory.Create(propertyNode, "KalturaGenericDistributionProfileAction");
						continue;
					case "updateAction":
						this._UpdateAction = (KalturaGenericDistributionProfileAction)KalturaObjectFactory.Create(propertyNode, "KalturaGenericDistributionProfileAction");
						continue;
					case "deleteAction":
						this._DeleteAction = (KalturaGenericDistributionProfileAction)KalturaObjectFactory.Create(propertyNode, "KalturaGenericDistributionProfileAction");
						continue;
					case "fetchReportAction":
						this._FetchReportAction = (KalturaGenericDistributionProfileAction)KalturaObjectFactory.Create(propertyNode, "KalturaGenericDistributionProfileAction");
						continue;
					case "updateRequiredEntryFields":
						this._UpdateRequiredEntryFields = txt;
						continue;
					case "updateRequiredMetadataXPaths":
						this._UpdateRequiredMetadataXPaths = txt;
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaGenericDistributionProfile");
			kparams.AddIfNotNull("genericProviderId", this.GenericProviderId);
			kparams.AddIfNotNull("submitAction", this.SubmitAction);
			kparams.AddIfNotNull("updateAction", this.UpdateAction);
			kparams.AddIfNotNull("deleteAction", this.DeleteAction);
			kparams.AddIfNotNull("fetchReportAction", this.FetchReportAction);
			kparams.AddIfNotNull("updateRequiredEntryFields", this.UpdateRequiredEntryFields);
			kparams.AddIfNotNull("updateRequiredMetadataXPaths", this.UpdateRequiredMetadataXPaths);
			return kparams;
		}
		#endregion
	}
}

