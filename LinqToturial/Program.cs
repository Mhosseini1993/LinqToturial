// See https://aka.ms/new-console-template for more information
using LinqToturial.Aggregation;
using LinqToturial.Comparer;
using LinqToturial.Filtering;
using LinqToturial.Grouping;
using LinqToturial.Joining;
using LinqToturial.Projection;
using LinqToturial.Quantifier;
using LinqToturial.Sorting;



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

#region Quantifier
QuantifierTest.UseAll();
QuantifierTest.UseAny();
QuantifierTest.UseContains();
#endregion

#region Aggregations
AggregationTest.UseAggregate();
AggregationTest.UseAverage();
AggregationTest.UseCount();
AggregationTest.UseMinMax();
#endregion


Console.ReadLine();
