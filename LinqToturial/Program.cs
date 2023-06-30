// See https://aka.ms/new-console-template for more information
using LinqToturial.Aggregation;
using LinqToturial.Comparer;
using LinqToturial.Element;
using LinqToturial.Filtering;
using LinqToturial.Grouping;
using LinqToturial.Joining;
using LinqToturial.Projection;
using LinqToturial.Quantifier;
using LinqToturial.Sets;
using LinqToturial.Sorting;



#region Filtering
FilteringSample.UseWhere();
FilteringSample.UseWhereWithIndex();
FilteringSample.UseOfType();
FilteringSample.SearchWithLambada(new RequestSearchStudentDto("m", string.Empty, string.Empty, 0));
FilteringSample.SearchWithExpression(new RequestSearchStudentDto("m", string.Empty, string.Empty, 0));
#endregion

#region Sorting
SortingSample.UserOrderByAsc();
SortingSample.UserOrderByThenByAsc();
SortingSample.UserOrderByDesc();
SortingSample.UserOrderByThenByDesc();
SortingSample.UseReverse();
#endregion

#region Grouping
GroupingSample.UseGroupBy();
GroupingSample.UseLookup();
#endregion

#region Joining
JoiningSample.UseJoin();
JoiningSample.UseGroupJoin();
#endregion

#region Projection
ProjectionSample.UseSelect();
ProjectionSample.UseSelectMany();
#endregion

#region Comparer
ComparerSample.UseEqualityComparer();
ComparerSample.UseComparer();
#endregion

#region Quantifier
QuantifierSample.UseAll();
QuantifierSample.UseAny();
QuantifierSample.UseContains();
#endregion

#region Aggregations
AggregationSample.UseAggregate();
AggregationSample.UseAverage();
AggregationSample.UseCount();
AggregationSample.UseMinMax();
#endregion

#region Element
ElementSample.UseElementAt();
ElementSample.UseFirst();
ElementSample.UseLast();
ElementSample.UseSingle();
#endregion

#region Sets
SetSample.UseDistinct();
SetSample.UseExcept();
SetSample.UseIntersect();
SetSample.UseUnion();
#endregion

Console.ReadLine();
