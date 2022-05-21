// See https://aka.ms/new-console-template for more information
using MapperlyTest.Entities;
using MapperlyTest.Mappers;
using System.Diagnostics;

Console.WriteLine("Hello, World!");


var admin = new AdminEntity { Email = "test@test.com", Name = "Juan Antonio Cano Salado", Token = "TestToken", Groups = new[] { "superadmin", "sales" } };
var dto = UserDTOMapper.Map(admin);


var user = new UserEntity { Email = "test@test.com", FirstName = "Juan Antonio", LastName = "Cano Salado", AuthenticationToken = "TestToken"};
var dto2 = UserDTOMapper.Map(user);

Console.WriteLine($"AdminEntity: {admin}");
Console.WriteLine($"User: {dto}\n");
Console.WriteLine($"UserEntity: {user}");
Console.WriteLine($"User: {dto2}");

Debugger.Break();
