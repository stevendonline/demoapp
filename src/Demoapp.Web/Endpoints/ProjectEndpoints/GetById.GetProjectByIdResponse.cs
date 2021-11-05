using System.Collections.Generic;

namespace Demoapp.Web.Endpoints.ProjectEndpoints
{
    public class GetProjectByIdResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ToDoItemRecord> Items { get; set; } = new();
    }
}