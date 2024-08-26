using Dnet123.APIs.Common;
using Dnet123.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dnet123.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class CustomerFindManyArgs : FindManyInput<Customer, CustomerWhereInput> { }
