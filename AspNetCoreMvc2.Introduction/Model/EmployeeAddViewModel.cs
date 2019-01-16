using System.Collections.Generic;
using AspNetCoreMvc2.Introduction.Entities;
using Microsoft.Data.OData.Query.SemanticAst;

namespace AspNetCoreMvc2.Introduction.Model
{
    class EmployeeAddViewModel
    {
        public Employee Employee { get; set; }
        public List<SelectItem> Cities { get; internal set; }
    }
}