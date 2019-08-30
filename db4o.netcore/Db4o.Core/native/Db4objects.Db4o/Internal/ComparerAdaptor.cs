/* Copyright (C) 2007   Versant Inc.   http://www.db4o.com */
using System;
using System.Text;

namespace Db4o.Internal
{
    class ComparerAdaptor : Db4o.Query.IQueryComparator
    {
        private System.Collections.IComparer _comparer;

        public ComparerAdaptor(System.Collections.IComparer comparer)
        {
            _comparer = comparer;
        }

        public int Compare(object first, object second)
        {
            return _comparer.Compare(first, second);
        }
    }
}
