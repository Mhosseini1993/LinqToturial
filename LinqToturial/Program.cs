// See https://aka.ms/new-console-template for more information
using LinqToturial.Comparer;
using LinqToturial.Filtering;
using LinqToturial.Grouping;
using LinqToturial.Joining;
using LinqToturial.Projection;
using LinqToturial.Quantifier;
using LinqToturial.Sorting;

QuantifierTest.UseContains();

#region Filtering
FilteringTest.UseWhere();
FilteringTest.UseWhereWithIndex();
FilteringTest.UseOfType();
FilteringTest.SearchWithLambada(new RequestSearchStudentDto("m", string.Empty, string.Empty, 0));
FilteringTest.SearchWithExpression(new RequestSearchStudentDto("m", string.Empty, string.Empty, 0));
#endregion

#region Sorting
SortingTest.UserOrderByAsc();
SortingTest.UserOrderByThenByAsc();
SortingTest.UserOrderByDesc();
SortingTest.UserOrderByThenByDesc();
SortingTest.UseReverse();
#endregion

#region Grouping
GroupingTest.UseGroupBy();
GroupingTest.UseLookup();
#endregion

#region Joining
JoiningTest.UseJoin();
JoiningTest.UseGroupJoin();
#endregion

#region Projection
ProjectionTest.UseSelect();
ProjectionTest.UseSelectMany();
#endregion

#region Comparer
ComparerTest.UseEqualityComparer();
ComparerTest.UseComparer();
#endregion

Console.ReadLine();
