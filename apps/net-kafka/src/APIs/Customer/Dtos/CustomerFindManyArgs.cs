using Microsoft.AspNetCore.Mvc;
using NetKafka.APIs.Common;
using NetKafka.Infrastructure.Models;

namespace NetKafka.APIs.Dtos;

[BindProperties(SupportsGet = true)]
public class CustomerFindManyArgs : FindManyInput<Customer, CustomerWhereInput> { }
