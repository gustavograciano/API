using AutoMapper;
using FluentValidation.Results;
using System.Net;
using WMS.Sisdep.Application.Core.DTOs;
using WMS.Sisdep.Application.Interfaces;
using WMS.Sisdep.Domain.Core.Bodies;
using WMS.Sisdep.Domain.Core.Queries;
using WMS.Sisdep.Domain.Interfaces;
using WMS.Sisdep.Infra.Middleware;
using WMS.Sisdep.Infra.OldData.DTOs;

namespace WMS.Sisdep.Application.Services
{
    public class UsuarioApplicationService : IUsuarioApplicationService
    {
        private readonly IUsuarioDomainService _usuarioService;
        private readonly IMapper _mapper;
        public UsuarioApplicationService(
            IUsuarioDomainService usuarioService,
            IMapper mapper
        )
        {
            _usuarioService = usuarioService;
            _mapper = mapper;
        }

        public async Task<IEnumerable<UsuarioOldDTO>> GetAllOld()
        {
            return _mapper.Map<IEnumerable<UsuarioOldDTO>>(await _usuarioService.GetAllOld());
        }
        public async Task<PaginatedBaseDTO<UsuarioDTO>> GetAllWithPaginated(UsuarioQuery query)
        {
            return _mapper.Map<PaginatedBaseDTO<UsuarioDTO>>(await _usuarioService.GetAllWithPaginated(query));
        }
        public async Task Add(UsuarioBody body)
        {
            UsuarioBodyValidator validator = new();
            ValidationResult results = validator.Validate(body);

            if (!results.IsValid)
                throw new CustomException("Invalid Attribute", (int)HttpStatusCode.UnprocessableEntity, results.Errors[0].ToString());

            await _usuarioService.Add(body);
        }
        public async Task<IEnumerable<UsuarioDTO>> GetAll()
        {
            return _mapper.Map<IEnumerable<UsuarioDTO>>(await _usuarioService.GetAll());
        }

        public async Task<UsuarioDTO> GetById(Guid id)
        {
            return _mapper.Map<UsuarioDTO>(await _usuarioService.GetById(id));
        }

        public async Task Update(Guid id, UsuarioBody body)
        {
            UsuarioBodyValidator validator = new();
            ValidationResult results = validator.Validate(body);

            if (!results.IsValid)
                throw new CustomException("Invalid Attribute", (int)HttpStatusCode.UnprocessableEntity, results.Errors[0].ToString());

            await _usuarioService.Update(id, body);
        }

        public async Task Remove(Guid id)
        {
            await _usuarioService.Remove(id);
        }
    }
}
