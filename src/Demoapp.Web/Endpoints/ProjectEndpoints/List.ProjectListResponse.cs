using System.Collections.Generic;
using Demoapp.Core.ProjectAggregate;

namespace Demoapp.Web.Endpoints.ProjectEndpoints;

public class ProjectListResponse
{
    public List<ProjectRecord> Projects { get; set; } = new();
}
