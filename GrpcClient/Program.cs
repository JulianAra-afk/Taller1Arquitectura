using System;
using System.Threading.Tasks;
using Grpc.Net.Client;
using GrpcService;

var channel = GrpcChannel.ForAddress("http://localhost:5015");
var client = new ServicesProduct.ServicesProductClient(channel);

Console.Write("Enter product ID to fetch: ");
int productId = int.Parse(Console.ReadLine());

// Hacer la llamada al servicio gRPC
var reply = await client.SendProductAsync(new ProductRequest { Id = productId });
var receivedProduct = reply.Product;

// Mostrar la información del producto en consola
Console.WriteLine($"Received product: ID={receivedProduct.Id}, Name={receivedProduct.Name}, Price={receivedProduct.Price}");

