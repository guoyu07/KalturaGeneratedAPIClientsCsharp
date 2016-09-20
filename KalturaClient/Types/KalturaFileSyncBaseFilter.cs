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
	public class KalturaFileSyncBaseFilter : KalturaFilter
	{
		#region Private Fields
		private int _PartnerIdEqual = Int32.MinValue;
		private KalturaFileSyncObjectType _FileObjectTypeEqual = null;
		private string _FileObjectTypeIn = null;
		private string _ObjectIdEqual = null;
		private string _ObjectIdIn = null;
		private string _VersionEqual = null;
		private string _VersionIn = null;
		private int _ObjectSubTypeEqual = Int32.MinValue;
		private string _ObjectSubTypeIn = null;
		private string _DcEqual = null;
		private string _DcIn = null;
		private int _OriginalEqual = Int32.MinValue;
		private int _CreatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _CreatedAtLessThanOrEqual = Int32.MinValue;
		private int _UpdatedAtGreaterThanOrEqual = Int32.MinValue;
		private int _UpdatedAtLessThanOrEqual = Int32.MinValue;
		private int _ReadyAtGreaterThanOrEqual = Int32.MinValue;
		private int _ReadyAtLessThanOrEqual = Int32.MinValue;
		private int _SyncTimeGreaterThanOrEqual = Int32.MinValue;
		private int _SyncTimeLessThanOrEqual = Int32.MinValue;
		private KalturaFileSyncStatus _StatusEqual = (KalturaFileSyncStatus)Int32.MinValue;
		private string _StatusIn = null;
		private KalturaFileSyncType _FileTypeEqual = (KalturaFileSyncType)Int32.MinValue;
		private string _FileTypeIn = null;
		private int _LinkedIdEqual = Int32.MinValue;
		private int _LinkCountGreaterThanOrEqual = Int32.MinValue;
		private int _LinkCountLessThanOrEqual = Int32.MinValue;
		private float _FileSizeGreaterThanOrEqual = Single.MinValue;
		private float _FileSizeLessThanOrEqual = Single.MinValue;
		#endregion

		#region Properties
		public int PartnerIdEqual
		{
			get { return _PartnerIdEqual; }
			set 
			{ 
				_PartnerIdEqual = value;
				OnPropertyChanged("PartnerIdEqual");
			}
		}
		public KalturaFileSyncObjectType FileObjectTypeEqual
		{
			get { return _FileObjectTypeEqual; }
			set 
			{ 
				_FileObjectTypeEqual = value;
				OnPropertyChanged("FileObjectTypeEqual");
			}
		}
		public string FileObjectTypeIn
		{
			get { return _FileObjectTypeIn; }
			set 
			{ 
				_FileObjectTypeIn = value;
				OnPropertyChanged("FileObjectTypeIn");
			}
		}
		public string ObjectIdEqual
		{
			get { return _ObjectIdEqual; }
			set 
			{ 
				_ObjectIdEqual = value;
				OnPropertyChanged("ObjectIdEqual");
			}
		}
		public string ObjectIdIn
		{
			get { return _ObjectIdIn; }
			set 
			{ 
				_ObjectIdIn = value;
				OnPropertyChanged("ObjectIdIn");
			}
		}
		public string VersionEqual
		{
			get { return _VersionEqual; }
			set 
			{ 
				_VersionEqual = value;
				OnPropertyChanged("VersionEqual");
			}
		}
		public string VersionIn
		{
			get { return _VersionIn; }
			set 
			{ 
				_VersionIn = value;
				OnPropertyChanged("VersionIn");
			}
		}
		public int ObjectSubTypeEqual
		{
			get { return _ObjectSubTypeEqual; }
			set 
			{ 
				_ObjectSubTypeEqual = value;
				OnPropertyChanged("ObjectSubTypeEqual");
			}
		}
		public string ObjectSubTypeIn
		{
			get { return _ObjectSubTypeIn; }
			set 
			{ 
				_ObjectSubTypeIn = value;
				OnPropertyChanged("ObjectSubTypeIn");
			}
		}
		public string DcEqual
		{
			get { return _DcEqual; }
			set 
			{ 
				_DcEqual = value;
				OnPropertyChanged("DcEqual");
			}
		}
		public string DcIn
		{
			get { return _DcIn; }
			set 
			{ 
				_DcIn = value;
				OnPropertyChanged("DcIn");
			}
		}
		public int OriginalEqual
		{
			get { return _OriginalEqual; }
			set 
			{ 
				_OriginalEqual = value;
				OnPropertyChanged("OriginalEqual");
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
		public int ReadyAtGreaterThanOrEqual
		{
			get { return _ReadyAtGreaterThanOrEqual; }
			set 
			{ 
				_ReadyAtGreaterThanOrEqual = value;
				OnPropertyChanged("ReadyAtGreaterThanOrEqual");
			}
		}
		public int ReadyAtLessThanOrEqual
		{
			get { return _ReadyAtLessThanOrEqual; }
			set 
			{ 
				_ReadyAtLessThanOrEqual = value;
				OnPropertyChanged("ReadyAtLessThanOrEqual");
			}
		}
		public int SyncTimeGreaterThanOrEqual
		{
			get { return _SyncTimeGreaterThanOrEqual; }
			set 
			{ 
				_SyncTimeGreaterThanOrEqual = value;
				OnPropertyChanged("SyncTimeGreaterThanOrEqual");
			}
		}
		public int SyncTimeLessThanOrEqual
		{
			get { return _SyncTimeLessThanOrEqual; }
			set 
			{ 
				_SyncTimeLessThanOrEqual = value;
				OnPropertyChanged("SyncTimeLessThanOrEqual");
			}
		}
		public KalturaFileSyncStatus StatusEqual
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
		public KalturaFileSyncType FileTypeEqual
		{
			get { return _FileTypeEqual; }
			set 
			{ 
				_FileTypeEqual = value;
				OnPropertyChanged("FileTypeEqual");
			}
		}
		public string FileTypeIn
		{
			get { return _FileTypeIn; }
			set 
			{ 
				_FileTypeIn = value;
				OnPropertyChanged("FileTypeIn");
			}
		}
		public int LinkedIdEqual
		{
			get { return _LinkedIdEqual; }
			set 
			{ 
				_LinkedIdEqual = value;
				OnPropertyChanged("LinkedIdEqual");
			}
		}
		public int LinkCountGreaterThanOrEqual
		{
			get { return _LinkCountGreaterThanOrEqual; }
			set 
			{ 
				_LinkCountGreaterThanOrEqual = value;
				OnPropertyChanged("LinkCountGreaterThanOrEqual");
			}
		}
		public int LinkCountLessThanOrEqual
		{
			get { return _LinkCountLessThanOrEqual; }
			set 
			{ 
				_LinkCountLessThanOrEqual = value;
				OnPropertyChanged("LinkCountLessThanOrEqual");
			}
		}
		public float FileSizeGreaterThanOrEqual
		{
			get { return _FileSizeGreaterThanOrEqual; }
			set 
			{ 
				_FileSizeGreaterThanOrEqual = value;
				OnPropertyChanged("FileSizeGreaterThanOrEqual");
			}
		}
		public float FileSizeLessThanOrEqual
		{
			get { return _FileSizeLessThanOrEqual; }
			set 
			{ 
				_FileSizeLessThanOrEqual = value;
				OnPropertyChanged("FileSizeLessThanOrEqual");
			}
		}
		#endregion

		#region CTor
		public KalturaFileSyncBaseFilter()
		{
		}

		public KalturaFileSyncBaseFilter(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "partnerIdEqual":
						this._PartnerIdEqual = ParseInt(txt);
						continue;
					case "fileObjectTypeEqual":
						this._FileObjectTypeEqual = (KalturaFileSyncObjectType)KalturaStringEnum.Parse(typeof(KalturaFileSyncObjectType), txt);
						continue;
					case "fileObjectTypeIn":
						this._FileObjectTypeIn = txt;
						continue;
					case "objectIdEqual":
						this._ObjectIdEqual = txt;
						continue;
					case "objectIdIn":
						this._ObjectIdIn = txt;
						continue;
					case "versionEqual":
						this._VersionEqual = txt;
						continue;
					case "versionIn":
						this._VersionIn = txt;
						continue;
					case "objectSubTypeEqual":
						this._ObjectSubTypeEqual = ParseInt(txt);
						continue;
					case "objectSubTypeIn":
						this._ObjectSubTypeIn = txt;
						continue;
					case "dcEqual":
						this._DcEqual = txt;
						continue;
					case "dcIn":
						this._DcIn = txt;
						continue;
					case "originalEqual":
						this._OriginalEqual = ParseInt(txt);
						continue;
					case "createdAtGreaterThanOrEqual":
						this._CreatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "createdAtLessThanOrEqual":
						this._CreatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtGreaterThanOrEqual":
						this._UpdatedAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "updatedAtLessThanOrEqual":
						this._UpdatedAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "readyAtGreaterThanOrEqual":
						this._ReadyAtGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "readyAtLessThanOrEqual":
						this._ReadyAtLessThanOrEqual = ParseInt(txt);
						continue;
					case "syncTimeGreaterThanOrEqual":
						this._SyncTimeGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "syncTimeLessThanOrEqual":
						this._SyncTimeLessThanOrEqual = ParseInt(txt);
						continue;
					case "statusEqual":
						this._StatusEqual = (KalturaFileSyncStatus)ParseEnum(typeof(KalturaFileSyncStatus), txt);
						continue;
					case "statusIn":
						this._StatusIn = txt;
						continue;
					case "fileTypeEqual":
						this._FileTypeEqual = (KalturaFileSyncType)ParseEnum(typeof(KalturaFileSyncType), txt);
						continue;
					case "fileTypeIn":
						this._FileTypeIn = txt;
						continue;
					case "linkedIdEqual":
						this._LinkedIdEqual = ParseInt(txt);
						continue;
					case "linkCountGreaterThanOrEqual":
						this._LinkCountGreaterThanOrEqual = ParseInt(txt);
						continue;
					case "linkCountLessThanOrEqual":
						this._LinkCountLessThanOrEqual = ParseInt(txt);
						continue;
					case "fileSizeGreaterThanOrEqual":
						this._FileSizeGreaterThanOrEqual = ParseFloat(txt);
						continue;
					case "fileSizeLessThanOrEqual":
						this._FileSizeLessThanOrEqual = ParseFloat(txt);
						continue;
				}
			}
		}
		#endregion

		#region Methods
		public override KalturaParams ToParams()
		{
			KalturaParams kparams = base.ToParams();
			kparams.AddReplace("objectType", "KalturaFileSyncBaseFilter");
			kparams.AddIfNotNull("partnerIdEqual", this.PartnerIdEqual);
			kparams.AddIfNotNull("fileObjectTypeEqual", this.FileObjectTypeEqual);
			kparams.AddIfNotNull("fileObjectTypeIn", this.FileObjectTypeIn);
			kparams.AddIfNotNull("objectIdEqual", this.ObjectIdEqual);
			kparams.AddIfNotNull("objectIdIn", this.ObjectIdIn);
			kparams.AddIfNotNull("versionEqual", this.VersionEqual);
			kparams.AddIfNotNull("versionIn", this.VersionIn);
			kparams.AddIfNotNull("objectSubTypeEqual", this.ObjectSubTypeEqual);
			kparams.AddIfNotNull("objectSubTypeIn", this.ObjectSubTypeIn);
			kparams.AddIfNotNull("dcEqual", this.DcEqual);
			kparams.AddIfNotNull("dcIn", this.DcIn);
			kparams.AddIfNotNull("originalEqual", this.OriginalEqual);
			kparams.AddIfNotNull("createdAtGreaterThanOrEqual", this.CreatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("createdAtLessThanOrEqual", this.CreatedAtLessThanOrEqual);
			kparams.AddIfNotNull("updatedAtGreaterThanOrEqual", this.UpdatedAtGreaterThanOrEqual);
			kparams.AddIfNotNull("updatedAtLessThanOrEqual", this.UpdatedAtLessThanOrEqual);
			kparams.AddIfNotNull("readyAtGreaterThanOrEqual", this.ReadyAtGreaterThanOrEqual);
			kparams.AddIfNotNull("readyAtLessThanOrEqual", this.ReadyAtLessThanOrEqual);
			kparams.AddIfNotNull("syncTimeGreaterThanOrEqual", this.SyncTimeGreaterThanOrEqual);
			kparams.AddIfNotNull("syncTimeLessThanOrEqual", this.SyncTimeLessThanOrEqual);
			kparams.AddIfNotNull("statusEqual", this.StatusEqual);
			kparams.AddIfNotNull("statusIn", this.StatusIn);
			kparams.AddIfNotNull("fileTypeEqual", this.FileTypeEqual);
			kparams.AddIfNotNull("fileTypeIn", this.FileTypeIn);
			kparams.AddIfNotNull("linkedIdEqual", this.LinkedIdEqual);
			kparams.AddIfNotNull("linkCountGreaterThanOrEqual", this.LinkCountGreaterThanOrEqual);
			kparams.AddIfNotNull("linkCountLessThanOrEqual", this.LinkCountLessThanOrEqual);
			kparams.AddIfNotNull("fileSizeGreaterThanOrEqual", this.FileSizeGreaterThanOrEqual);
			kparams.AddIfNotNull("fileSizeLessThanOrEqual", this.FileSizeLessThanOrEqual);
			return kparams;
		}
		#endregion
	}
}

