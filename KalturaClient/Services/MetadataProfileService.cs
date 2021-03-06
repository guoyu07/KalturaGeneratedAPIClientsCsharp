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
	public class MetadataProfileAddRequestBuilder : RequestBuilder<MetadataProfile>
	{
		#region Constants
		public const string METADATA_PROFILE = "metadataProfile";
		public const string XSD_DATA = "xsdData";
		public const string VIEWS_DATA = "viewsData";
		#endregion

		public MetadataProfile MetadataProfile
		{
			set;
			get;
		}
		public string XsdData
		{
			set;
			get;
		}
		public string ViewsData
		{
			set;
			get;
		}

		public MetadataProfileAddRequestBuilder()
			: base("metadata_metadataprofile", "add")
		{
		}

		public MetadataProfileAddRequestBuilder(MetadataProfile metadataProfile, string xsdData, string viewsData)
			: this()
		{
			this.MetadataProfile = metadataProfile;
			this.XsdData = xsdData;
			this.ViewsData = viewsData;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("metadataProfile"))
				kparams.AddIfNotNull("metadataProfile", MetadataProfile);
			if (!isMapped("xsdData"))
				kparams.AddIfNotNull("xsdData", XsdData);
			if (!isMapped("viewsData"))
				kparams.AddIfNotNull("viewsData", ViewsData);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<MetadataProfile>(result);
		}
	}

	public class MetadataProfileAddFromFileRequestBuilder : RequestBuilder<MetadataProfile>
	{
		#region Constants
		public const string METADATA_PROFILE = "metadataProfile";
		public const string XSD_FILE = "xsdFile";
		public const string VIEWS_FILE = "viewsFile";
		#endregion

		public MetadataProfile MetadataProfile
		{
			set;
			get;
		}
		public Stream XsdFile
		{
			set;
			get;
		}
		public Stream ViewsFile
		{
			set;
			get;
		}

		public MetadataProfileAddFromFileRequestBuilder()
			: base("metadata_metadataprofile", "addFromFile")
		{
		}

		public MetadataProfileAddFromFileRequestBuilder(MetadataProfile metadataProfile, Stream xsdFile, Stream viewsFile)
			: this()
		{
			this.MetadataProfile = metadataProfile;
			this.XsdFile = xsdFile;
			this.ViewsFile = viewsFile;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("metadataProfile"))
				kparams.AddIfNotNull("metadataProfile", MetadataProfile);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			kfiles.Add("xsdFile", XsdFile);
			kfiles.Add("viewsFile", ViewsFile);
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<MetadataProfile>(result);
		}
	}

	public class MetadataProfileDeleteRequestBuilder : RequestBuilder<object>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public MetadataProfileDeleteRequestBuilder()
			: base("metadata_metadataprofile", "delete")
		{
		}

		public MetadataProfileDeleteRequestBuilder(int id)
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
			return null;
		}
	}

	public class MetadataProfileGetRequestBuilder : RequestBuilder<MetadataProfile>
	{
		#region Constants
		public const string ID = "id";
		#endregion

		public int Id
		{
			set;
			get;
		}

		public MetadataProfileGetRequestBuilder()
			: base("metadata_metadataprofile", "get")
		{
		}

		public MetadataProfileGetRequestBuilder(int id)
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
			return ObjectFactory.Create<MetadataProfile>(result);
		}
	}

	public class MetadataProfileListRequestBuilder : RequestBuilder<ListResponse<MetadataProfile>>
	{
		#region Constants
		public const string FILTER = "filter";
		public const string PAGER = "pager";
		#endregion

		public MetadataProfileFilter Filter
		{
			set;
			get;
		}
		public FilterPager Pager
		{
			set;
			get;
		}

		public MetadataProfileListRequestBuilder()
			: base("metadata_metadataprofile", "list")
		{
		}

		public MetadataProfileListRequestBuilder(MetadataProfileFilter filter, FilterPager pager)
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
			return ObjectFactory.Create<ListResponse<MetadataProfile>>(result);
		}
	}

	public class MetadataProfileListFieldsRequestBuilder : RequestBuilder<ListResponse<MetadataProfileField>>
	{
		#region Constants
		public const string METADATA_PROFILE_ID = "metadataProfileId";
		#endregion

		public int MetadataProfileId
		{
			set;
			get;
		}

		public MetadataProfileListFieldsRequestBuilder()
			: base("metadata_metadataprofile", "listFields")
		{
		}

		public MetadataProfileListFieldsRequestBuilder(int metadataProfileId)
			: this()
		{
			this.MetadataProfileId = metadataProfileId;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("metadataProfileId"))
				kparams.AddIfNotNull("metadataProfileId", MetadataProfileId);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<ListResponse<MetadataProfileField>>(result);
		}
	}

	public class MetadataProfileRevertRequestBuilder : RequestBuilder<MetadataProfile>
	{
		#region Constants
		public const string ID = "id";
		public const string TO_VERSION = "toVersion";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public int ToVersion
		{
			set;
			get;
		}

		public MetadataProfileRevertRequestBuilder()
			: base("metadata_metadataprofile", "revert")
		{
		}

		public MetadataProfileRevertRequestBuilder(int id, int toVersion)
			: this()
		{
			this.Id = id;
			this.ToVersion = toVersion;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("toVersion"))
				kparams.AddIfNotNull("toVersion", ToVersion);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<MetadataProfile>(result);
		}
	}

	public class MetadataProfileUpdateRequestBuilder : RequestBuilder<MetadataProfile>
	{
		#region Constants
		public const string ID = "id";
		public const string METADATA_PROFILE = "metadataProfile";
		public const string XSD_DATA = "xsdData";
		public const string VIEWS_DATA = "viewsData";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public MetadataProfile MetadataProfile
		{
			set;
			get;
		}
		public string XsdData
		{
			set;
			get;
		}
		public string ViewsData
		{
			set;
			get;
		}

		public MetadataProfileUpdateRequestBuilder()
			: base("metadata_metadataprofile", "update")
		{
		}

		public MetadataProfileUpdateRequestBuilder(int id, MetadataProfile metadataProfile, string xsdData, string viewsData)
			: this()
		{
			this.Id = id;
			this.MetadataProfile = metadataProfile;
			this.XsdData = xsdData;
			this.ViewsData = viewsData;
		}

		public override Params getParameters(bool includeServiceAndAction)
		{
			Params kparams = base.getParameters(includeServiceAndAction);
			if (!isMapped("id"))
				kparams.AddIfNotNull("id", Id);
			if (!isMapped("metadataProfile"))
				kparams.AddIfNotNull("metadataProfile", MetadataProfile);
			if (!isMapped("xsdData"))
				kparams.AddIfNotNull("xsdData", XsdData);
			if (!isMapped("viewsData"))
				kparams.AddIfNotNull("viewsData", ViewsData);
			return kparams;
		}

		public override Files getFiles()
		{
			Files kfiles = base.getFiles();
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<MetadataProfile>(result);
		}
	}

	public class MetadataProfileUpdateDefinitionFromFileRequestBuilder : RequestBuilder<MetadataProfile>
	{
		#region Constants
		public const string ID = "id";
		public const string XSD_FILE = "xsdFile";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public Stream XsdFile
		{
			set;
			get;
		}

		public MetadataProfileUpdateDefinitionFromFileRequestBuilder()
			: base("metadata_metadataprofile", "updateDefinitionFromFile")
		{
		}

		public MetadataProfileUpdateDefinitionFromFileRequestBuilder(int id, Stream xsdFile)
			: this()
		{
			this.Id = id;
			this.XsdFile = xsdFile;
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
			kfiles.Add("xsdFile", XsdFile);
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<MetadataProfile>(result);
		}
	}

	public class MetadataProfileUpdateTransformationFromFileRequestBuilder : RequestBuilder<MetadataProfile>
	{
		#region Constants
		public const string ID = "id";
		public const string XSLT_FILE = "xsltFile";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public Stream XsltFile
		{
			set;
			get;
		}

		public MetadataProfileUpdateTransformationFromFileRequestBuilder()
			: base("metadata_metadataprofile", "updateTransformationFromFile")
		{
		}

		public MetadataProfileUpdateTransformationFromFileRequestBuilder(int id, Stream xsltFile)
			: this()
		{
			this.Id = id;
			this.XsltFile = xsltFile;
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
			kfiles.Add("xsltFile", XsltFile);
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<MetadataProfile>(result);
		}
	}

	public class MetadataProfileUpdateViewsFromFileRequestBuilder : RequestBuilder<MetadataProfile>
	{
		#region Constants
		public const string ID = "id";
		public const string VIEWS_FILE = "viewsFile";
		#endregion

		public int Id
		{
			set;
			get;
		}
		public Stream ViewsFile
		{
			set;
			get;
		}

		public MetadataProfileUpdateViewsFromFileRequestBuilder()
			: base("metadata_metadataprofile", "updateViewsFromFile")
		{
		}

		public MetadataProfileUpdateViewsFromFileRequestBuilder(int id, Stream viewsFile)
			: this()
		{
			this.Id = id;
			this.ViewsFile = viewsFile;
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
			kfiles.Add("viewsFile", ViewsFile);
			return kfiles;
		}

		public override object Deserialize(XmlElement result)
		{
			return ObjectFactory.Create<MetadataProfile>(result);
		}
	}


	public class MetadataProfileService
	{
		private MetadataProfileService()
		{
		}

		public static MetadataProfileAddRequestBuilder Add(MetadataProfile metadataProfile, string xsdData, string viewsData = null)
		{
			return new MetadataProfileAddRequestBuilder(metadataProfile, xsdData, viewsData);
		}

		public static MetadataProfileAddFromFileRequestBuilder AddFromFile(MetadataProfile metadataProfile, Stream xsdFile, Stream viewsFile = null)
		{
			return new MetadataProfileAddFromFileRequestBuilder(metadataProfile, xsdFile, viewsFile);
		}

		public static MetadataProfileDeleteRequestBuilder Delete(int id)
		{
			return new MetadataProfileDeleteRequestBuilder(id);
		}

		public static MetadataProfileGetRequestBuilder Get(int id)
		{
			return new MetadataProfileGetRequestBuilder(id);
		}

		public static MetadataProfileListRequestBuilder List(MetadataProfileFilter filter = null, FilterPager pager = null)
		{
			return new MetadataProfileListRequestBuilder(filter, pager);
		}

		public static MetadataProfileListFieldsRequestBuilder ListFields(int metadataProfileId)
		{
			return new MetadataProfileListFieldsRequestBuilder(metadataProfileId);
		}

		public static MetadataProfileRevertRequestBuilder Revert(int id, int toVersion)
		{
			return new MetadataProfileRevertRequestBuilder(id, toVersion);
		}

		public static MetadataProfileUpdateRequestBuilder Update(int id, MetadataProfile metadataProfile, string xsdData = null, string viewsData = null)
		{
			return new MetadataProfileUpdateRequestBuilder(id, metadataProfile, xsdData, viewsData);
		}

		public static MetadataProfileUpdateDefinitionFromFileRequestBuilder UpdateDefinitionFromFile(int id, Stream xsdFile)
		{
			return new MetadataProfileUpdateDefinitionFromFileRequestBuilder(id, xsdFile);
		}

		public static MetadataProfileUpdateTransformationFromFileRequestBuilder UpdateTransformationFromFile(int id, Stream xsltFile)
		{
			return new MetadataProfileUpdateTransformationFromFileRequestBuilder(id, xsltFile);
		}

		public static MetadataProfileUpdateViewsFromFileRequestBuilder UpdateViewsFromFile(int id, Stream viewsFile)
		{
			return new MetadataProfileUpdateViewsFromFileRequestBuilder(id, viewsFile);
		}
	}
}
