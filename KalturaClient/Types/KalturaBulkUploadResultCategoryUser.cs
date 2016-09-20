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
	public class KalturaBulkUploadResultCategoryUser : KalturaBulkUploadResult
	{
		#region Private Fields
		private int _CategoryId = Int32.MinValue;
		private string _CategoryReferenceId = null;
		private string _UserId = null;
		private int _PermissionLevel = Int32.MinValue;
		private int _UpdateMethod = Int32.MinValue;
		private int _RequiredObjectStatus = Int32.MinValue;
		#endregion

		#region Properties
		public int CategoryId
		{
			get { return _CategoryId; }
			set 
			{ 
				_CategoryId = value;
				OnPropertyChanged("CategoryId");
			}
		}
		public string CategoryReferenceId
		{
			get { return _CategoryReferenceId; }
			set 
			{ 
				_CategoryReferenceId = value;
				OnPropertyChanged("CategoryReferenceId");
			}
		}
		public string UserId
		{
			get { return _UserId; }
			set 
			{ 
				_UserId = value;
				OnPropertyChanged("UserId");
			}
		}
		public int PermissionLevel
		{
			get { return _PermissionLevel; }
			set 
			{ 
				_PermissionLevel = value;
				OnPropertyChanged("PermissionLevel");
			}
		}
		public int UpdateMethod
		{
			get { return _UpdateMethod; }
			set 
			{ 
				_UpdateMethod = value;
				OnPropertyChanged("UpdateMethod");
			}
		}
		public int RequiredObjectStatus
		{
			get { return _RequiredObjectStatus; }
			set 
			{ 
				_RequiredObjectStatus = value;
				OnPropertyChanged("RequiredObjectStatus");
			}
		}
		#endregion

		#region CTor
		public KalturaBulkUploadResultCategoryUser()
		{
		}

		public KalturaBulkUploadResultCategoryUser(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "categoryId":
						this._CategoryId = ParseInt(txt);
						continue;
					case "categoryReferenceId":
						this._CategoryReferenceId = txt;
						continue;
					case "userId":
						this._UserId = txt;
						continue;
					case "permissionLevel":
						this._PermissionLevel = ParseInt(txt);
						continue;
					case "updateMethod":
						this._UpdateMethod = ParseInt(txt);
						continue;
					case "requiredObjectStatus":
						this._RequiredObjectStatus = ParseInt(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaBulkUploadResultCategoryUser");
			kparams.AddIfNotNull("categoryId", this.CategoryId);
			kparams.AddIfNotNull("categoryReferenceId", this.CategoryReferenceId);
			kparams.AddIfNotNull("userId", this.UserId);
			kparams.AddIfNotNull("permissionLevel", this.PermissionLevel);
			kparams.AddIfNotNull("updateMethod", this.UpdateMethod);
			kparams.AddIfNotNull("requiredObjectStatus", this.RequiredObjectStatus);
			return kparams;
		}
		#endregion
	}
}

