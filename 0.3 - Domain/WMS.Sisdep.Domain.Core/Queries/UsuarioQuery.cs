using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMS.Sisdep.Domain.Core.Queries
{
    public class UsuarioQuery : PaginatedBaseQuery
    {
        public string Nome { get; set; }
    }
}
