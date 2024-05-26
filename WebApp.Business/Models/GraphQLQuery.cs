﻿namespace WebApp.Business.Models;

public class GraphQLQuery
{
    public string Query { get; set; } = null!;
    public object? Variables { get; set; }
}
