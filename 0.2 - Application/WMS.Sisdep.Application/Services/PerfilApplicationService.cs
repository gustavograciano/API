using AutoMapper;
using FluentValidation.Results;
using System.Net;
using WMS.Sisdep.Application.Core.DTOs;
using WMS.Sisdep.Application.Interfaces;
using WMS.Sisdep.Domain.Core.Bodies;
using WMS.Sisdep.Domain.Core.Queries;
using WMS.Sisdep.Domain.Interfaces;
using WMS.Sisdep.Infra.Middleware;

namespace WMS.Sisdep.Application.Services
{
    public class PerfilApplicationService : IPerfilApplicationService
    {
        private readonly IPerfilDomainService _perfilService;
        private readonly IMapper _mapper;
        public PerfilApplicationService(
            IPerfilDomainService perfilService,
            IMapper mapper
        )
        {
            _perfilService = perfilService;
            _mapper = mapper;
        }

        public async Task Add(PerfilBody body)
        {
            PerfilBodyValidator validator = new();
            ValidationResult results = validator.Validate(body);

            if (!results.IsValid)
                throw new CustomException("Invalid Attribute", (int)HttpStatusCode.UnprocessableEntity, results.Errors[0].ToString());

            await _perfilService.Add(body);
        }

        public async Task<PaginatedBaseDTO<PerfilDTO>> GetAllWithPaginated(PerfilQuery query)
        {
            return _mapper.Map<PaginatedBaseDTO<PerfilDTO>>(await _perfilService.GetAllWithPaginated(query));
        }

        public async Task<PerfilDTO> GetById(Guid id)
        {
            return _mapper.Map<PerfilDTO>(await _perfilService.GetById(id));
        }

        public async Task Remove(Guid id)
        {
            await _perfilService.Remove(id);
        }

        public async Task Update(Guid id, PerfilBody body)
        {
            PerfilBodyValidator validator = new();
            ValidationResult results = validator.Validate(body);

            if (!results.IsValid)
                throw new CustomException("Invalid Attribute", (int)HttpStatusCode.UnprocessableEntity, results.Errors[0].ToString());

            await _perfilService.Update(id, body);
        }
    }
}
