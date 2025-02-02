﻿namespace fh_family_experience_web.Endpoints.ProjectEndpoints;

using fh_family_experience_web.Endpoints.Records;

public class GetProjectByIdResponse
{
    public GetProjectByIdResponse() { }
    public GetProjectByIdResponse(int id, string name, List<ToDoItemRecord> items)
    {
        Id = id;
        Name = name;
        Items = items;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public List<ToDoItemRecord> Items { get; set; } = new();
}
