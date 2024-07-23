using Microsoft.AspNetCore.Mvc;
using TestThePlugin.APIs.Common;
using TestThePlugin.Infrastructure.Models;

namespace TestThePlugin.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class CustomerFindManyArgs : FindManyInput<Customer, CustomerWhereInput> { }
