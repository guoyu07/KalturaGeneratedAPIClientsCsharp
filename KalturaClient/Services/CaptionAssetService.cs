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
using System.IO;
using Kaltura.Request;
using Kaltura.Types;
using Kaltura.Enums;

namespace Kaltura.Services
{
	public class CaptionAssetAddRequestBuilder : RequestBuilder<CaptionAsset>
	{
		#region Constants
		public const string ENTRY_ID = "entryId";
		public const string CAPTION_ASSET = "captionAsset";
		#endregion

		public string EntryId
		{
			set;
			get;
		}
		public CaptionAsset CaptionAsset
		{
			set;
			get;
		}

		public CaptionAssetAddRequestBuilder()
			: base("caption_captionasset", "add")
		{
		}

		public CaptionAssetAddRequestBuilder(string entryId, CaptionAsset captionAsset)
			: this()
		{
			this.EntryId = entryId;
			this.CaptionAsset = captionAsset;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("entryId"))
				kparams.AddIfNotNull("entryId", EntryId);
			if (!isMapped("captionAsset"))
				kparams.AddIfNotNull("captionAsset", CaptionAsset);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<CaptionAsset>(result);
		}
	}

	public class CaptionAssetDeleteRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string CAPTION_ASSET_ID = "captionAssetId";
		#endregion

		public string CaptionAssetId
		{
			set;
			get;
		}

		public CaptionAssetDeleteRequestBuilder()
			: base("caption_captionasset", "delete")
		{
		}

		public CaptionAssetDeleteRequestBuilder(string captionAssetId)
			: this()
		{
			this.CaptionAssetId = captionAssetId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("captionAssetId"))
				kparams.AddIfNotNull("captionAssetId", CaptionAssetId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return null;
		}
	}

	public class CaptionAssetGetRequestBuilder : RequestBuilder<CaptionAsset>
	{
		#region Constants
		public const string CAPTION_ASSET_ID = "captionAssetId";
		#endregion

		public string CaptionAssetId
		{
			set;
			get;
		}

		public CaptionAssetGetRequestBuilder()
			: base("caption_captionasset", "get")
		{
		}

		public CaptionAssetGetRequestBuilder(string captionAssetId)
			: this()
		{
			this.CaptionAssetId = captionAssetId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("captionAssetId"))
				kparams.AddIfNotNull("captionAssetId", CaptionAssetId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<CaptionAsset>(result);
		}
	}

	public class CaptionAssetGetRemotePathsRequestBuilder : RequestBuilder<ListResponse<RemotePath>>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public string Id
		{
			set;
			get;
		}

		public CaptionAssetGetRemotePathsRequestBuilder()
			: base("caption_captionasset", "getRemotePaths")
		{
		}

		public CaptionAssetGetRemotePathsRequestBuilder(string id)
			: this()
		{
			this.Id = id;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ListResponse<RemotePath>>(result);
		}
	}

	public class CaptionAssetGetUrlRequestBuilder : RequestBuilder<string>
	{
		#region Constants
		public const string ID = "id";
		public const string STORAGE_ID = "storageId";
		#endregion

		public string Id
		{
			set;
			get;
		}
		public int StorageId
		{
			set;
			get;
		}

		public CaptionAssetGetUrlRequestBuilder()
			: base("caption_captionasset", "getUrl")
		{
		}

		public CaptionAssetGetUrlRequestBuilder(string id, int storageId)
			: this()
		{
			this.Id = id;
			this.StorageId = storageId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("storageId"))
				kparams.AddIfNotNull("storageId", StorageId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return result.InnerText;
		}
	}

	public class CaptionAssetListRequestBuilder : RequestBuilder<ListResponse<CaptionAsset>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public AssetFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public CaptionAssetListRequestBuilder()
			: base("caption_captionasset", "list")
		{
		}

		public CaptionAssetListRequestBuilder(AssetFilter filter, FilterPager pager)
			: this()
		{
			this.Filter = filter;
			this.Pager = pager;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("filter"))
				kparams.AddIfNotNull("filter", Filter);
			if (!isMapped("pager"))
				kparams.AddIfNotNull("pager", Pager);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ListResponse<CaptionAsset>>(result);
		}
	}

	public class CaptionAssetSetAsDefaultRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string CAPTION_ASSET_ID = "captionAssetId";
		#endregion

		public string CaptionAssetId
		{
			set;
			get;
		}

		public CaptionAssetSetAsDefaultRequestBuilder()
			: base("caption_captionasset", "setAsDefault")
		{
		}

		public CaptionAssetSetAsDefaultRequestBuilder(string captionAssetId)
			: this()
		{
			this.CaptionAssetId = captionAssetId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("captionAssetId"))
				kparams.AddIfNotNull("captionAssetId", CaptionAssetId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return null;
		}
	}

	public class CaptionAssetSetContentRequestBuilder : RequestBuilder<CaptionAsset>
	{
		#region Constants
		public const string ID = "id";
		public const string CONTENT_RESOURCE = "contentResource";
		#endregion

		public string Id
		{
			set;
			get;
		}
		public ContentResource ContentResource
		{
			set;
			get;
		}

		public CaptionAssetSetContentRequestBuilder()
			: base("caption_captionasset", "setContent")
		{
		}

		public CaptionAssetSetContentRequestBuilder(string id, ContentResource contentResource)
			: this()
		{
			this.Id = id;
			this.ContentResource = contentResource;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("contentResource"))
				kparams.AddIfNotNull("contentResource", ContentResource);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<CaptionAsset>(result);
		}
	}

	public class CaptionAssetUpdateRequestBuilder : RequestBuilder<CaptionAsset>
	{
		#region Constants
		public const string ID = "id";
		public const string CAPTION_ASSET = "captionAsset";
		#endregion

		public string Id
		{
			set;
			get;
		}
		public CaptionAsset CaptionAsset
		{
			set;
			get;
		}

		public CaptionAssetUpdateRequestBuilder()
			: base("caption_captionasset", "update")
		{
		}

		public CaptionAssetUpdateRequestBuilder(string id, CaptionAsset captionAsset)
			: this()
		{
			this.Id = id;
			this.CaptionAsset = captionAsset;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("captionAsset"))
				kparams.AddIfNotNull("captionAsset", CaptionAsset);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<CaptionAsset>(result);
		}
	}


	public class CaptionAssetService
	{
		private CaptionAssetService()
		{
		}

		public static CaptionAssetAddRequestBuilder Add(string entryId, CaptionAsset captionAsset)
		{
			return new CaptionAssetAddRequestBuilder(entryId, captionAsset);
		}

		public static CaptionAssetDeleteRequestBuilder Delete(string captionAssetId)
		{
			return new CaptionAssetDeleteRequestBuilder(captionAssetId);
		}

		public static CaptionAssetGetRequestBuilder Get(string captionAssetId)
		{
			return new CaptionAssetGetRequestBuilder(captionAssetId);
		}

		public static CaptionAssetGetRemotePathsRequestBuilder GetRemotePaths(string id)
		{
			return new CaptionAssetGetRemotePathsRequestBuilder(id);
		}

		public static CaptionAssetGetUrlRequestBuilder GetUrl(string id, int storageId = Int32.MinValue)
		{
			return new CaptionAssetGetUrlRequestBuilder(id, storageId);
		}

		public static CaptionAssetListRequestBuilder List(AssetFilter filter = null, FilterPager pager = null)
		{
			return new CaptionAssetListRequestBuilder(filter, pager);
		}

		public static CaptionAssetSetAsDefaultRequestBuilder SetAsDefault(string captionAssetId)
		{
			return new CaptionAssetSetAsDefaultRequestBuilder(captionAssetId);
		}

		public static CaptionAssetSetContentRequestBuilder SetContent(string id, ContentResource contentResource)
		{
			return new CaptionAssetSetContentRequestBuilder(id, contentResource);
		}

		public static CaptionAssetUpdateRequestBuilder Update(string id, CaptionAsset captionAsset)
		{
			return new CaptionAssetUpdateRequestBuilder(id, captionAsset);
		}
	}
}
