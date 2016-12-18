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
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class AmazonS3StorageExportJobData : StorageExportJobData
	{
		#region Constants
		public const string FILES_PERMISSION_IN_S3 = "filesPermissionInS3";
		public const string S3REGION = "s3Region";
		public const string SSE_TYPE = "sseType";
		public const string SSE_KMS_KEY_ID = "sseKmsKeyId";
		public const string SIGNATURE_TYPE = "signatureType";
		public const string END_POINT = "endPoint";
		#endregion

		#region Private Fields
		private AmazonS3StorageProfileFilesPermissionLevel _FilesPermissionInS3 = null;
		private string _S3Region = null;
		private string _SseType = null;
		private string _SseKmsKeyId = null;
		private string _SignatureType = null;
		private string _EndPoint = null;
		#endregion

		#region Properties
		public AmazonS3StorageProfileFilesPermissionLevel FilesPermissionInS3
		{
			get { return _FilesPermissionInS3; }
			set 
			{ 
				_FilesPermissionInS3 = value;
				OnPropertyChanged("FilesPermissionInS3");
			}
		}
		public string S3Region
		{
			get { return _S3Region; }
			set 
			{ 
				_S3Region = value;
				OnPropertyChanged("S3Region");
			}
		}
		public string SseType
		{
			get { return _SseType; }
			set 
			{ 
				_SseType = value;
				OnPropertyChanged("SseType");
			}
		}
		public string SseKmsKeyId
		{
			get { return _SseKmsKeyId; }
			set 
			{ 
				_SseKmsKeyId = value;
				OnPropertyChanged("SseKmsKeyId");
			}
		}
		public string SignatureType
		{
			get { return _SignatureType; }
			set 
			{ 
				_SignatureType = value;
				OnPropertyChanged("SignatureType");
			}
		}
		public string EndPoint
		{
			get { return _EndPoint; }
			set 
			{ 
				_EndPoint = value;
				OnPropertyChanged("EndPoint");
			}
		}
		#endregion

		#region CTor
		public AmazonS3StorageExportJobData()
		{
		}

		public AmazonS3StorageExportJobData(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				string txt = propertyNode.InnerText;
				switch (propertyNode.Name)
				{
					case "filesPermissionInS3":
						this._FilesPermissionInS3 = (AmazonS3StorageProfileFilesPermissionLevel)StringEnum.Parse(typeof(AmazonS3StorageProfileFilesPermissionLevel), txt);
						continue;
					case "s3Region":
						this._S3Region = txt;
						continue;
					case "sseType":
						this._SseType = txt;
						continue;
					case "sseKmsKeyId":
						this._SseKmsKeyId = txt;
						continue;
					case "signatureType":
						this._SignatureType = txt;
						continue;
					case "endPoint":
						this._EndPoint = txt;
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
				kparams.AddReplace("objectType", "KalturaAmazonS3StorageExportJobData");
			kparams.AddIfNotNull("filesPermissionInS3", this._FilesPermissionInS3);
			kparams.AddIfNotNull("s3Region", this._S3Region);
			kparams.AddIfNotNull("sseType", this._SseType);
			kparams.AddIfNotNull("sseKmsKeyId", this._SseKmsKeyId);
			kparams.AddIfNotNull("signatureType", this._SignatureType);
			kparams.AddIfNotNull("endPoint", this._EndPoint);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case FILES_PERMISSION_IN_S3:
					return "FilesPermissionInS3";
				case S3REGION:
					return "S3Region";
				case SSE_TYPE:
					return "SseType";
				case SSE_KMS_KEY_ID:
					return "SseKmsKeyId";
				case SIGNATURE_TYPE:
					return "SignatureType";
				case END_POINT:
					return "EndPoint";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}
