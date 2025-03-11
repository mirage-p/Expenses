using System;
using finance_app.Models;

namespace finance_app.Data.Service;

public interface IExpensesService
{
 Task<IEnumerable<Expense>> GetAll();
 Task Add(Expense expense);
 IQueryable GetChartData();
}
