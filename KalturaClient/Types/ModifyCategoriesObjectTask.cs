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
using Kaltura.Enums;
using Kaltura.Request;

namespace Kaltura.Types
{
	public class ModifyCategoriesObjectTask : ObjectTask
	{
		#region Constants
		public const string ADD_REMOVE_TYPE = "addRemoveType";
		public const string CATEGORY_IDS = "categoryIds";
		#endregion

		#region Private Fields
		private ScheduledTaskAddOrRemoveType _AddRemoveType = (ScheduledTaskAddOrRemoveType)Int32.MinValue;
		private IList<IntegerValue> _CategoryIds;
		#endregion

		#region Properties
		public ScheduledTaskAddOrRemoveType AddRemoveType
		{
			get { return _AddRemoveType; }
			set 
			{ 
				_AddRemoveType = value;
				OnPropertyChanged("AddRemoveType");
			}
		}
		public IList<IntegerValue> CategoryIds
		{
			get { return _CategoryIds; }
			set 
			{ 
				_CategoryIds = value;
				OnPropertyChanged("CategoryIds");
			}
		}
		#endregion

		#region CTor
		public ModifyCategoriesObjectTask()
		{
		}

		public ModifyCategoriesObjectTask(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "addRemoveType":
						this._AddRemoveType = (ScheduledTaskAddOrRemoveType)ParseEnum(typeof(ScheduledTaskAddOrRemoveType), propertyNode.InnerText);
						continue;
					case "categoryIds":
						this._CategoryIds = new List<IntegerValue>();
						foreach(XmlElement arrayNode in propertyNode.ChildNodes)
						{
							this._CategoryIds.Add(ObjectFactory.Create<IntegerValue>(arrayNode));
						}
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
				kparams.AddReplace("objectType", "KalturaModifyCategoriesObjectTask");
			kparams.AddIfNotNull("addRemoveType", this._AddRemoveType);
			kparams.AddIfNotNull("categoryIds", this._CategoryIds);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ADD_REMOVE_TYPE:
					return "AddRemoveType";
				case CATEGORY_IDS:
					return "CategoryIds";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

