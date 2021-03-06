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
using System.IO;
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;

namespace Kaltura.Services
{
	public class MessageTemplateGetRequestBuilder : StandaloneRequestBuilder<MessageTemplate>
	{
		#region Constants
		public const string ASSET_TYPE = "assetType";
		#endregion

		public OTTAssetType AssetType
		{
			set;
			get;
		}

		public MessageTemplateGetRequestBuilder()
			: base("messagetemplate", "get")
		{
		}

		public MessageTemplateGetRequestBuilder(OTTAssetType assetType)
			: this()
		{
			this.AssetType = assetType;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("assetType"))
				kparams.AddIfNotNull("assetType", AssetType);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<MessageTemplate>(result);
		}
	}

	public class MessageTemplateUpdateRequestBuilder : StandaloneRequestBuilder<MessageTemplate>
	{
		#region Constants
		public const string ASSET_TYPE = "assetType";
		public const string TEMPLATE = "template";
		#endregion

		public OTTAssetType AssetType
		{
			set;
			get;
		}
		public MessageTemplate Template
		{
			set;
			get;
		}

		public MessageTemplateUpdateRequestBuilder()
			: base("messagetemplate", "update")
		{
		}

		public MessageTemplateUpdateRequestBuilder(OTTAssetType assetType, MessageTemplate template)
			: this()
		{
			this.AssetType = assetType;
			this.Template = template;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("assetType"))
				kparams.AddIfNotNull("assetType", AssetType);
			if (!isMapped("template"))
				kparams.AddIfNotNull("template", Template);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<MessageTemplate>(result);
		}
	}


	public class MessageTemplateService
	{
		private MessageTemplateService()
		{
		}

		public static MessageTemplateGetRequestBuilder Get(OTTAssetType assetType)
		{
			return new MessageTemplateGetRequestBuilder(assetType);
		}

		public static MessageTemplateUpdateRequestBuilder Update(OTTAssetType assetType, MessageTemplate template)
		{
			return new MessageTemplateUpdateRequestBuilder(assetType, template);
		}
	}
}
