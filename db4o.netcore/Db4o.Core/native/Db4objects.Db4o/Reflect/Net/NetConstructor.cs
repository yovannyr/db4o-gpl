/* Copyright (C) 2007   Versant Inc.   http://www.db4o.com */
namespace Db4o.Reflect.Net
{

	/// <remarks>Reflection implementation for Constructor to map to .NET reflection.</remarks>
	public class NetConstructor : Db4o.Reflect.Core.IReflectConstructor
	{
		private readonly Db4o.Reflect.IReflector reflector;

		private readonly System.Reflection.ConstructorInfo constructor;

		public NetConstructor(Db4o.Reflect.IReflector reflector, System.Reflection.ConstructorInfo
			 constructor)
		{
			this.reflector = reflector;
			this.constructor = constructor;
			Db4o.Internal.Platform4.SetAccessible(constructor);
		}

		public virtual Db4o.Reflect.IReflectClass[] GetParameterTypes()
		{
			return Db4o.Reflect.Net.NetReflector.ToMeta(reflector, Sharpen.Runtime.GetParameterTypes(constructor));
		}

		public virtual object NewInstance(object[] parameters)
		{
			try
			{
				return constructor.Invoke(parameters);
			}
			catch
			{
				return null;
			}
		}
	}
}
