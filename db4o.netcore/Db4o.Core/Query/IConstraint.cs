/* Copyright (C) 2004 - 2011  Versant Inc.  http://www.db4o.com */

using Db4o.Query;

namespace Db4o.Query
{
	/// <summary>
	/// Constraint to limit the objects returned upon <see cref="IQuery.Execute">query execution</see>.
	/// <br/><br/>
	/// Constraints are constructed by calling <see cref="IQuery.Constrain">query execution</see>
	/// <br/><br/>
	/// Constraints can be joined with the methods <see cref="And"/>
	/// and <see cref="Or"/>.
	/// <br/><br/>
	/// The methods to modify the constraint evaluation algorithm may
	/// be merged, to construct combined evaluation rules.
	/// Examples:
	/// <ul>
	/// <li>For "smaller or equal": <pre>Constraint.Smaller().Equal()</pre>  </li>
	/// <li>For "not like": <pre>Constraint.Not().Like()</pre> </li>
	/// <li>For "not greater or equal": <pre>Constraint.Not().Greater().Equal()</pre> </li>
	/// </ul>
	/// </summary>
	public interface IConstraint
	{
		/// <summary>Links two Constraints for AND evaluation.</summary>
		/// <remarks>
		/// Links two Constraints for AND evaluation.
		/// For example:<br/>
		/// <code>
		/// query.Constrain(typeof(Pilot));
		/// query.Descend("points").Constrain(101).Smaller().And(query.Descend("name").Constrain("John"));	</code><br/>
		/// will retrieve all pilots with points less than 101 and name as "John"<br/>
		/// </remarks>
		/// <param name="with">
		/// the other
		/// <see cref="Db4o.Query.IConstraint">Db4o.Query.IConstraint</see>
		/// </param>
		/// <returns>
		/// a new constrain, that can be used for further calls
		/// to <see cref="And"/> and <see cref="Or"/>
		/// </returns>
		IConstraint And(IConstraint with);

		/// <summary>Links two Constraints for OR evaluation.</summary>
		/// <remarks>
		/// links two Constraints for OR evaluation.
		/// For example:<br/><br/>
		/// <code>
		/// query.Constrain(typeof(Pilot));
		/// query.Descend("points").Constrain(101).Greater().Or(query.Descend("name").Constrain("Test Pilot0"));</code><br/>
		/// will retrieve all pilots with points more than 101 or pilots with the name "Test Pilot0"<br/>
		/// </remarks>
		/// <param name="with">
		/// the other
		/// <see cref="Db4o.Query.IConstraint">Db4o.Query.IConstraint</see>
		/// </param>
		/// <returns>
		/// a new constrain, that can be used for further calls
		/// to <see cref="And"/> and <see cref="Or"/>
		/// </returns>
		IConstraint Or(IConstraint with);

		/// <summary>
		/// Used in conjunction with
		/// <see cref="Smaller"/>
		/// or
		/// <see cref="Greater"/>
		/// to create constraints
		/// like "smaller or equal", "greater or equal".
		/// For example:<br/>
		/// <code>
		/// query.Constrain(typeof(Pilot));
		/// query.Descend("points").Constrain(101).Smaller().Equal();</code><br/>
		/// will return all pilots with points &lt;= 101.<br/>
		/// </summary>
		/// <returns>
		/// this constrain to allow the chaining of method calls.
		/// </returns>
		IConstraint Equal();

		/// <summary>Sets the evaluation mode to &gt;.</summary>
		/// <remarks>
		/// Sets the evaluation mode to &gt;.
		/// For example:<br/>
		/// <code>
		/// query.Constrain(typeof(Pilot));
		/// query.Descend("points").Constrain(101).Greater()</code><br/>
		/// will return all pilots with points &gt; 101.<br/>
		/// </remarks>
		/// <returns>
		/// this constrain to allow the chaining of method calls.
		/// </returns>
		IConstraint Greater();

		/// <summary>Sets the evaluation mode to &gt;&lt;.</summary>
		/// <remarks>
		/// Sets the evaluation mode to &lt;.
		/// For example:<br/>
		/// <code>
		/// query.Constrain(typeof(Pilot));
		/// query.Descend("points").Constrain(101).Smaller()</code><br/>
		/// will return all pilots with points &lt; 101.<br/>
		/// </remarks>
		/// <returns>
		/// this constrain to allow the chaining of method calls.
		/// </returns>
		IConstraint Smaller();

		/// <summary>Sets the evaluation mode to identity comparison.</summary>
		/// <remarks>
		/// Sets the evaluation mode to identity comparison. In this case only
		/// objects having the same database identity will be included in the result set.
		/// For example:<br/>
		/// <code>
		/// var pilot = new Pilot("Test Pilot1", 100);
		/// var car = new Car("Ferrari", pilot);
		/// container.Store(car);
		/// var otherCar = new Car("Ferrari", pilot);
		/// container.Store(otherCar);
		/// Query query = container.Query();
		/// query.Constrain(typeof(Car));
		/// // All cars having pilot with the same database identity
		/// // will be retrieved.
		/// query.Descend("pilot").Constrain(pilot).Identity();</code>
		/// </remarks>
		/// <returns>
		/// this constrain to allow the chaining of method calls.
		/// </returns>
		IConstraint Identity();

		/// <summary>Set the evaluation mode to object comparison (query by example).</summary>
		/// <remarks>Set the evaluation mode to object comparison (query by example).</remarks>
		/// <returns>this to allow the chaining of method calls.</returns>
		IConstraint ByExample();

		/// <summary>Sets the evaluation mode to "like" comparison.</summary>
		/// <remarks>
		/// This is a contains comparison which is case insensitive. This only works on strings. This mode will include
		/// all objects having the constrain expression somewhere inside the string field.
		/// For example:<br/>
		/// <code>
		/// var pilot = new Pilot("Test Pilot1", 100);
		/// container.Store(pilot);
		/// ...
		/// query.Constrain(typeof(Pilot));
		/// // All pilots with the name containing "est" will be retrieved
		/// query.Descend("name").Constrain("est").Like();</code>
		/// </remarks>
		/// <returns>
		/// this constrain to allow the chaining of method calls.
		/// </returns>
		IConstraint Like();

		/// <summary>Sets the evaluation mode to string contains comparison.</summary>
		/// <remarks>
		/// Sets the evaluation mode to string contains comparison. This only works on strings.
		/// The contains comparison is case sensitive.
		/// For example:<br/>
		/// <code>
		/// Pilot pilot = new Pilot("Test Pilot1", 100);
		/// container.Store(pilot);
		/// ...
		/// query.Constrain(typeof(Pilot));
		/// // All pilots with the name containing "est" will be retrieved
		/// query.Descend("name").Constrain("est").Contains();</code>
		/// </remarks>
		/// <returns>
		/// this constrain to allow the chaining of method calls.
		/// </returns>
		IConstraint Contains();

		/// <summary>Sets the evaluation mode to string StartsWith comparison.</summary>
		/// <remarks>
		/// Sets the evaluation mode to string StartsWith comparison.
		/// For example:<br/>
		/// <code>
		/// Pilot pilot = new Pilot("Test Pilot0", 100);
		/// container.Store(pilot);
		/// ...
		/// query.Constrain(typeof(Pilot));
		/// query.Descend("name").Constrain("Test").StartsWith(true);</code><br/>
		/// </remarks>
		/// <param name="caseSensitive">comparison will be case sensitive if true, case insensitive otherwise
		/// </param>
		/// <returns>
		/// this constrain to allow the chaining of method calls.
		/// </returns>
		IConstraint StartsWith(bool caseSensitive);

		/// <summary>Sets the evaluation mode to string EndsWith comparison.</summary>
		/// <remarks>
		/// Sets the evaluation mode to string EndsWith comparison.
		/// For example:<br/>
		/// <code>
		/// Pilot pilot = new Pilot("Test Pilot0", 100);
		/// container.Store(pilot);
		/// ...
		/// query.Constrain(typeof(Pilot));
		/// query.Descend("name").Constrain("T0").EndsWith(false);</code><br/>
		/// </remarks>
		/// <param name="caseSensitive">comparison will be case sensitive if true, case insensitive otherwise
		/// </param>
		/// <returns>
		/// this constrain to allow the chaining of method calls.
		/// </returns>
		IConstraint EndsWith(bool caseSensitive);

		/// <summary>Turns on Not() comparison.</summary>
		/// <remarks>
		/// Turns on Not() comparison. All objects not full filling the constrain condition will be returned.
		/// For example:<br/>
		/// <code>
		/// Pilot pilot = new Pilot("Test Pilot1", 100);
		/// container.Store(pilot);
		/// ...
		/// query.Constrain(typeof(Pilot));
		/// query.Descend("name").Constrain("t0").EndsWith(true).Not();</code><br/>
		/// </remarks>
		/// <returns>
		/// this constrain to allow the chaining of method calls.
		/// </returns>
		IConstraint Not();

		/// <summary>
		/// Returns the Object the query graph was constrained with to
		/// create this
		/// <see cref="IConstraint">IConstraint</see>
		/// .
		/// </summary>
		/// <returns>Object the constraining object.</returns>
		object GetObject();
	}
}
