//Service for interacting with Semantic Kernel

using Company.Data;
using Company.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.SemanticKernel;
using Azure.Identity;
using Microsoft.SemanticKernel.SkillDefinition;

namespace Company.Services;

public interface ISKService{
    public Task<string> GetResponse(APIRequest input);
}

public class SKService : ISKService 
{
    private readonly CompanyDBContext _context;

    private IKernel _kernel;
    private ISKFunction _sayHello;
    private ISKFunction _queryDatabase;

    public SKService(CompanyDBContext context)
    {
        _context = context;

        var builder = new KernelBuilder();
        var credential = new DefaultAzureCredential();
        builder.WithAzureChatCompletionService("gpt3-5","https://dm-openai-test-env.openai.azure.com/", credential);

        _kernel = builder.Build();
        var prompt = @"Respond to the user input in a friendly way.
        ===================
        {{$input}}
        ===================";
        _sayHello = _kernel.CreateSemanticFunction(prompt);

        prompt = @"Respond with a SQL query for the requested information. The database server is Microsoft SQL Server. The database has 3 tables with the following fields
        Stores: Id, Name, Location, OpenTime, CloseTime
        Products: Id, Name, Description, Price
        StockEntries: Id, StoreId, ProductId, Quantity
        ===================
        {{$input}}
        ===================";

        _queryDatabase = _kernel.CreateSemanticFunction(prompt);
    }

    public async Task<string> GetResponse(APIRequest input)
    {

        var query = _queryDatabase.InvokeAsync(input.Input);
        var response = await query;
        var result = _context.Database.SqlQueryRaw<string>(response.Result);
        Console.WriteLine(result);
        return result.ToString();
    }
}