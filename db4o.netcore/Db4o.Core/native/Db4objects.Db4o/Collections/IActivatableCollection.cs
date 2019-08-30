﻿/* Copyright (C) 2010  Versant Inc.   http://www.db4o.com */
using System.Collections.Generic;
using Db4o.TA;

namespace Db4o.Collections
{
	public interface IActivatableCollection<T> : ICollection<T>, IActivatable
	{
	}
}
