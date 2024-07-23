using Dn1.APIs.Common;
using Dn1.Infrastructure.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dn1.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class CustomerFindManyArgs : FindManyInput<Customer, CustomerWhereInput> { }
