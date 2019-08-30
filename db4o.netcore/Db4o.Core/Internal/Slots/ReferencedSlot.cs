/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

using Db4o.Foundation;
using Db4o.Internal;

namespace Db4o.Internal.Slots
{
	/// <exclude></exclude>
	public class ReferencedSlot : TreeInt
	{
		private Db4o.Internal.Slots.Slot _slot;

		private int _references;

		public ReferencedSlot(int a_key) : base(a_key)
		{
		}

		public override object ShallowClone()
		{
			Db4o.Internal.Slots.ReferencedSlot rs = new Db4o.Internal.Slots.ReferencedSlot
				(_key);
			rs._slot = _slot;
			rs._references = _references;
			return base.ShallowCloneInternal(rs);
		}

		public virtual void PointTo(Db4o.Internal.Slots.Slot slot)
		{
			_slot = slot;
		}

		public virtual Tree Free(LocalObjectContainer file, Tree treeRoot, Db4o.Internal.Slots.Slot
			 slot)
		{
			file.Free(_slot.Address(), _slot.Length());
			if (RemoveReferenceIsLast())
			{
				if (treeRoot != null)
				{
					return treeRoot.RemoveNode(this);
				}
			}
			PointTo(slot);
			return treeRoot;
		}

		public virtual bool AddReferenceIsFirst()
		{
			_references++;
			return (_references == 1);
		}

		public virtual bool RemoveReferenceIsLast()
		{
			_references--;
			return _references < 1;
		}

		public virtual Db4o.Internal.Slots.Slot Slot()
		{
			return _slot;
		}
	}
}
