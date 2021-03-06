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
	public class DistributionValidationError : ObjectBase
	{
		#region Constants
		public const string ACTION = "action";
		public const string ERROR_TYPE = "errorType";
		public const string DESCRIPTION = "description";
		#endregion

		#region Private Fields
		private DistributionAction _Action = (DistributionAction)Int32.MinValue;
		private DistributionErrorType _ErrorType = (DistributionErrorType)Int32.MinValue;
		private string _Description = null;
		#endregion

		#region Properties
		public DistributionAction Action
		{
			get { return _Action; }
			set 
			{ 
				_Action = value;
				OnPropertyChanged("Action");
			}
		}
		public DistributionErrorType ErrorType
		{
			get { return _ErrorType; }
			set 
			{ 
				_ErrorType = value;
				OnPropertyChanged("ErrorType");
			}
		}
		public string Description
		{
			get { return _Description; }
			set 
			{ 
				_Description = value;
				OnPropertyChanged("Description");
			}
		}
		#endregion

		#region CTor
		public DistributionValidationError()
		{
		}

		public DistributionValidationError(XmlElement node) : base(node)
		{
			foreach (XmlElement propertyNode in node.ChildNodes)
			{
				switch (propertyNode.Name)
				{
					case "action":
						this._Action = (DistributionAction)ParseEnum(typeof(DistributionAction), propertyNode.InnerText);
						continue;
					case "errorType":
						this._ErrorType = (DistributionErrorType)ParseEnum(typeof(DistributionErrorType), propertyNode.InnerText);
						continue;
					case "description":
						this._Description = propertyNode.InnerText;
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
				kparams.AddReplace("objectType", "KalturaDistributionValidationError");
			kparams.AddIfNotNull("action", this._Action);
			kparams.AddIfNotNull("errorType", this._ErrorType);
			kparams.AddIfNotNull("description", this._Description);
			return kparams;
		}
		protected override string getPropertyName(string apiName)
		{
			switch(apiName)
			{
				case ACTION:
					return "Action";
				case ERROR_TYPE:
					return "ErrorType";
				case DESCRIPTION:
					return "Description";
				default:
					return base.getPropertyName(apiName);
			}
		}
		#endregion
	}
}

