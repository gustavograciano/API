using AutoMapper;
using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WMS.Sisdep.Application.Core.DTOs;
using WMS.Sisdep.Application.Interfaces;
using WMS.Sisdep.Domain.Core.Bodies;
using WMS.Sisdep.Domain.Core.Queries;
using WMS.Sisdep.Domain.Interfaces;
using WMS.Sisdep.Infra.Middleware;

namespace WMS.Sisdep.Application.Services
{
    public class PermissaoApplicationService : IPermissaoApplicationService
    {
        private readonly IPermissaoDomainService _permissaoService;
        private readonly IMapper _mapper;
        public PermissaoApplicationService(
            IPermissaoDomainService permissaoService,
            IMapper mapper
        )
        {
            _permissaoService = permissaoService;
            _mapper = mapper;
        }

        public async Task Add(PermissaoBody body)
        {
            PermissaoBodyValidator validator = new();
            ValidationResult results = validator.Validate(body);

            if (!results.IsValid)
                throw new CustomException("Invalid Attribute", (int)HttpStatusCode.UnprocessableEntity, results.Errors[0].ToString());

            await _permissaoService.Add(body);
        }

        public async Task<IEnumerable<PermissaoDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<PermissaoDTO>>(await _permissaoService.GetAll());
        }

        public async Task<PaginatedBaseDTO<PermissaoDTO>> GetAllWithPaginated(PermissaoQuery query)
        {
            return _mapper.Map<PaginatedBaseDTO<PermissaoDTO>>(await _permissaoService.GetAllWithPaginated(query));
        }

        public async Task<PermissaoDTO> GetById(Guid id)
        {
            return _mapper.Map<PermissaoDTO>(await _permissaoService.GetById(id));
        }

        public async Task Remove(Guid id)
        {
            await _permissaoService.Remove(id);
        }

        public async Task Update(Guid id, PermissaoBody body)
        {
            PermissaoBodyValidator validator = new();
            ValidationResult results = validator.Validate(body);

            if (!results.IsValid)
                throw new CustomException("Invalid Attribute", (int)HttpStatusCode.UnprocessableEntity, results.Errors[0].ToString());

            await _permissaoService.Update(id, body);
        }
    }
    
    
}
