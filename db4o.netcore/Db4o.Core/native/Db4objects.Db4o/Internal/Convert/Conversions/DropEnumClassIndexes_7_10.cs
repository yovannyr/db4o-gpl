﻿/* Copyright (C) 2009  Versant Inc.  http://www.db4o.com */
using System;
using Db4o.Reflect.Net;

namespace Db4o.Internal.Convert.Conversions
{
	public partial class DropEnumClassIndexes_7_10 : DropClassIndexesConversion
	{
		protected override bool Accept(ClassMetadata classmetadata)
		{
			Type type = NetReflector.ToNative(classmetadata.ClassReflector());
			return type != null ? type.IsEnum : false;
		}
	}
}
