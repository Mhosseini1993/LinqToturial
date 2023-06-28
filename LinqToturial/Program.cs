// See https://aka.ms/new-console-template for more information
using LinqToturial.Filtering;
using LinqToturial.Grouping;
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



Console.ReadLine();
